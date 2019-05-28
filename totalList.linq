<Query Kind="Program">
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

void Main()
{

	var products = new List<SimpleProduct>()
{
	new SimpleProduct{
		ProductName = "苹果",
		 OldPrice = 10 ,
		  StockQuantity = 100
	},
	new SimpleProduct{
		ProductName = "香蕉",
		 OldPrice =4,
		  StockQuantity = 10
	},
	new SimpleProduct{
		ProductName = "橘子",
		 OldPrice = 6 ,
		  StockQuantity = 0
	},
};


	var totalResult = new List<SimpleProduct>();
	int maxStockQuantity = 0;
	int maxOldPrice = 5;
	foreach (var item in products)
	{
		if (item.StockQuantity > maxStockQuantity && item.OldPrice > maxOldPrice)
		{
			totalResult.Add(item);
		}
	}

	totalResult.Dump($"库存量大于{maxStockQuantity}并且原价大于{maxOldPrice}是");



	this.Products.Where(c => c.StockQuantity > 0 && c.OldPrice > 10).Dump();
}










public class SimpleProduct
{

	public string ProductName { get; set;}
	// 库存量
	public int StockQuantity { get; set; }
	// 原价
	public decimal OldPrice { get; set;}
}

