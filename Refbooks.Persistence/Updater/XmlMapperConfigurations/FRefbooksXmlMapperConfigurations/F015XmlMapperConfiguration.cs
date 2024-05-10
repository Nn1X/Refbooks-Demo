using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F015XmlMapperConfiguration
    {
        public static XmlMapper<F015> AddF015RefbookConfiguration(this XmlMapper<F015> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(
                    element.Element("KOD_OK")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("OKRNAME")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
