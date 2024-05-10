namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class UetDentistryCalculation
    {
        public int Id { get; set; }
        public string? ServiceCode{ get; set; }
        public string? ServiceName { get; set; }
        public decimal? AdultUetCount{ get; set; }
        public decimal? ChildUetCount { get; set; }
        public int? Multiple { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
