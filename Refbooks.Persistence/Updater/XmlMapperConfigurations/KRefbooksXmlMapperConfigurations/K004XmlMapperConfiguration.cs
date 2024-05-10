using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.KRefbooksXmlMapperConfigurations
{
    public static class K004XmlMapperConfiguration
    {
        public static XmlMapper<K004> AddK004RefbookConfiguration(this XmlMapper<K004> mapper)
        {
            mapper.MapWith((element, model) => model.CodeO002 = NullableConvert.ConvertToNullableString(element.Element("TF_OKATO")?.Value))
                .MapWith((element, model) => model.CoeffiecientNumber = NullableConvert.ConvertToNullableInt32(element.Element("IDSL")?.Value))
                .MapWith((element, model) => model.CoeffiecientNumberReason = NullableConvert.ConvertToNullableInt32(element.Element("NPR")?.Value))
                .MapWith((element, model) => model.CoeffiecientValue = NullableConvert.ConvertToNullableDecimal(element.Element("ZKOEF")?.Value))
                .MapWith((element, model) => model.CoefficientApplyingCondition = NullableConvert.ConvertToNullableString(element.Element("USLKOEF")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
