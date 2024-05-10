using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F014XmlMapperConfiguration
    {
        public static XmlMapper<F014> AddF014RefbookConfiguration(this XmlMapper<F014> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(
                    element.Element("Kod")?.Value))
                .MapWith((element, model) => model.CodeReserveField = NullableConvert.ConvertToNullableInt32(
                    element.Element("IDVID")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("Naim")?.Value))
                .MapWith((element, model) => model.RefusalReason = NullableConvert.ConvertToNullableString(element.Element("Osn")?.Value))
                .MapWith((element, model) => model.Comment = NullableConvert.ConvertToNullableString(element.Element("Komment")?.Value))
                .MapWith((element, model) => model.SanctionCoefficient = NullableConvert.ConvertToNullableDecimal(element.Element("K_NO")?.Value))
                .MapWith((element, model) => model.PenaltyCoefficient = NullableConvert.ConvertToNullableDecimal(element.Element("K_SH")?.Value))
                .MapWith((element, model) => model.PgFormCode = NullableConvert.ConvertToNullableString(element.Element("KodPG")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
