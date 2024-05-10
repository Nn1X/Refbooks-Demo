namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class MobileTeamsMedicalExaminationCoefficient
    {
        public int Id { get; set; }
        public string? RegionalFeature { get; set; }
        public int? TeamType { get; set; }
        public decimal? Coefficient { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
