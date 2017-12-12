namespace Lykke.Service.MatchingEngine.Contracts
{
    public class TransferFeeInstructionModel
    {
        public string Type { get; set; }
        public string SizeType { get; set; }
        public string SourceClientId { get; set; }
        public string TargetClientId { get; set; }
    }
}