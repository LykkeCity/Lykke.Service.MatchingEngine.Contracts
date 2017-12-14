using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Lykke.Service.MatchingEngine.Contracts.Balances
{
    /// <summary>
    /// Update of the particular assets of the particular client
    /// </summary>
    [PublicAPI]
    public class ClientBalanceUpdateModel
    {
        [JsonProperty("id")]
        public string ClientId { get; set; }
        public string Asset { get; set; }
        public double OldBalance { get; set; }
        public double NewBalance { get; set; }
        public double OldReserved { get; set; }
        public double NewReserved { get; set; }
    }
}