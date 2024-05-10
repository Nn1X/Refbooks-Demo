using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V014XmlMapperConfiguration
{
    public static XmlMapper<V014> AddV014RefbookConfiguration(this XmlMapper<V014> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDFRMMP")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("FRMMPNAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}