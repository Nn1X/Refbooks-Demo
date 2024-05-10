namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class CalculationMoCoefficient
    {
        public int Id { get; set; }
        public string? MoCode { get; set; }
        public decimal? HospitalLevelCoefficient { get; set; }
        public decimal? OutpatientCareCoefficient { get; set; }
        public decimal? SpecificityEmcCoefficient { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
