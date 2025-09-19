namespace HealthCareAgenticAI.Models
{
    public sealed record EvaluatorModel : FeedbackModel
    {
        public string? AiEvaluation { get; init; }
    }
}