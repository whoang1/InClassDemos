<Query Kind="Statements">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//step 1 connect to the desired database
//click on Add connecton
//Take defults press next 
//Change server to . (dot) select existing database from drop down list
//Optionally press Test connection
//press OK
//rember to check the connection drop down list to see whic database is the active connnection

//result should show database Tables
//expanding a table will reveal the table atttributes and relationships.

//view waiter data
Waiters

//query to also view Waiter data
from item in Waiters
select item

//method syntax to view Waiter data
Waiters
   .Select (item => item)
   
//alter the query syntax into a C# statement
var results = from item in Waiters
				select item;
results.Dump();

//once the query is created, tested, you will be able to 
//transfer the query with minor modifications into your 
//BLL methods
//public List<pocoObeject> SomeBllMethodName()
//{
	//content to your DAL object : var contextvariable
	//do your query
//	var results = from item in contextvariable.Waiters
//				select item;
//	return result.ToList();
//}