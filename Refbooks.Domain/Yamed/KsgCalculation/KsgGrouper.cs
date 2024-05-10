namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class KsgGrouper
    {
        public int Id { get; set; }
        public string? MainDiagnosis{ get; set; }
        public string? ConcomitantDiagnosis { get; set; }
        public string? ComplicationDiagnosis { get; set; }
        public string? ServiceCode { get; set; }
        public string? AgeGroup { get; set; }
        public string? Gender { get; set; }
        public int? TreatmentDuration { get; set; }
        public string? KsgNumber { get; set; }
        public int? SType { get; set; }
        public string? AdditionalCriteria{ get; set; }
        public string? FractionsRange { get; set; }
        public string? Number { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
