namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class HighTechMedicalCareTariff
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public decimal? Tariff { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
