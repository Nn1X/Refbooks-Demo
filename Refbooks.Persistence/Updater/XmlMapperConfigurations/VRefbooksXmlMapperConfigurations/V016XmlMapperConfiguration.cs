using System.Xml.Linq;
using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V016XmlMapperConfiguration
{
    public static XmlMapper<V016> AddV016RefbookConfiguration(this XmlMapper<V016> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("IDDT")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("DTNAME")?.Value))
            
            .MapWith((element, model) => model.ValuesSet = string.Join(',',
                GetRules(element)))
            
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEEND")?.Value));

        return mapper;
    }

    private static IEnumerable<string> GetRules(XElement element)
    {
        var rules = element.Element("TYPE_MD")
            ?.Elements().Select(elem => elem?.Value);

        if (rules is null || !rules.Any())
        {
            return null;
        }
        
        return rules;
    }
}