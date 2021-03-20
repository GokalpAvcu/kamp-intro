--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
Select * from Products where categoryId=1 or categoryId=3

Select * from Products where categoryId=1 and UnitPrice>=10

Select * from Products where categoryId=1 order by UnitPrice asc  --ascending  --descending

Select count(*) Adet from Products

select categoryID, count(*) from products where UnitPrice>20
group by categoryID having count(*)<10



select  Products.ProductID, Products.ProductName,
Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10



--DTO Data Transformation object


Select * from Products p left join
[Order Details] od on p.ProductID = od.ProductID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID

