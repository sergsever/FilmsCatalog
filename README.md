## Тестовое задание на вакансию Asp.Net Core разработчик

Предполагается, что задание можно выполнить меньше чем за день. Однако мы не ограничиваем время выполнения задания. В первую очередь будет оцениваться качество кода, а не время выполнения.

#### Суть задания

Нужно доработать приложение в репозитории. В проекте используется паттерн MVC. Уже реализованы методы для регистрации и входа пользователей, настроено подключение к LocalDB, задействован Entity Framework Core. Приложение представляет собой каталог фильмов. 

Необходимо реализовать страницы:

- страницу для просмотра списка всех фильмов (с пагинацией);
- страницу просмотра информации об отдельном фильме;
- страницу добавления в каталог фильма;
- страницу редактирования имеющегося в каталоге фильма.

Для каждого фильма должно храниться название, описание, год выпуска, режиссёр, пользователь, который выложил информацию, постер. Постер - это файл-изображение. Должна быть возможность загрузить постер и посмотреть его на странице детальной информации о фильме. Функциональность по выкладыванию видеофайла фильма не нужна. 
Редактировать фильм имеет право только тот, кто изначально выложил информацию об этом фильме. 
При реализации каталога учитывать, что фильмов в каталоге может быть потенциально сотни тысяч.

#### Технические требования

Ко внешнему виду требования минимальные, но всё должно выглядеть аккуратно и приятно. Можно использовать Bootstrap. Допустимо использовать любые сторонние библиотеки, в том числе nuget-пакеты. Не нужно самим реализовывать функциональность библиотек, если это не оправдано какими-то ограничениями.

#### Зачем этот репозиторий?

Необходимо клонировать текущий репозиторий и доработать приложение. В качестве результата работы необходимо прислать ссылку на Ваш git-репозиторий с проектом на адрес y.lytkina@junior-projects.com. Исходные файлы в архиве присылать не нужно. Fork репозитория делать не нужно. Если не получается запустить проект из репозитория или есть какие-то вопросы по заданию, напишите на y.lytkina@junior-projects.com. 

#### Дополнительные инструкции по запуску проекта из репозитория

Проект реализован на .NET 5. Если у Вас еще не установлен SDK для этой версии .NET, необходимо обновить Visual Studio или вручную установить [SDK](https://dotnet.microsoft.com/download/dotnet/5.0) (нужно установить именно SDK, а не Runtime). 

Перед первым запуском проекта необходимо выполнить команду *update-database* для инициализации LocalDB.

#### Рекомендации

Сложность вашего решения должна быть сопоставима с решаемой задачей. Если вы хотите продемонстрировать знание и умение применить какой-то паттерн/концепт/подход - это очень хорошо. Только убедитесь, что это будет уместно. Задачу необходимо решать так, как вы бы решали её для коммерческих целей.