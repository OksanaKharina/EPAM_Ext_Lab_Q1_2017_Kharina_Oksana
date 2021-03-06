/* Скрипт для команды SelectTopNRows из среды SSMS  */
SELECT TOP 10 [OrderID]
      ,[CustomerID]
      ,[EmployeeID]
      ,[OrderDate]
      ,[RequiredDate]
      ,[ShippedDate]
      ,[ShipVia]
      ,[Freight]
      ,[ShipName]
      ,[ShipAddress]
      ,[ShipCity]
      ,[ShipRegion]
      ,[ShipPostalCode]
      ,[ShipCountry]
  FROM [Northwind].[dbo].[Orders]
  /* №1.1 Выбрать в таблице Orders заказы, которые были доставлены после 6 мая 1998 года 
  (колонка ShippedDate) включительно и которые доставлены с ShipVia >= 2. 
  Формат указания даты должен быть верным при любых региональных настройках, 
  согласно требованиям статьи “Writing International Transact-SQL Statements” 
  в Books Online раздел “Accessing and Changing Relational Data Overview”. 
  Этот метод использовать далее для всех заданий. Запрос должен высвечивать 
  только колонки OrderID, ShippedDate и ShipVia.  
  Пояснить почему сюда не попали заказы с NULL-ом в колонке ShippedDate. */

  SELECT [OrderID]
      ,[ShippedDate]
      ,[ShipVia]
  FROM [Northwind].[dbo].[Orders]
  WHERE [ShippedDate] >= convert (DateTime,'1998.05.06',120) AND ShipVia >= 2 

  /* №1.2 Написать запрос, который выводит только недоставленные заказы из таблицы Orders. 
  В результатах запроса высвечивать для колонки ShippedDate вместо значений NULL 
  строку ‘Not Shipped’ – использовать системную функцию CASЕ. 
  Запрос должен высвечивать только колонки OrderID и ShippedDate. */

  SELECT [OrderID],
  CASE  
	  WHEN [ShippedDate] IS NULL THEN 'Not Shipped'
  END [ShippedDate]
  FROM [Northwind].[dbo].[Orders]
  WHERE [ShippedDate] IS NULL

  /* №1.3 Выбрать в таблице Orders заказы, которые были доставлены после 6 мая 1998 года (ShippedDate) 
  не включая эту дату или которые еще не доставлены. 
  В запросе должны высвечиваться только колонки OrderID (переименовать в Order Number) 
  и ShippedDate (переименовать в Shipped Date). 
  В результатах запроса высвечивать для колонки ShippedDate вместо значений NULL 
  строку ‘Not Shipped’, для остальных значений высвечивать дату в формате по умолчанию*/

  SELECT [OrderID] AS 'Order Number',
  CASE 
		WHEN [ShippedDate] IS NULL THEN 'Not Shipped'
		ELSE CONVERT (char,[ShippedDate])
  END AS 'Shipped Date'
  FROM [Northwind].[dbo].[Orders]
  WHERE ([ShippedDate] >= convert (DateTime,'1998.05.06',120)) OR ([ShippedDate] IS NULL)

  /* №2.1 Выбрать из таблицы Customers всех заказчиков, проживающих в USA и Canada. 
  Запрос сделать с только помощью оператора IN. Высвечивать колонки с именем пользователя 
  и названием страны в результатах запроса. 
  Упорядочить результаты запроса по имени заказчиков и по месту проживания.*/

  SELECT [ContactName]
		,[Country]
  FROM [Northwind].[dbo].[Customers]
  WHERE [Country] IN ('USA','Canada') ORDER BY [ContactName], [Address]

  /* №2.2 Выбрать из таблицы Customers всех заказчиков, не проживающих в USA и Canada. 
  Запрос сделать с помощью оператора IN. Высвечивать колонки с именем пользователя 
  и названием страны в результатах запроса. Упорядочить результаты запроса по имени заказчиков. */

  SELECT [ContactName]
		,[Country]
  FROM [Northwind].[dbo].[Customers]
  WHERE [Country] NOT IN ('USA','Canada') ORDER BY [ContactName]

  /* №2.3 Выбрать из таблицы Customers все страны, в которых проживают заказчики. 
  Страна должна быть упомянута только один раз и список отсортирован 
  по убыванию. Не использовать предложение GROUP BY. 
  Высвечивать только одну колонку в результатах запроса*/

  SELECT DISTINCT [Country]
  FROM [Northwind].[dbo].[Customers]
  ORDER BY [Country] DESC

  /* №3.1 Выбрать все заказы (OrderID) из таблицы Order Details 
  (заказы не должны повторяться), где встречаются продукты с количеством 
  от 3 до 10 включительно – это колонка Quantity в таблице Order Details. 
  Использовать оператор BETWEEN. Запрос должен высвечивать только колонку OrderID. */

  SELECT DISTINCT [OrderID]
  FROM [Northwind].[dbo].[Order Details]
  WHERE [Quantity] between 3 AND 10

  /* №3.2 Выбрать всех заказчиков из таблицы Customers, у которых название страны 
  начинается на буквы из диапазона b и g. Использовать оператор BETWEEN. 
  Проверить, что в результаты запроса попадает Germany. 
  Запрос должен высвечивать только колонки CustomerID и Country и отсортирован по Country.*/

  SELECT [CustomerID]
		,[Country]
  FROM [Northwind].[dbo].[Customers]
  WHERE [Country] between 'b' AND 'g' ORDER BY [Country]

  /* №3.3 Выбрать всех заказчиков из таблицы Customers, у которых название страны 
  начинается на буквы из диапазона b и g, не используя оператор BETWEEN. 
  С помощью опции “Execution Plan” определить какой запрос предпочтительнее 
  3.2 или 3.3 – для этого надо ввести в скрипт выполнение текстового 
  Execution Plan-a для двух этих запросов, результаты выполнения Execution Plan
   надо ввести в скрипт в виде комментария и по их результатам дать ответ 
   на вопрос – по какому параметру было проведено сравнение. 
   Запрос должен высвечивать только колонки CustomerID и Country и отсортирован по Country. */

  SELECT [CustomerID]
		,[Country]
  FROM [Northwind].[dbo].[Customers]
  WHERE [Country] > 'b' AND [Country] < 'g' ORDER BY [Country]

  /* №4.1 В таблице Products найти все продукты (колонка ProductName), 
  где встречается подстрока 'chocolade'. Известно, что в подстроке 
  'chocolade' может быть изменена одна буква 'c' в середине - 
  найти все продукты, которые удовлетворяют этому условию. 
  Подсказка: результаты запроса должны высвечивать 2 строки. */

  SELECT [ProductName]
  FROM [Northwind].[dbo].[Products]
  WHERE [ProductName] LIKE '%cho_olade%'

  /* №5.1 Найти общую сумму всех заказов из таблицы Order Details с учетом количества
  закупленных товаров и скидок по ним. Результат округлить до сотых и высветить
   в стиле 1 для типа данных money.  Скидка (колонка Discount) составляет 
   процент из стоимости для данного товара. Для определения действительной 
   цены на проданный продукт надо вычесть скидку из указанной в колонке 
   UnitPrice цены. Результатом запроса должна быть одна запись с одной 
   колонкой с названием колонки 'Totals'.*/

  SELECT ROUND (SUM(([UnitPrice] - [UnitPrice]*[Discount])*[Quantity]), 2) AS [Total]
  FROM [Northwind].[dbo].[Order Details]

  /* №5.2 По таблице Orders найти количество заказов, которые еще не были доставлены 
  (т.е. в колонке ShippedDate нет значения даты доставки). Использовать при этом
   запросе только оператор COUNT. Не использовать предложения WHERE и GROUP. */

  SELECT COUNT(*) - COUNT([ShippedDate]) AS 'Количество недоставленных заказов'
  FROM [Northwind].[dbo].[Orders]

  /* №5.3 По таблице Orders найти количество различных покупателей (CustomerID), 
  сделавших заказы. Использовать функцию COUNT и не использовать предложения
   WHERE и GROUP*/

  SELECT COUNT(DISTINCT [CustomerID]) AS 'Количество различных покпателей'
  FROM [Northwind].[dbo].[Orders]

  /* №6.1 По таблице Orders найти количество заказов с группировкой по годам. 
  В результатах запроса надо высвечивать две колонки c названиями Year и Total.
   Написать проверочный запрос, который вычисляет количество всех заказов*/

  SELECT COUNT([OrderID]) AS 'TOTAL', YEAR([OrderDate]) AS 'YEAR'
  FROM [Northwind].[dbo].[Orders] GROUP BY (YEAR(OrderDate))

  SELECT COUNT([OrderID])
  FROM [Northwind].[dbo].[Orders]

  /* №6.2 По таблице Orders найти количество заказов, cделанных каждым продавцом. 
  Заказ для указанного продавца – это любая запись в таблице Orders, 
  где в колонке EmployeeID задано значение для данного продавца. 
  В результатах запроса надо высвечивать колонку с именем продавца 
  (Должно высвечиваться имя полученное конкатенацией LastName & FirstName. 
  Эта строка LastName & FirstName должна быть получена отдельным запросом 
  в колонке основного запроса. Также основной запрос должен использовать 
  группировку по EmployeeID.) с названием колонки ‘Seller’ и колонку 
  c количеством заказов высвечивать с названием 'Amount'. 
  Результаты запроса должны быть упорядочены по убыванию количества заказов. */

  SELECT [FirstName] + ' ' + [LastName] AS [Seller],
	 COUNT([OrderID]) AS [Amount]
  FROM [Northwind].[dbo].[Orders] INNER JOIN [Northwind].[dbo].[Employees] ON [Employees].[EmployeeID] = [Orders].[EmployeeID]
								  GROUP BY [FirstName] + ' ' + [LastName]
								  ORDER BY [Amount] DESC

/* №6.3 По таблице Orders найти количество заказов, cделанных каждым продавцом и 
для каждого покупателя. Необходимо определить это только для заказов сделанных 
в 1998 году. В результатах запроса надо высвечивать колонку с именем продавца 
(название колонки ‘Seller’), колонку с именем покупателя (название колонки 
‘Customer’)  и колонку c количеством заказов высвечивать с названием 'Amount'. 
В запросе необходимо использовать специальный оператор языка T-SQL для работы 
с выражением GROUP (Этот же оператор поможет выводить строку “ALL” в результатах
 запроса). Группировки должны быть сделаны по ID продавца и покупателя. 
 Результаты запроса должны быть упорядочены по продавцу, покупателю и по 
 убыванию количества продаж. В результатах должна быть сводная информация 
 по продажам. Т.е. в резульирующем наборе должны присутствовать дополнительно 
 к информации о продажах продавца для каждого покупателя следующие строчки:*/

 SELECT /* не разобралась как можно было бы обойти двойной CASE*/
	CASE
		WHEN [CompanyName] IS NULL THEN 'ALL'
		ELSE [CompanyName] END AS [Seller],
	CASE 
		WHEN [FirstName] IS NULL THEN 'ALL'
		ELSE [FirstName] END AS Customer, 
	COUNT([OrderID]) AS [Amount]
 FROM [Northwind].[dbo].[Orders] INNER JOIN [Northwind].[dbo].[Customers] ON [Orders].[CustomerID] = [Customers].[CustomerID]
								 INNER JOIN [Northwind].[dbo].[Employees] ON [Orders].[EmployeeID] = [Employees].[EmployeeID]
 WHERE [OrderDate] >= convert (DateTime,'1998.01.01',120)  AND [OrderDate] < convert (DateTime,'1999.05.06',120)
		GROUP BY CUBE ([CompanyName], [FirstName])
		ORDER BY [Seller]
				, [Customer]
				, [Amount]
				DESC

/* №6.4 Найти покупателей и продавцов, которые живут в одном городе. 
Если в городе живут только один или несколько продавцов или только один или 
несколько покупателей, то информация о таких покупателя и продавцах не должна 
попадать в результирующий набор. Не использовать конструкцию JOIN. 
В результатах запроса необходимо вывести следующие заголовки для результатов 
запроса: ‘Person’, ‘Type’ (здесь надо выводить строку ‘Customer’ или  ‘Seller’
 в завимости от типа записи), ‘City’. Отсортировать результаты запроса по 
 колонке ‘City’ и по ‘Person’. */

  SELECT 
   CASE 
		WHEN NOT [Employees].[FirstName] IS NULL AND NOT [Customers].[ContactName] IS NULL 
			THEN [Employees].[FirstName] + ' ' + [Employees].[LastName] + ' AND ' + [Customers].[ContactName]
  END AS [Person], [Employees].[City] 
		AS [City]
  FROM [Northwind].[dbo].[Employees], [Northwind].[dbo].[Customers]
  WHERE [Employees].[City] = [Customers].[City] ORDER BY [City], [Person]

  /* №6.5 Найти всех покупателей, которые живут в одном городе. В запросе 
  использовать соединение таблицы Customers c собой - самосоединение. 
  Высветить колонки CustomerID и City. Запрос не должен высвечивать 
  дублируемые записи. Для проверки написать запрос, который высвечивает 
  города, которые встречаются более одного раза в таблице Customers. 
  Это позволит проверить правильность запроса. */

  SELECT [cust1].[CustomerID]
		, [cust1].[City]
  FROM [Northwind].[dbo].[Customers] cust1 JOIN [Northwind].[dbo].[Customers] cust2 
											ON [cust1].[City] = [cust2].[City]
	GROUP BY [cust1].[CustomerID]
			, [cust1].[City]
	HAVING COUNT([cust1].[City]) > 1
	ORDER BY [cust1].[City]

SELECT [City], COUNT([City]) AS [Count] 
FROM [Northwind].[dbo].[Customers] 
GROUP BY [City] having COUNT([City]) > 1

/* №6.6 По таблице Employees найти для каждого продавца его руководителя, 
т.е. кому он делает репорты. Высветить колонки с именами 'User Name' 
(LastName) и 'Boss'. В колонках должны быть высвечены имена из колонки 
LastName. Высвечены ли все продавцы в этом запросе? */

SELECT two.[LastName] AS [UserName],
		one.[LastName] AS Boss
FROM [Northwind].[dbo].[Employees] one RIGHT JOIN [Northwind].[dbo].[Employees] two 
										ON one.[EmployeeID] = two.[ReportsTo]
ORDER BY Boss

/* №7.1 Определить продавцов, которые обслуживают регион 'Western' (таблица Region). 
Результаты запроса должны высвечивать два поля: 'LastName' продавца и 
название обслуживаемой территории ('TerritoryDescription' из таблицы 
Territories). Запрос должен использовать JOIN в предложении FROM. 
Для определения связей между таблицами Employees и Territories надо 
использовать графические диаграммы для базы Northwind. */

SELECT [FirstName]
	,[TerritoryDescription]
FROM [Northwind].[dbo].[Employees] INNER JOIN [Northwind].[dbo].[EmployeeTerritories] 
									ON [Employees].[EmployeeID] = [EmployeeTerritories].[EmployeeID]
									INNER JOIN [Northwind].[dbo].[Territories] 
									ON [EmployeeTerritories].[TerritoryID] = [Territories].[TerritoryID]
									INNER JOIN [Northwind].[dbo].[Region] 
									ON [Territories].[RegionID] = [Region].[RegionID]
WHERE [RegionDescription] = 'Western'

/* №8.1 Высветить в результатах запроса имена всех заказчиков из таблицы 
Customers и суммарное количество их заказов из таблицы Orders. 
Принять во внимание, что у некоторых заказчиков нет заказов, но они также 
должны быть выведены в результатах запроса. Упорядочить результаты запроса 
по возрастанию количества заказов. */

SELECT one.[CustomerID], COUNT(two.[OrderID]) AS [Orders] 
FROM [Northwind].[dbo].[Customers] one LEFT JOIN [Northwind].[dbo].[Orders] two 
										ON one.[CustomerID] = two.[CustomerID]
GROUP BY one.[CustomerID]
ORDER BY [Orders]

/* №9.1 Высветить всех поставщиков колонка CompanyName в таблице Suppliers, 
у которых нет хотя бы одного продукта на складе (UnitsInStock в таблице 
Products равно 0). Использовать вложенный SELECT для этого запроса с 
использованием оператора IN. Можно ли использовать вместо оператора IN 
оператор '=' ? */

SELECT 
CompanyName 
FROM [Northwind].[dbo].[Suppliers] INNER JOIN [Northwind].[dbo].[Products] 
									ON [Products].[SupplierID] = [Suppliers].[SupplierID]
WHERE [Products].[SupplierID] IN (
									SELECT [Suppliers].[SupplierID] 
									FROM  [Northwind].[dbo].[Suppliers]
									WHERE [UnitsInStock] 
									IN (0) 
								)

/* №10.1 Высветить всех продавцов, которые имеют более 150 заказов. 
Использовать вложенный коррелированный SELECT.*/

SELECT [Employees].[LastName] 
FROM [Northwind].[dbo].[Employees]
WHERE [EmployeeID] 
			IN (
				SELECT [EmployeeID] 
				FROM [Northwind].[dbo].[Orders] 
				GROUP BY [EmployeeID] 
				HAVING COUNT([OrderID]) > 150
			)

/* №11.1 Высветить всех заказчиков (таблица Customers), которые не имеют ни одного
 заказа (подзапрос по таблице Orders). Использовать коррелированный SELECT 
 и оператор EXISTS*/

SELECT com.[CompanyName]
FROM [Northwind].[dbo].[Customers] com
WHERE NOT EXISTS (
					SELECT [CustomerID] 
					FROM [Northwind].[dbo].[Orders] dom 
					WHERE com.[CustomerID] = dom.[CustomerID]
				)

/* №12.1 Для формирования алфавитного указателя Employees высветить из таблицы 
Employees список только тех букв алфавита, с которых начинаются фамилии 
Employees (колонка LastName ) из этой таблицы. 
Алфавитный список должен быть отсортирован по возрастанию.*/

SELECT DISTINCT SUBSTRING([LastName],1,1) 
AS letter 
FROM [Northwind].[dbo].[Employees]
ORDER BY letter

/* !Залью сегодня, исправлю код 
№13.1 Написать процедуру, которая возвращает самый крупный заказ для каждого 
из продавцов за определенный год. В результатах не может быть несколько 
заказов одного продавца, должен быть только один и самый крупный. 
В результатах запроса должны быть выведены следующие колонки: колонка с 
именем и фамилией продавца (FirstName и LastName – пример: Nancy Davolio), 
номер заказа и его стоимость. В запросе надо учитывать Discount при продаже 
товаров. Процедуре передается год, за который надо сделать отчет, и 
количество возвращаемых записей. Результаты запроса должны быть упорядочены 
по убыванию суммы заказа. Процедура должна быть реализована с использованием
 оператора SELECT и БЕЗ ИСПОЛЬЗОВАНИЯ КУРСОРОВ. Название функции соответственно 
 GreatestOrders. Необходимо продемонстрировать использование этих процедур. 
Также помимо демонстрации вызовов процедур в скрипте Query.sql надо написать
 отдельный ДОПОЛНИТЕЛЬНЫЙ проверочный запрос для тестирования правильности работы процедуры GreatestOrders. 
 Проверочный запрос должен выводить в удобном для сравнения с результатами
 работы процедур виде для определенного продавца для всех его заказов за 
 определенный указанный год в результатах следующие колонки: имя продавца,
 номер заказа, сумму заказа. Проверочный запрос не должен повторять 
 запрос, написанный в процедуре, - он должен выполнять только то, что
описано в требованиях по нему. ВСЕ ЗАПРОСЫ ПО ВЫЗОВУ ПРОЦЕДУР ДОЛЖНЫ 
 БЫТЬ НАПИСАНЫ В ФАЙЛЕ Query.sql – см. пояснение ниже в разделе 
«Требования к оформлению». */