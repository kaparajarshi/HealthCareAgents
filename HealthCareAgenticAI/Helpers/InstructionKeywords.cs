using System.Collections.Frozen;

namespace HealthCareAgenticAI.Helpers
{
    public static class InstructionKeywords
    {
        public static readonly FrozenSet<string> Actions = new[]
        {
            "approve",
            "deny",
            "pend",
            "email",
            "fax"
        }.ToFrozenSet(StringComparer.OrdinalIgnoreCase);
    }
}