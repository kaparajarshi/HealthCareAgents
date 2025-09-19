namespace HealthCareAgenticAI.Models
{
    public record FeedbackModel
    {
        public bool FeedbackClaimId { get; set; }
        public bool FeedbackInstructions { get; set; }
        public bool FeedbackSummary { get; set; }
    }
}