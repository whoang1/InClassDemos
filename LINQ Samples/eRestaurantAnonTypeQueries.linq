<Query Kind="Expression">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous type
from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
		food.Active
orderby food.CurrentPrice descending
select new
		{	
			Description = food.Description,
			Price = food.CurrentPrice,
			Cost = food.CurrentCost,
			Profit = food.CurrentPrice - food.CurrentCost
		}