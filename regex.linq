<Query Kind="Statements" />


// 验证手机号
string mobileNo = "15825965512" ;
Regex.IsMatch(mobileNo,@"^[1]+[3,5]+\d{9}").Dump();

// Match 取出姓名
string str = "my name is: 大哥大";
Regex.Match(str,"my name is:(.*)").Dump();