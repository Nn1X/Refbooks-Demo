namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class FirstStageAdultProfessionalExaminationCalculation
    {
        public int Id { get; set; }
        public string? AgeGroup { get; set; }
        public string? RegionalFeature { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public int? ObligationServiceSign { get; set; }
        public int? Specialization { get; set; }
        public int? Profile { get; set; }
        public int ChildSign { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
