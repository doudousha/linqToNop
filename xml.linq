<Query Kind="Statements" />


string xmlPath = @"E:\git\linq2ocr\config\ocr\ocr.xml";
// 获取xml根元素
var doc = XElement.Load(xmlPath);
// 获取所有word元素
var query = from zons in doc.Elements("page").Elements("zone").Elements("paragraph").Elements("line").Elements("word")
			select zons;
			
query.Dump();