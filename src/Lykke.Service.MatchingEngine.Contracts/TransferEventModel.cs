using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Service.MatchingEngine.Contracts
{
    public class TransferEventModel
    {
        public string Id { get; set; }
        public string FromClientId { get; set; }
        public string ToClientId { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public decimal Volume { get; set; }
        public decimal OverdraftLimit { get; set; }
        public string Asset { get; set; }
        public TransferFeeInstructionModel FeeInstruction { get; set; }
    }
}
