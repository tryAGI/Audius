
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsdcTransactionsTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        InternalTransfer,
        /// <summary>
        ///
        /// </summary>
        PrepareWithdrawal,
        /// <summary>
        ///
        /// </summary>
        PurchaseContent,
        /// <summary>
        ///
        /// </summary>
        PurchaseStripe,
        /// <summary>
        ///
        /// </summary>
        RecoverWithdrawal,
        /// <summary>
        ///
        /// </summary>
        Transfer,
        /// <summary>
        ///
        /// </summary>
        Withdrawal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsdcTransactionsTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionsTypeItem value)
        {
            return value switch
            {
                GetUsdcTransactionsTypeItem.InternalTransfer => "internal_transfer",
                GetUsdcTransactionsTypeItem.PrepareWithdrawal => "prepare_withdrawal",
                GetUsdcTransactionsTypeItem.PurchaseContent => "purchase_content",
                GetUsdcTransactionsTypeItem.PurchaseStripe => "purchase_stripe",
                GetUsdcTransactionsTypeItem.RecoverWithdrawal => "recover_withdrawal",
                GetUsdcTransactionsTypeItem.Transfer => "transfer",
                GetUsdcTransactionsTypeItem.Withdrawal => "withdrawal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionsTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "internal_transfer" => GetUsdcTransactionsTypeItem.InternalTransfer,
                "prepare_withdrawal" => GetUsdcTransactionsTypeItem.PrepareWithdrawal,
                "purchase_content" => GetUsdcTransactionsTypeItem.PurchaseContent,
                "purchase_stripe" => GetUsdcTransactionsTypeItem.PurchaseStripe,
                "recover_withdrawal" => GetUsdcTransactionsTypeItem.RecoverWithdrawal,
                "transfer" => GetUsdcTransactionsTypeItem.Transfer,
                "withdrawal" => GetUsdcTransactionsTypeItem.Withdrawal,
                _ => null,
            };
        }
    }
}