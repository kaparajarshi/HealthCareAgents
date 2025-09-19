using System.Text.RegularExpressions;

namespace HealthCareAgenticAI.Helpers
{
    public static partial class CustomRegex
    {
        [GeneratedRegex(@"^[A-Za-z0-9-]{10}$")]
        public static partial Regex ClaimIdStrict();
        [GeneratedRegex(@"\b([A-Za-z0-9-]{10})\b")]
        public static partial Regex ClaimIdCandidate();
        [GeneratedRegex(@"(?<=[.!?])\s+(?=[A-Z0-9])")] //use this in data extrcted in regex and evaluate with LLM on strict regex to see the difference
        public static partial Regex InstructionStrict();
        [GeneratedRegex(@"\b(claim|id|#)\b")]
        public static partial Regex InstructionCandidate(); //use this in data extrcted in regex and evaluate with LLM on strict regex to see the difference
        [GeneratedRegex(@"\s+")]
        public static partial Regex SentenceCandidate();
    }
}