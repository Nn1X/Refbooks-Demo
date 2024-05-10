using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F001XmlMapperConfiguration
    {
        public static XmlMapper<F001> AddF001RefbookConfiguration(this XmlMapper<F001> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("tf_kod")?.Value))
                .MapWith((element, model) => model.Okato = NullableConvert.ConvertToNullableString(element.Element("tf_okato")?.Value))
                .MapWith((element, model) => model.Ogrn = NullableConvert.ConvertToNullableString(element.Element("tf_ogrn")?.Value))
                .MapWith((element, model) => model.FullName = NullableConvert.ConvertToNullableString(element.Element("name_tfp")?.Value))
                .MapWith((element, model) => model.ShortName = NullableConvert.ConvertToNullableString(element.Element("name_tfk")?.Value))
                .MapWith((element, model) => model.PostalCode = NullableConvert.ConvertToNullableString(element.Element("index")?.Value))
                .MapWith((element, model) => model.Address = NullableConvert.ConvertToNullableString(element.Element("address")?.Value))
                .MapWith((element, model) => model.DirectorLastName = NullableConvert.ConvertToNullableString(element.Element("fam_dir")?.Value))
                .MapWith((element, model) => model.DirectorFirstName = NullableConvert.ConvertToNullableString(element.Element("im_dir")?.Value))
                .MapWith((element, model) => model.DirectorPatronymic = NullableConvert.ConvertToNullableString(element.Element("ot_dir")?.Value))
                .MapWith((element, model) => model.PhoneNumber = NullableConvert.ConvertToNullableString(element.Element("phone")?.Value))
                .MapWith((element, model) => model.Fax = NullableConvert.ConvertToNullableString(element.Element("fax")?.Value))
                .MapWith((element, model) => model.HotlinePhoneNumber = NullableConvert.ConvertToNullableString(element.Element("hot_line")?.Value))
                .MapWith((element, model) => model.Email = NullableConvert.ConvertToNullableString(element.Element("e_mail")?.Value))
                .MapWith((element, model) => model.BranchesNumber = NullableConvert.ConvertToNullableString(element.Element("kf_tf")?.Value))
                .MapWith((element, model) => model.OfficialWebsite = NullableConvert.ConvertToNullableString(element.Element("www")?.Value))

                .MapWith((element, model) => model.Bic = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("bic")?.Value))
                .MapWith((element, model) => model.Inn = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("inn")?.Value))
                .MapWith((element, model) => model.Kpp = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("kpp")?.Value))
                .MapWith((element, model) => model.Oktmo = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("oktmo")?.Value))
                 .MapWith((element, model) => model.Kbk = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("kbk")?.Value))

                .MapWith((element, model) => model.NameMtrSender = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_POL")?.Element("L_NAIM")?.Value))
                .MapWith((element, model) => model.BankNameMtrSender = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_POL")?.Element("L_B")?.Value))
                .MapWith((element, model) => model.RsMtrSender = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_POL")?.Element("L_RS")?.Value))

                .MapWith((element, model) => model.NameMtrRecipient = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_PL")?.Element("T_NAIM")?.Value))
                .MapWith((element, model) => model.BankNameMtrRecipient = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_PL")?.Element("T_B")?.Value))
                .MapWith((element, model) => model.RsMtrRecipient = NullableConvert.ConvertToNullableString(element.Element("MTR")
                    ?.Element("MTR_PL")?.Element("T_RS")?.Value))

                .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(
                    element.Element("d_edit")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("d_end")?.Value));

            return mapper;
        }
    }
}
