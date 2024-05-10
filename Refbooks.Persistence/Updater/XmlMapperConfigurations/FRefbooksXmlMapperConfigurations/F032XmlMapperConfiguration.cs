using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F032XmlMapperConfiguration
    {
        public static XmlMapper<F032> AddF032RefbookConfiguration(this XmlMapper<F032> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("MCOD")?.Value))
                .MapWith((element, model) => model.Uid = NullableConvert.ConvertToNullableString(element.Element("UIDMO")?.Value))
                .MapWith((element, model) => model.RegistrationNumber = NullableConvert.ConvertToNullableString(element.Element("IDMO")?.Value))
                .MapWith((element, model) => model.Oktmo = NullableConvert.ConvertToNullableString(element.Element("OKTMO_P")?.Value))
                .MapWith((element, model) => model.SubjectName = NullableConvert.ConvertToNullableString(element.Element("SUBJ")?.Value))

                .MapWith((element, model) => model.InclussionDate = NullableConvert.ConvertToNullableDateTime(
                    element.Element("D_BEGIN")?.Value))
                .MapWith((element, model) => model.ExclussionDate = NullableConvert.ConvertToNullableDateTime(
                    element.Element("D_END")?.Value))
                .MapWith((element, model) => model.ExclussionReasonCode = NullableConvert.ConvertToNullableInt32(
                    element.Element("NAME_E")?.Value))

                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
