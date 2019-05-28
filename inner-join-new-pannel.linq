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
  <Reference Relative="..\linqpad2sql\LinqPadHelper\LinqPadHelper\bin\Debug\LinqPadHelper.dll">E:\git\linqpad2sql\LinqPadHelper\LinqPadHelper\bin\Debug\LinqPadHelper.dll</Reference>
  <Namespace>LinqPadHelper</Namespace>
</Query>

// Fluent写法: 查找类型是'Notebooks' 的产品
this.Products.Where(c => c.Product_Category_Mappings.Any(pcm => pcm.Category.Name == "Notebooks")).DumpX("example1");



// Linq表达式写法1:
var query2 = from pc in this.Categories
			 join pcm in this.Product_Category_Mappings on pc.Id equals pcm.CategoryId
			 join p in this.Products on pcm.ProductId equals p.Id
			 where pc.Name == "Notebooks"
			 select p;

query2.DumpX("example2");



// Linq表达式写法2:
var query3 = from pc in this.Categories.Where(c => c.Name == "Notebooks")
			 join pcm in this.Product_Category_Mappings on pc.Id equals pcm.CategoryId
			 join p in this.Products on pcm.ProductId equals p.Id
			 select p;
query3.DumpX("example3");