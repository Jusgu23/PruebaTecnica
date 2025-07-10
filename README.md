Para ejecutar el proyecto sube por estepuerto:


 `http://localhost:4200/`

--Se maneja la Identification como PK ya que las identificaciones son diferentes y no se repiten.
create table dbo.cliente
(
Id   int identity (1,1) not null,
Identification int not null,
FirstName varchar (15) not null,
SecondtName varchar (15) ,
FirstSurname varchar (15) not null,
SecondtSurname varchar (15),
Addres varchar (100) not null,
phone int not null,
IdOrder int not null
)

alter table dbo.cliente
add foreign key (IdOrder) references  dbo.ServiceOrder (Id)

--add primary key  (Identification)

--Se maneja el CodeProduct como PK ya que este no se repitiria, si el usuario pone un codigo ya existente lo cargaria.
create table dbo.InventoryProduct
(
Id   int identity (1,1) not null,
CodeProduct Int not null ,
NomeProduct varchar(50) not null,
State bit  default 1,
ValueUnit decimal (18,2) not null ,
QuantityStock int default 0 not null,
)


alter table dbo.InventoryProduct
add primary key  (CodeProduct)



create table dbo.ServiceOrder
(
Id  int identity (1,1) not null primary key ,
IdentificationClient int,
CodeProduct  int,
DateRegister date,
Estado int,
DeliveryAddress varchar (50),
Priority int,
ValueParcial decimal (18,2),
ValueTotalOrder decimal (18,2),
cantidadPedido int)



alter table dbo.ServiceOrder
add foreign key (CodeProduct) references  dbo.InventoryProduct (CodeProduct) 

--add foreign key (IdentificationClient) references  dbo.cliente (Identification)


