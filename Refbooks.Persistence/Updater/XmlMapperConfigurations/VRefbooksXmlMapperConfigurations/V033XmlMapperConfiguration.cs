using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V033XmlMapperConfiguration
{
    public static XmlMapper<V033> AddV033RefbookConfiguration(this XmlMapper<V033> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("ScheDrugGroupGrCd")?.Value))
            .MapWith((element, model) => model.MedecationCode = NullableConvert.ConvertToNullableString(element.Element("DrugCode")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}