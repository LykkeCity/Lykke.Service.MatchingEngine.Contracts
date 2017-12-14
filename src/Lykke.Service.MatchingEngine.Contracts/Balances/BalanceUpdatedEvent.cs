using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Lykke.Service.MatchingEngine.Contracts.Balances
{
    /// <summary>
    /// Client balances were updated
    /// Exchange name: lykke.balanceupdate
    /// </summary>
    [PublicAPI]
    public class BalanceUpdatedEvent
    {
        [JsonProperty("id")]
        public string TransactionId { get; set; }
        public BalanceUpdateEventType Type { get; set; }
        public DateTime Timestamp { get; set; }
        public IReadOnlyList<ClientBalanceUpdateModel> Balances { get; set; }
    }
}