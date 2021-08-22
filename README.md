# Micro-Service отвечающий за карту и интерактивные элементы на ней

Реализованные возможности:
* Создание точек карты с выбором типа (музей, достопримечательность, кафе и т.д.)
* Получение точек с фильтрацией
* Создание маршрутов (выбор точек в определённой последовательности)
* Получение маршрутов, фильтрация
* Работа с файлами (фотографии, файлы для аудиогида и историй)
* Проверка для аудиогида на объекты рядом с пользователем

-------

Используемые технологии:
- .NET 5
- ASP.NET
- AutoMapper
- AutoFac
- Postgresql
- Nginx

-------

Развёртывание:

Docker не настраивал. Не хватило времени. Данные парсил с помощью самописного скрипта и костылей.

Компилить и запустить. Парсер (в котором вбиты данные как json) так же имеются в приложенных репозиториях. Указать нужно внутри только ссылку на роут для заполнения карты и запустить.
