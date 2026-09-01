# Audius SDK

Generated .NET client for Audius's official OpenAPI document.

## Regeneration

Run `src/libs/Audius/generate.sh` from the repository root. The script refreshes the official schema and regenerates `Generated/`; never edit that directory manually.

Most catalog reads and public-track streams are anonymous. API keys are optional for higher rate limits and required only for tracks whose metadata restricts streaming to specific application keys.

The Advantage integration depends on typed track search, ISRC metadata, and `/tracks/{track_id}/stream`. Keep those operations public and cover anonymous search plus stream URL resolution in integration tests.
