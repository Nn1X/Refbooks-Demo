using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F006XmlMapperConfiguration
    {
        public static XmlMapper<F006> AddF006RefbookConfiguration(this XmlMapper<F006> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDVID")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("VIDNAME")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

            return mapper;
        }

    }
}
