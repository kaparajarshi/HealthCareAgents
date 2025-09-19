namespace HealthCareAgenticAI.Models
{
    public sealed record ClaimModel
    {
        public string ClaimId { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime DateOfService { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}