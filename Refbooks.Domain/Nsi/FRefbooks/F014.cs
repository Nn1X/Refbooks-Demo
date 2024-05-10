namespace Refbooks.Domain.Nsi.FRefbooks
{
    public class F014
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public int? CodeReserveField { get; set; }
        public string? Name { get; set; }
        public string? RefusalReason { get; set; }
        public string? Comment { get; set; }
        public decimal? SanctionCoefficient { get; set; }
        public decimal? PenaltyCoefficient { get; set; }
        public string? PgFormCode { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
