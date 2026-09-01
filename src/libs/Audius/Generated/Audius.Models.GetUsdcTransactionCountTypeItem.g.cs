
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsdcTransactionCountTypeItem
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
    public static class GetUsdcTransactionCountTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionCountTypeItem value)
        {
            return value switch
            {
                GetUsdcTransactionCountTypeItem.InternalTransfer => "internal_transfer",
                GetUsdcTransactionCountTypeItem.PrepareWithdrawal => "prepare_withdrawal",
                GetUsdcTransactionCountTypeItem.PurchaseContent => "purchase_content",
                GetUsdcTransactionCountTypeItem.PurchaseStripe => "purchase_stripe",
                GetUsdcTransactionCountTypeItem.RecoverWithdrawal => "recover_withdrawal",
                GetUsdcTransactionCountTypeItem.Transfer => "transfer",
                GetUsdcTransactionCountTypeItem.Withdrawal => "withdrawal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionCountTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "internal_transfer" => GetUsdcTransactionCountTypeItem.InternalTransfer,
                "prepare_withdrawal" => GetUsdcTransactionCountTypeItem.PrepareWithdrawal,
                "purchase_content" => GetUsdcTransactionCountTypeItem.PurchaseContent,
                "purchase_stripe" => GetUsdcTransactionCountTypeItem.PurchaseStripe,
                "recover_withdrawal" => GetUsdcTransactionCountTypeItem.RecoverWithdrawal,
                "transfer" => GetUsdcTransactionCountTypeItem.Transfer,
                "withdrawal" => GetUsdcTransactionCountTypeItem.Withdrawal,
                _ => null,
            };
        }
    }
}