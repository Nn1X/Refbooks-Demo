using System.Xml.Linq;
using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class Q023XmlMapperConfiguration
{
    public static XmlMapper<Q023> AddQ023RefbookConfiguration(this XmlMapper<Q023> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("ID_TEST")?.Value))
            .MapWith((element, model) => model.ElementId = NullableConvert.ConvertToNullableString(element.Element("ID_EL")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("DESC_TEST")?.Value))
            
            .MapWith((element, model) => model.RegistryType = string.Join(',',
                GetRules(element)))
            
            
            .MapWith((element, model) => model.NsiCode = NullableConvert.ConvertToNullableString(element.Element("NSI_OBJ")?.Value))
            .MapWith((element, model) => model.NsiElement = NullableConvert.ConvertToNullableString(element.Element("NSI_EL")?.Value))
            .MapWith((element, model) => model.Condition = NullableConvert.ConvertToNullableString(element.Element("USL_TEST")?.Value))
            .MapWith((element, model) => model.ValuesSet = NullableConvert.ConvertToNullableString(element.Element("VAL_EL")?.Value))
            .MapWith((element, model) => model.Comment = NullableConvert.ConvertToNullableString(element.Element("COMMENT")?.Value))
            
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