<Query Kind="Expression">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//grouping
from food in Items
group food by food.MenuCategory.Description

//requires the creation of a an anonymous type
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}