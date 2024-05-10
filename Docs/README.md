
<h1>Refbooks</h1>
<h3>Описание проекта:</h3>

> * API для получение и обновления из XML справочной информации для фронта на React
> * Можно обратить внимание на эндпоинт обновления справочников api/refbooks/update (кастомный маппер - Refbooks.Persistence.Updater)
> * Кастомный model builder для EF - Refbooks.Persistence.EntityTypeConfigurationExtensions
> * RefbooksDbMigrationHostedService - Refbooks.Persistence
> * CacheProfiles от AspNetCore (Program.cs - line: 16)
> * Refbooks.WebAPI.Middleware - FactoryCustomExceptionHandlerMiddleware - для обратоки исключений со сбросом кэша при ошибках
> * Используются: EFCore, Migrations, EFCore NamingConventions, MediatR, CQRS, Swagger
<h3>Структура проекта:</h3>

> ## \Domain - ![#fff2cc](https://placehold.it/15/fff2cc/000000?text=) Core 
> * Модели базы данных
>

> ## \Application - ![#fff2cc](https://placehold.it/15/fff2cc/000000?text=) Core 
> * Интерфейсы
> * CQRS-файлы: команды, запросы и их обработчики
> * Исключения
>

> ## \Persistence - ![#5cd65c](https://placehold.it/15/5cd65c/000000?text=) Infrastructure 
> * Контекст базы данных
> * Миграции
> * Конфигурации контекста
> * Обновлятор справочников
> * Конфигурации обновления справочников

> ## \WebApi - ![#66ccff](https://placehold.it/15/66ccff/000000?text=) Presentation 
> * ASP .Net WebAPI приложение
>

<h3>Схема:</h3>

![Структура проекта](folders_scheme.jpg)

