<Query Kind="Statements">
  <Reference Relative="..\linqpad2sql\LinqPadHelper\LinqPadHelper\bin\Debug\LinqPadHelper.dll">E:\git\linqpad2sql\LinqPadHelper\LinqPadHelper\bin\Debug\LinqPadHelper.dll</Reference>
  <Namespace>LinqPadHelper</Namespace>
</Query>



"name:string -s 银行名称 -c,accountName:string -s 收款人 -c,accountNumber:string -s 收款账户 -c,userId:int -s 用户id -c"
.ToProps()
.DumpX("bankCard");


"name:string -s 银行名称 -c,accountName:string -s 收款人 -c,accountNumber:string -s 收款账户 -c,userId:int -s 用户id -c"
.ToProps()
.WrapperModel("RechargeApply")
.DumpX("bankCard类包装");

