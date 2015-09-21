<Query Kind="Expression">
  <Connection>
    <ID>30204253-2820-45e3-8e89-44e0ae0df87d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from category in MenuCategories
select new
{
	Category = category.Description,
	Items = category.Items.Count()
}

from category in MenuCategories
select new
{
	Category = category.Description,
	Items = (from x in category.Items
					select x).Count() 
}

(from theBill in BillItems
where theBill.BillID == 104
select theBill.SalePrice * theBill.Quantity).Sum()

BillItems
	.Where (theBill => theBill.BillID == 104)
	.Select (theBill => theBill.SalePrice * theBill.Quantity)
	.Sum()
	
(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Sum (theBill => theBill.SalePrice * theBill.Quantity)).Max()

(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Count()).Average()
