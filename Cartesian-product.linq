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


var productQueryable = from category in this.Categories
					   from product in this.Products
					   select new {
								categoryName =category.Name ,
								productName = product.Name
					    };
						
						
productQueryable.Dump();


// 笛卡儿积： 查询个数等两个查询集合相乘的个数

var sumCount =  productQueryable.Count();
var result =  sumCount  == this.Categories.Count()  * this.Products.Count() ;
result.Dump("对比结果");
