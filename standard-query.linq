<Query Kind="Statements">
  <Connection>
    <ID>d5a1384a-8a73-4da7-bc68-0b08d0267ebd</ID>
    <Persist>true</Persist>
    <Server>103.206.122.225</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAg5UBSgkwRECQuGj5aN5HxgAAAAACAAAAAAAQZgAAAAEAACAAAAClDY41PSgMfZyzjKm3w9AZHvjS2Sh8Os8IFSaskwyzfgAAAAAOgAAAAAIAACAAAACCFEHXSweDlV5+4H3M9Gr4+4lOZLVwueEpPoYjMnD3YRAAAACmK0yTG+PZYTR9fjzYXBRDQAAAABsKd2sTdfQL0aI2vWutg5hbHYqawIXjem7MkEwNCSeLoXaxMvTLFxrocN7QqlSQU0txbS1Z8S4Pcwoi3fyhifw=</Password>
    <Database>nop</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Output>DataGrids</Output>
</Query>


// 简单查询
var query = from product in this.Products
			select product;
			
query.Dump();

// linqpad 独有写法
this.Products.Dump();

// 指定查询条件
this.Products.Where(c=>c.Name == "Apple MacBook Pro 13-inch").Dump();
// 指定查询条件 - linq 表达式查询语法
(
	from  product in this.Products
	where product.Name ==  "Apple MacBook Pro 13-inch"
	select product
).Dump();

// 指定查询条件 - linq 表达式查询语法：where 变体
(
	from product  in this.Products.Where(c=>c.Name== "Apple MacBook Pro 13-inch")
	select product
).Dump();

// 分页查询
int page = 1;
int pageSize = 10;
var queryResult = (
					 from product in this.Products
					 select product
				).Take(pageSize).Skip((page - 1) * pageSize);
queryResult.Dump();