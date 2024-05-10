using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class Q018XmlMapperConfiguration
{
    public static XmlMapper<Q018> AddQ018RefbookConfiguration(this XmlMapper<Q018> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("IDZAP")?.Value))
            .MapWith((element, model) => model.ElementId = NullableConvert.ConvertToNullableString(element.Element("ID_EL")?.Value))
            .MapWith((element, model) => model.RegistryType = NullableConvert.ConvertToNullableString(element.Element("TYPE_D")?.Value))
            .MapWith((element, model) => model.ElementType = NullableConvert.ConvertToNullableString(element.Element("TYPE_E")?.Value))
            .MapWith((element, model) => model.ElementFormat = NullableConvert.ConvertToNullableString(element.Element("FORM_E")?.Value))
            .MapWith((element, model) => model.MaxLength = NullableConvert.ConvertToNullableString(element.Element("MXLEN_X")?.Value))
            .MapWith((element, model) => model.ElementName = NullableConvert.ConvertToNullableString(element.Element("NAME_E")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("DESC_E")?.Value))
            
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEEND")?.Value));

        return mapper;
    }
}