<Query Kind="Expression">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default ascending 
from food in Items
orderby food.Description
select food

//default descending 
from food in Items
orderby food.CurrentPrice descending
select food

//default ascending and ascending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

//default ascending and ascending
from food in Items
where food.MenuCategory.Description.Equals("Entree")
orderby food.CurrentPrice descending, food.Calories ascending
select food