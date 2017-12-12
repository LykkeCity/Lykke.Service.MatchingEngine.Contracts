using System;

namespace Lykke.Service.MatchingEngine.Contracts
{
    public class CashInOutEventModel
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public decimal Volume { get; set; }
        public string Asset { get; set; }
    }
}
