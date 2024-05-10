namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class RegionalLaboratoryStudiesCalculation
    {
        public int Id { get; set; }

        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public string? ServiceNumber { get; set; }
        public string? ServiceCodeV001 { get; set;}
        public string? ServiceNameV001 { get; set; }
        public string? ServiceCodeLis { get; set; }
        public string? ServiceNameLis { get; set; }
        public string? ServiceCodeRegional { get; set; }
        public string? ServiceNameRegional { get; set; }
        public decimal? Tariff { get; set; }
        public int? AssistanceType { get; set; }
        public int? AssistanceProfile { get; set; }
        public int? AssistanceSpecialization { get; set; }
        public int? AssistanceForm { get; set; }
        public int? AssistanceIssue { get; set; }
        public string? VisitPurpose { get; set; }
        public int? AssistanceResult { get; set; }
        public int? PaymentMethodCode { get; set; }

    }
}
