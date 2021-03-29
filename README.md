# WebApiSample


DataBase (CodeAssessment):
===========
-> Db consists of three tables namely Customer, Order, Item
-> Order contains two foreign keys (customerid of customer table's pk, ItemId of Item table's pk).
-> Customer table columns are Id pk, Name, Address, City, Country, Email, PhoneNumber, IsCreatedOn,IsModifiedOn,IsActive.
-> Product table columns are Id, Name, Amount, IsActive
-> Order table columns are Id,customerid, ItemId,IsActive,IsCreatedOn,IsModifiedon.



WebApi:
=======

-> We used database First Approach we first create DB and from Package manager console we use a command for that we need to install two nuget packages namely
   1) Microsoft.EntityFrameworkCore.SqlServer.
   2)Microsoft.EntityFrameWorkCore.tools.
   the following command for DB
     " scaffold-DBContext "connectionString here" Microsoft.EntityFrameWorkCore.SqlServer Output-Dir Models"
-> We used three tier architecture but we don't have user interface here instead we named controllers -> Services -> Repository.
-> the patterns follows -> first it calls controller and action method -> services (where logic is implemented) -> Repository (which is used to interact with database).

Models:
======
-> Models are generated from DB approach it contains DbContext which is used to perform CRUD with Database.
-> we have Order, Customer, Item which are Db approach.
-> Custom Models are Pagination, OrderList, OrderPagination
-> pagination contains 
    -> Currentpage which is used to set and get current page index.
    -> count which is used to get total count records to display.
    -> PageSize which is used to set page size i.e., how many records should be displayed per page.
    -> ToalPages which is used to get and get how many pages are present.
-> OrderList contains
    -> OrderId
    -> CustomerName
    -> Customer Email
    -> Product 
    -> Amount
-> OrderPagination contains
   -> both pagination and OrderList.
Controllers:
============
-> our application consists of to controllers Customer controller and Order Controller.
-> All customer related operations are performed in Customer Controllers and all Order related operations are performed in Orders controoller.

Services:
=========
-> we have two services one for Customer and other Order
-> we use interfaces for dependency Injection. so, we have two interfaces under each service( customer, Order).
-> we have two classes for each interface.
-> we declare these interfaces and classes in Startup.cs-> ConfigureServices using Add.Scoped<interface, class>();

Repository:
=========
-> we have two Repository one for Customer and other Order
-> we use interfaces for dependency Injection. so, we have two interfaces under each repository( customer, Order).
-> we have two classes for each interface.
-> we declare these interfaces and classes in Startup.cs-> ConfigureServices using Add.Scoped<interface, class>();

ViewModels:
===========
-> In view Models we have implenmeted Validations using data Annotations.
-> we have three viewModels they are 1) CustomerViewModel, OrderViewModel, ItemListViewModel.


RegisterCustomer:
=================

-> Register() is used to register the customer which is present in Customer controller.
-> First it perform validations and if all validations are done it process request to services and if validations are not satisfied we return with statu code with bad request of object.
-> we register customer based on email. Each customer should have unique email.
-> if email aready exists we return with status code 409.


Create Order:
==============
-> CreateOrder() is used to create the orders which is present in Order controller.
-> First it perform validations and if all validations are done it process request to services and if validations are not satisfied we return with statu code with bad request of object.
-> we create orders based on email. Each customer can have multiple items.
-> for creating a Order Email, product, amount is mandatory.


GetOrderList();
===============

-> we get order list based on page number and page size.
-> we pass page number and page size to get method as parameters  based on that we get records and display to the user.
