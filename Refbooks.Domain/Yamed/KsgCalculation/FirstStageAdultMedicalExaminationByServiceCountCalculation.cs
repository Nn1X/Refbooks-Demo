namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class FirstStageAdultMedicalExaminationByServiceCountCalculation
    {
        public int Id { get; set; }
        public decimal? GroupId { get; set; }
        public decimal? RegionalFeature { get; set; }
        public decimal? Gender { get; set; }
        public string? Age { get; set; }
        public decimal? ServiceCountByStandard { get; set; }
        public decimal? AcceptableServiceCount { get; set; }
    }
}
