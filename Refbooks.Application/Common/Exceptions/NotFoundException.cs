namespace Refbooks.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"Справочник: {name} по ключу: {key} не найден.")
        { }
        
        public NotFoundException(string name, object key, DateTime date)
            : base($"Справочник: {name} по ключу: {key} не найден на дату: {date:dd.MM.yyyy}")
        { }
        
        public NotFoundException(string name)
            : base($"Данные в справочнике {name} отсутствуют.")
        { }
    }
}
