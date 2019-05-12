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



// 查询已关联会员地址的会员
var query = from c in this.Customers
			join ca in this.CustomerAddresses on c.Id equals ca.Customer_Id
			select c;
query.Dump();

// DefaultIfEmpty 告诉linq，使用左连接
var query2 = from c in this.Customers
			join ca in this.CustomerAddresses on c.Id equals ca.Customer_Id into cal
			from calr in cal.DefaultIfEmpty()
			select new {
				c.Id,
				addressId =  calr == null ? 0 : calr.Address_Id
			};

query2.Dump();

