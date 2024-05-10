using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V019XmlMapperConfiguration
{
    public static XmlMapper<V019> AddV019RefbookConfiguration(this XmlMapper<V019> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDHM")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("HMNAME")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DIAG")?.Value))
            .MapWith((element, model) => model.TypeCode = NullableConvert.ConvertToNullableString(element.Element("HVID")?.Value))
            .MapWith((element, model) => model.GroupNumber = NullableConvert.ConvertToNullableInt32(element.Element("HGR")?.Value))
            .MapWith((element, model) => model.PatientModel = NullableConvert.ConvertToNullableString(element.Element("HMODP")?.Value))
            .MapWith((element, model) => model.PatientModelId = NullableConvert.ConvertToNullableInt32(element.Element("IDMODP")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}