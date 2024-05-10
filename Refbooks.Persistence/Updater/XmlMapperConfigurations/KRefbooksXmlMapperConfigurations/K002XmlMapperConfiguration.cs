using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.KRefbooksXmlMapperConfigurations
{
    public static class K002XmlMapperConfiguration
    {
        public static XmlMapper<K002> AddK002RefbookConfiguration(this XmlMapper<K002> mapper)
        {
            mapper.MapWith((element, model) => model.CodeO002 = NullableConvert.ConvertToNullableString(element.Element("TF_OKATO")?.Value))
                .MapWith((element, model) => model.CodeV006 = NullableConvert.ConvertToNullableInt32(element.Element("IDUMP")?.Value))
                .MapWith((element, model) => model.MedicalCare = NullableConvert.ConvertToNullableString(element.Element("LVL")?.Value))
                .MapWith((element, model) => model.MedicalCareCoefficient = NullableConvert.ConvertToNullableDecimal(element.Element("KOEF_U")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
