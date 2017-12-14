using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Lykke.Service.MatchingEngine.Contracts.Balances
{
    /// <summary>
    /// Reason of the client balances update
    /// </summary>
    [PublicAPI]
    public enum BalanceUpdateEventType
    {
        [EnumMember(Value = "CASH_IN_OUT_OPERATION")]
        CashInOutOperation,
        [EnumMember(Value = "CASH_OPERATION")]
        CashOperation,
        [EnumMember(Value = "CASH_SWAP_OPERATION")]
        CashSwapOperation,
        [EnumMember(Value = "CASH_TRANSFER_OPERATION")]
        CashTransferOperation,
        [EnumMember(Value = "MARKET_ORDER")]
        MarketOrder,
        [EnumMember(Value = "BALANCE_UPDATE")]
        BalanceUpdate,
        [EnumMember(Value = "LIMIT_ORDER")]
        LimitOrder,
        [EnumMember(Value = "LIMIT_ORDER_CANCEL")]
        LimitOrderCancel,
        [EnumMember(Value = "MULTI_LIMIT_ORDER")]
        MultiLimitOrder
    }
}