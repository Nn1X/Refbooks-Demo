namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class KsgBaseRate
    {
        public int Id { get; set; }
        public int? AssistanceTerms { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
