namespace HealthCareAgenticAI.Helpers
{
    public static partial class TextNormalize
    {
        public static string NormalizeText(string text)
        {
            return CustomRegex.SentenceCandidate()
                .Replace(text.Replace('-', '-').Replace("\r\n", " ").Replace('\n', ' '), " ")
                .Trim()
                .ToLower();
        }
    }
}