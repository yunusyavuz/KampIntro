Select * from Customers
select COUNT(*) Adet from Products where CategoryID = 2
-- Hangi kategoride kac farklı urun var
select CategoryID, COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*) <10

select * 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice >10

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID


