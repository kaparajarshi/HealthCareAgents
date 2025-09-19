namespace HealthCareAgenticAI.Models
{
    public sealed record ResponseModel
    {
        public string? ClaimId { get; set; }
        public string? ReferencedClaimId { get; set; }
        public string? Instructions { get; set; }
        public string? Summary { get; set; }
    }
}