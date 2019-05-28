<Query Kind="Program">
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
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Api.BuildRequest\bin\Debug\Financial.Api.BuildRequest.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\Financial.Dal.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\EntityFramework.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\MySql.Data.dll</Reference>
  <Reference>D:\NET_NEW\企帐通New\trunk\Financial\Financial.Dal\bin\Debug\MySql.Data.Entity.EF6.dll</Reference>
</Query>

void Main()
{
	var products = DoGetSimpleProduct(); 
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
}


public List<SimpleProduct> DoGetSimpleProduct()
{

	var lists = new List<SimpleProduct>(){
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
	
	return lists;
}










public class SimpleProduct
{

	public string ProductName { get; set;}
	// 库存量
	public int StockQuantity { get; set; }
	// 原价
	public decimal OldPrice { get; set;}
}