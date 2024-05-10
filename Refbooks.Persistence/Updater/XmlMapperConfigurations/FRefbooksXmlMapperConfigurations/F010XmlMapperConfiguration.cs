using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F010XmlMapperConfiguration
    {
        public static XmlMapper<F010> AddF010RefbookConfiguration(this XmlMapper<F010> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("KOD_TF")?.Value))
                .MapWith((element, model) => model.Okato = NullableConvert.ConvertToNullableString(element.Element("KOD_OKATO")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("SUBNAME")?.Value))
                .MapWith((element, model) => model.FederalDistrictCode = NullableConvert.ConvertToNullableInt32(
                    element.Element("OKRUG")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
