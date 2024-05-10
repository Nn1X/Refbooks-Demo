﻿using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V023XmlMapperConfiguration
{
    public static XmlMapper<V023> AddV023RefbookConfiguration(this XmlMapper<V023> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDUMP")?.Value))
            .MapWith((element, model) => model.Number = element.Element("K_KSG")?.Value)
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("N_KSG")?.Value))
            .MapWith((element, model) => model.Coefficient = NullableConvert.ConvertToNullableString(element.Element("KOEF_Z")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}