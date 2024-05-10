namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class ManagementKsgCoefficient
    {
        public int Id { get; set; }
        public string? KsgNumber{ get; set; }
        public decimal? Coefficient { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
