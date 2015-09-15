<Query Kind="Expression">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Simple where clause

//list all tables that hold more than 3 people
from row in Tables 
where row.Capacity > 3
select row

//list all items that are with more than 500 Calories
from foodies in Items
where foodies.Calories > 500
select foodies

//list all items that with more than 500 calories and sells for more than 10 dollars
from foodies in Items
where foodies.Calories > 500 && foodies.CurrentPrice > 10.00m
select foodies

//list all item that with more than 500 calories and 
//are Etrees on the menu.
//HINT: navigational properties of the databse and LINQPad knowledge
from foodies in Items
where foodies.Calories > 500 && foodies.MenuCategory.Description.Equals("Entree")
select foodies