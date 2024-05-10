using System.Xml.Linq;
using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class Q015XmlMapperConfiguration
{
    public static XmlMapper<Q015> AddQ015RefbookConfiguration(this XmlMapper<Q015> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("ID_TEST")?.Value))
            .MapWith((element, model) => model.ElementId = NullableConvert.ConvertToNullableString(element.Element("ID_EL")?.Value))
            
            .MapWith((element, model) => model.RegistryType = string.Join(',',
                GetRules(element)))
            
            .MapWith((element, model) => model.NsiCode = NullableConvert.ConvertToNullableString(element.Element("NSI_OBJ")?.Value))
            .MapWith((element, model) => model.NsiElement = NullableConvert.ConvertToNullableString(element.Element("NSI_EL")?.Value))
            .MapWith((element, model) => model.Condition = NullableConvert.ConvertToNullableString(element.Element("USL_TEST")?.Value))
            .MapWith((element, model) => model.ValuesSet = NullableConvert.ConvertToNullableString(element.Element("VAL_EL")?.Value))
            .MapWith((element, model) => model.MaxLength = NullableConvert.ConvertToNullableInt32(element.Element("MAX_LEN")?.Value))
            .MapWith((element, model) => model.MinLength = NullableConvert.ConvertToNullableInt32(element.Element("MIN_LEN")?.Value))
            .MapWith((element, model) => model.Mask = NullableConvert.ConvertToNullableString(element.Element("MASK_VAL")?.Value))
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