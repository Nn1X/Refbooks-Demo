namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class KsgCalculation
    {
        public int Id { get; set; }
        public int? AssistanceTerms { get; set; }
        public string? KsgNumber { get; set; }
        public string? KsgName { get; set; }
        public decimal? CostIintensityCoefficient { get; set; }
        public string? KsgType { get; set; }
        public string? ManagementCoefficientSign { get; set; }
        public string? OptimalDurationTreatmentSign { get; set; }
        public decimal? SalaryShare { get; set; }
        public string? DiagnosisSing { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
