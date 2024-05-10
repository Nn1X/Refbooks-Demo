namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class RegionalServiceTariff
    {
        public int Id { get; set; }
        public string? ServiceCode { get; set; }
        public decimal? Tariff { get; set; }
        public int? AssistanceTerms { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }        
    }
}
