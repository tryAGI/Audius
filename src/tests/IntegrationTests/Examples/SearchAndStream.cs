/*
order: 10
title: Search and Stream
slug: search-and-stream
*/

namespace Audius.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task AnonymousCatalogSearchReturnsTypedTrackMetadata()
    {
        //// Public Audius catalog reads do not require credentials. Search results expose the
        //// title, uploader identity, streamability, and optional ISRC needed for exact matching.
        using var client = new AudiusClient();

        var response = await client.Tracks.SearchTracksAsync(
            query: "Audius",
            limit: 5,
            cancellationToken: CancellationToken.None);

        Assert.IsNotNull(response.Data);
        Assert.IsNotEmpty(response.Data);
        Assert.IsTrue(response.Data.All(track => !string.IsNullOrWhiteSpace(track.Id)));
        Assert.IsTrue(response.Data.All(track => !string.IsNullOrWhiteSpace(track.Title)));
        Assert.IsTrue(response.Data.All(track => !string.IsNullOrWhiteSpace(track.User.Name)));
    }

    [TestMethod]
    public async Task AnonymousPublicTrackResolvesFullStreamUrl()
    {
        using var client = new AudiusClient();
        var search = await client.Tracks.SearchTracksAsync(
            query: "Audius",
            limit: 10,
            cancellationToken: CancellationToken.None);
        var track = search.Data?.FirstOrDefault(candidate => candidate.IsStreamable == true);
        Assert.IsNotNull(track, "Audius search did not return a streamable public track.");

        //// `noRedirect: true` keeps the SDK response typed and returns the validator-node URL
        //// instead of following the media redirect during this low-cost integration check.
        var stream = await client.Tracks.StreamTrackAsync(
            track.Id,
            preview: false,
            skipPlayCount: true,
            noRedirect: true,
            cancellationToken: CancellationToken.None);

        Assert.IsTrue(Uri.TryCreate(stream.Data, UriKind.Absolute, out var streamUri));
        Assert.AreEqual(Uri.UriSchemeHttps, streamUri.Scheme);
    }
}
