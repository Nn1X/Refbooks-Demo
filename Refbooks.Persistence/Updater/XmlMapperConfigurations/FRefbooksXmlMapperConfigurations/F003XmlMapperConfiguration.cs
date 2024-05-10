using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F003XmlMapperConfiguration
    {
        public static XmlMapper<F003> AddF003RefbookConfiguration(this XmlMapper<F003> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("mcod")?.Value))
                .MapWith((element, model) => model.Okato = NullableConvert.ConvertToNullableString(element.Element("tf_okato")?.Value))
                .MapWith((element, model) => model.FullName = NullableConvert.ConvertToNullableString(element.Element("nam_mop")?.Value))
                .MapWith((element, model) => model.ShortName = NullableConvert.ConvertToNullableString(element.Element("nam_mok")?.Value))
                .MapWith((element, model) => model.Inn = NullableConvert.ConvertToNullableString(element.Element("inn")?.Value))
                .MapWith((element, model) => model.Ogrn = NullableConvert.ConvertToNullableString(element.Element("Ogrn")?.Value))
                .MapWith((element, model) => model.Kpp = NullableConvert.ConvertToNullableString(element.Element("KPP")?.Value))

                .MapWith((element, model) => model.PostalCode = NullableConvert.ConvertToNullableString(element.Element("index_j")?.Value))
                .MapWith((element, model) => model.Address = NullableConvert.ConvertToNullableString(element.Element("address_j")?.Value))

                .MapWith((element, model) => model.OkopfCode = NullableConvert.ConvertToNullableString(element.Element("okopf")?.Value))
                .MapWith((element, model) => model.DepartmentalAffiliationCode = element
                    .Element("vedpri")?.Value)
                .MapWith((element, model) => model.SubordinationSign = NullableConvert.ConvertToNullableString(element.Element("org")?.Value))

                .MapWith((element, model) => model.DirectorLastName = NullableConvert.ConvertToNullableString(element.Element("fam_ruk")?.Value))
                .MapWith((element, model) => model.DirectorFirstName = NullableConvert.ConvertToNullableString(element.Element("im_ruk")?.Value))
                .MapWith((element, model) => model.DirectorPatronymic = NullableConvert.ConvertToNullableString(element.Element("ot_ruk")?.Value))

                .MapWith((element, model) => model.FirstPhoneNumber = NullableConvert.ConvertToNullableString(element.Element("phone1")?.Value))
                .MapWith((element, model) => model.SecondPhoneNumber = NullableConvert.ConvertToNullableString(element.Element("phone2")?.Value))

                .MapWith((element, model) => model.FirstFax = NullableConvert.ConvertToNullableString(element.Element("fax1")?.Value))
                .MapWith((element, model) => model.SecondFax = NullableConvert.ConvertToNullableString(element.Element("fax2")?.Value))

                .MapWith((element, model) => model.FirstEmail = NullableConvert.ConvertToNullableString(element.Element("e_mail1")?.Value))
                .MapWith((element, model) => model.SecondEmail = NullableConvert.ConvertToNullableString(element.Element("e_mail2")?.Value))

                .MapWith((element, model) => model.OfficialWebsite = NullableConvert.ConvertToNullableString(element.Element("www")?.Value))

                .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(
                    element.Element("d_edit")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("medInclude")?.Element("d_begin")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("medInclude")?.Element("d_end")?.Value));

            return mapper;
        }

    }
}
