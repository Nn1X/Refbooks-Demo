using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F011XmlMapperConfiguration
    {
        public static XmlMapper<F011> AddF011RefbookConfiguration(this XmlMapper<F011> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(
                    element.Element("IDDoc")?.Value))
                .MapWith((element, model) => model.DocumentSerialMask = NullableConvert.ConvertToNullableString(element.Element("DocSer")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("DocName")?.Value))
                .MapWith((element, model) => model.DocumentNumberMask = NullableConvert.ConvertToNullableString(element.Element("DocNum")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
