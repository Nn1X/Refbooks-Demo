namespace Refbooks.Application.Common
{
    public static class NullableConvert
    {
        public static int? ConvertToNullableInt32(string? text)
        {
            if (!int.TryParse(text, out var value))
                return null;

            return value;
        }
        public static DateOnly? ConvertToNullableDateOnly(string? text)
        {
            if (!DateOnly.TryParse(text, out var value))
                return null;

            return value;
        }
        public static DateTime? ConvertToNullableDateTime(string? text)
        {
            if (!DateTime.TryParse(text, out var value))
                return null;

            return value;
        }
        public static decimal? ConvertToNullableDecimal(string? text)
        {
            text = text.Replace('.', ',');
            if (!Decimal.TryParse(text, out var value))
                return null;

            return value;
        }
        public static string? ConvertToNullableString(string? text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            return text;
        }
    }
}
