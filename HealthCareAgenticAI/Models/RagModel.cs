namespace HealthCareAgenticAI.Models
{
    public sealed record RagModel(string Text, List<RagNamedEntityModel> Entities, double Score);
    public sealed record RagNamedEntityModel(string Entity, string Type);
    public static class RagLabels
    {
        public const string ClaimLabel = "ClaimId";
        public const string InstructionsLabel = "Instructions";
        public const string ReferenceLabel = "ReferenceClaimId";
        public const string SummaryLabel = "Summary";
        public const string GoodEntry = "Good";
        public const string BadEntry = "Bad";
    }
}