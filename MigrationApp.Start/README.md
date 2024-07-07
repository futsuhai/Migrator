**Данное приложение используется для миграции баз данных MS SQL Server на PostgreSQL**

**1. Перед осуществлением переноса**
Нужно создать базы в postgre: AnalyticsService, PerformanceAnalyzer, SearchService.

**2. Для корректного переноса таблицы Configuration_ResultParameterRelation**
Нужно добавить в базу MS SQL в таблицу User недостоющую запись с Id:
00000000-0000-0000-0000-200000000083

**3. Для корректного переноса таблицы Methodology_HardwarePlatformRelation**
Нужно добавить в базу MS SQL в таблицу HardwarePlatform добавить недостающие экземпляры оборудования с Id:
3DC6BB26-34EC-4C3B-B3ED-0AD11B9E8AD0
FB0A67AA-9088-472F-8C86-20B15AE61D54
238F55FE-6309-46AC-B438-36296A00DC46
6740E63D-8F11-4BF6-95F2-5B467B491778
F2098CAB-C59E-441A-9E9E-7067B6F40BF6
E51D38CD-47D7-4C1B-86E1-711945FD17FF
570299E8-DE58-4801-9823-7AFFC2AD03E2
7E8F27E2-31F0-4403-8FDA-A5EBCF54CB0E
BEA51D57-53DD-44F7-BF19-ACBF83F767BB
40B3D60A-ABBB-4C1D-981F-AF0A36D47472
4FA70D64-C9DE-4991-84AD-BED10D1CCA33
57FEDE04-5BD5-4855-9A86-C5BC8469F26E
E0E4EF59-7C8F-413F-B742-DD4B46720427
6BBE8243-D730-4E4F-BC62-E2D3CD11104B
59C3E440-2786-41D2-875C-E49E6495924F

**4. Изменить строки подключения к базам в файле appsettings.json**

**5. Запустить миграцию контекста ef в каждой из библиотеки классов**
MigrationApp.AnalyticsService, MigrationApp.SearchService, MigrationApp.PerformanceAnalyzer

**6. Запустить приложение**


**Тестирование**

**Время выполнения**
1. Миграция AnalyticsService выполнена за 49 минут.
2. Миграция SearchService выполнена за 0.01 минут.
3. Миграция PerformanceAnalyzer выполнена за 323 минут.

**Нагрузка**
1. В простое система потребляла 19.6гб оперативной памяти.
2. Нагрузка на оперативную память на пике работы составила 32.7гб оперативной памяти.
3. Вывод: приложение на пике работы потребляло 13.1гб оперативной памяти.

**Запуск основного проекта на Postgre**
1. Установить nuget ef для работы с postgre.
2. Изменить строки подключения
3. Изменить контекст ef для работы с postgreSQL.
4. Удалить все миграции которые изменяли или добавляли новые таблицы
5. Добавить последние миграции ef из данного проекта
6. Изменить порядок сравнения строк при выполнении запросов, пример:
Было:
   x.Name!.Contains(specification.Name, StringComparison.CurrentCultureIgnoreCase)
Стало:
   x.Name!.ToLower().Contains(specification.Name.ToLower())