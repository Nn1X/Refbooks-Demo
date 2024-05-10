using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N011XmlMapperConfiguration
{
    public static XmlMapper<N011> AddN011RefbookConfiguration(this XmlMapper<N011> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_R_I")?.Value))
            .MapWith((element, model) => model.N010Code = NullableConvert.ConvertToNullableString(element.Element("ID_Igh")?.Value))
            .MapWith((element, model) => model.Result = NullableConvert.ConvertToNullableString(element.Element("KOD_R_I")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("R_I_NAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}