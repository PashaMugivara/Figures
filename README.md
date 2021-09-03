Если предположить, что таблица Products имеет поля 
  Guid Id, 
  string Name, 
  Guid CategoryId, 
а таблица Category имеет поля
  Guid Id, 
  string Name,
то запрос вывода всех продуктов с именами категорий вместо айдишников будет слудующий:
  SELECT Products.Name, State.Name from Products
  JOIN State ON Products.CategoryId = State.Id
