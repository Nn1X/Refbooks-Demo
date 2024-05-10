using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refbooks.Domain.Yamed.KsgCalculation
{
    public class ServiceTemplate
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? CodeVme { get; set; }
        public decimal? Count { get; set; }
        public decimal? Tariff { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? Profile { get; set; }
        public int? ChildSign { get; set; }
        public int? Specialization { get; set; }
        public int? Mandatory { get; set; }
        public int? ComplexityMandatory { get; set; }
    }
}
