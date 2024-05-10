using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;
using System.Xml.Linq;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F002XmlMapperConfiguration
    {
        public static XmlMapper<F002> AddF002RefbookConfiguration(this XmlMapper<F002> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("smocod")?.Value))
                .MapWith((element, model) => model.Ogrn = NullableConvert.ConvertToNullableString(element.Element("Ogrn")?.Value))
                .MapWith((element, model) => model.Kpp = NullableConvert.ConvertToNullableString(element.Element("KPP")?.Value))
                .MapWith((element, model) => model.FullName = NullableConvert.ConvertToNullableString(element.Element("nam_smop")?.Value))
                .MapWith((element, model) => model.ShortName = NullableConvert.ConvertToNullableString(element.Element("nam_smok")?.Value))

                .MapWith((element, model) => model.Address = element.Element("jurAddress")
                    ?.Element("addr_j")?.Value)

                .MapWith((element, model) => model.DirectorLastName = NullableConvert.ConvertToNullableString(element.Element("fam_ruk")?.Value))
                .MapWith((element, model) => model.DirectorFirstName = NullableConvert.ConvertToNullableString(element.Element("im_ruk")?.Value))
                .MapWith((element, model) => model.DirectorPatronymic = NullableConvert.ConvertToNullableString(element.Element("ot_ruk")?.Value))

                .MapWith((element, model) => model.PhoneNumber = NullableConvert.ConvertToNullableString(element.Element("phone")?.Value))
                .MapWith((element, model) => model.Fax = NullableConvert.ConvertToNullableString(element.Element("fax")?.Value))
                .MapWith((element, model) => model.HotlinePhoneNumber = NullableConvert.ConvertToNullableString(element.Element("hot_line")?.Value))
                .MapWith((element, model) => model.Email = NullableConvert.ConvertToNullableString(element.Element("e_mail")?.Value))

                .MapWith((element, model) => model.LicenseNumber = element.Element("licenziy")
                    ?.Element("n_doc")?.Value)
                .MapWith((element, model) => model.IssueDateLicense = NullableConvert.ConvertToNullableDateTime(
                    element.Element("licenziy")?.Element("d_start")?.Value))
                .MapWith((element, model) => model.EndDateLicense = NullableConvert.ConvertToNullableDateTime(
                    element.Element("licenziy")?.Element("d_end")?.Value))

                .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(
                    element.Element("d_edit")?.Value))
                
                .MapWith((element, model) => model.DateBegin = GetDateBegin(element))
                .MapWith((element, model) => model.DateEnd = GetDateEnd(element));

            return mapper;
        }

        private static DateTime? GetDateBegin(XElement element)
        {
            var insElement = GetInsElement(element);

            return NullableConvert.ConvertToNullableDateTime(insElement.Element("d_begin")?.Value);
        }
        
        private static DateTime? GetDateEnd(XElement element)
        {
            var insElement = GetInsElement(element);

            return NullableConvert.ConvertToNullableDateTime(insElement.Element("d_end")?.Value);
        }

        private static XElement GetInsElement(XElement element)
        {
            var insDates = element.Elements("insInclude")
                .Select(el => 
                    NullableConvert.ConvertToNullableDateTime(el.Element("d_begin")?.Value));

            var nearestDate = GetNearestDate(DateTime.Now, insDates);

            return element.Elements("insInclude").FirstOrDefault(el =>
                NullableConvert.ConvertToNullableDateTime(el.Element("d_begin")?.Value)
                == nearestDate);
        }

        private static DateTime? GetNearestDate(DateTime targetDate, IEnumerable<DateTime?> dates)
        {
            var nearestDate = dates.OrderBy((d =>
                Math.Abs((targetDate - d).GetValueOrDefault().TotalMilliseconds)
                )).FirstOrDefault();
            
            return nearestDate;
        }
    }
}
