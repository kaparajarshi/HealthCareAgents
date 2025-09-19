namespace HealthCareAgenticAI.Models
{
    public sealed record RequestModel : FeedbackModel
    {
        public string? ClaimId { get; init; }
        public bool IsThisFristRequestForClaim { get; init; }
    }
}