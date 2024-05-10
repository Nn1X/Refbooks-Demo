using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.KRefbooksXmlMapperConfigurations
{
    public static class K003XmlMapperConfiguration
    {
        public static XmlMapper<K003> AddK003RefbookConfiguration(this XmlMapper<K003> mapper)
        {
            mapper.MapWith((element, model) => model.CodeO002 = NullableConvert.ConvertToNullableString(element.Element("TF_OKATO")?.Value))
                .MapWith((element, model) => model.CodeV006 = NullableConvert.ConvertToNullableInt32(element.Element("IDUMP")?.Value))
                .MapWith((element, model) => model.BaseRate = NullableConvert.ConvertToNullableDecimal(element.Element("BZTSZ")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
