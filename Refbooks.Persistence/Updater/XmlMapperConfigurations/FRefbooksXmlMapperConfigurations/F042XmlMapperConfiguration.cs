using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F042XmlMapperConfiguration
    {
        public static XmlMapper<F042> AddF042RefbookConfiguration(this XmlMapper<F042> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("N_EXPERT")?.Value))
                .MapWith((element, model) => model.Uid = NullableConvert.ConvertToNullableString(element.Element("UIDEKMP")?.Value))
                .MapWith((element, model) => model.RegistrationNumber = NullableConvert.ConvertToNullableString(element.Element("IDEKMP")?.Value))
                .MapWith((element, model) => model.Oktmo = NullableConvert.ConvertToNullableString(element.Element("OKTMO_P")?.Value))
                .MapWith((element, model) => model.SubjectName = NullableConvert.ConvertToNullableString(element.Element("SUBJ")?.Value))

                .MapWith((element, model) => model.InclussionDate = NullableConvert.ConvertToNullableDateTime(
                    element.Element("D_BEGIN")?.Value))
                .MapWith((element, model) => model.ExclussionDate = NullableConvert.ConvertToNullableDateTime(
                    element.Element("D_END")?.Value))
                .MapWith((element, model) => model.ExclussionReasonCode = NullableConvert.ConvertToNullableInt32(
                    element.Element("NAME_E")?.Value))

                .MapWith((element, model) => model.MoEkmpNumber = NullableConvert.ConvertToNullableInt32(
                    element.Element("KMO")?.Value))
                .MapWith((element, model) => model.CasesEkmpNumber = NullableConvert.ConvertToNullableInt32(
                    element.Element("ZSL")?.Value))
                .MapWith((element, model) => model.ConductedEkmpNumber = NullableConvert.ConvertToNullableInt32(
                    element.Element("EKS")?.Value))
                .MapWith((element, model) => model.UnreasonableEkmpNumber = NullableConvert.ConvertToNullableInt32(
                    element.Element("ZAK")?.Value))

                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
