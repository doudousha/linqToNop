<Query Kind="Statements">
  <Connection>
    <ID>fb508d83-0264-48d6-aa80-941aaf23905c</ID>
    <Persist>true</Persist>
    <Server>103.206.122.225</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAALj8+qVC7/0yV1ne7tzVdLgAAAAACAAAAAAAQZgAAAAEAACAAAAAYhjriXFIiPLmrBVJX0ZMzY4mM2nOeC2rM5onmqnuL7wAAAAAOgAAAAAIAACAAAADLoz4Aj3SHz7e0p5lS5DBI1mxLoJ9Oxf9RweLcpxNMohAAAAAjdWyq3rwNvnhk2nZJLp8kQAAAALP/dQsfEo39Sj4JhluirBGEGxTXE7Bu4Nd05Ol8VmKasBG1eZxJRNCTLvG/OhBGBnzxMndQ/m8y6viM8+kP7g8=</Password>
    <Database>nop</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Output>DataGrids</Output>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Api.BuildRequest\bin\Debug\Financial.Api.BuildRequest.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\Financial.Dal.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\EntityFramework.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\MySql.Data.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\MySql.Data.Entity.EF6.dll</Reference>
</Query>



// Fluent写法: 查找类型是'Notebooks' 的产品
this.Products.Where(c=>c.Product_Category_Mappings.Any(pcm=>pcm.Category.Name=="Notebooks")).Dump();



// Linq表达式写法1:
var query2 =  from pc in this.Categories
			join pcm in this.Product_Category_Mappings on pc.Id equals pcm.CategoryId
			join p in this.Products on pcm.ProductId equals p.Id
			where pc.Name ==  "Notebooks"
			select p;

query2.Dump();



// Linq表达式写法2:
var query3 = from pc in this.Categories.Where(c=>c.Name== "Notebooks")
			join pcm in this.Product_Category_Mappings on pc.Id equals pcm.CategoryId
			join p in this.Products on pcm.ProductId equals p.Id
			select p;
query3.Dump();



