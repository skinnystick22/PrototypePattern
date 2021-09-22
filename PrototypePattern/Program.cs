// See https://aka.ms/new-console-template for more information

using System;
using PrototypePattern;

Console.WriteLine("Original order:");
var savedOrder = new FoodOrder("Tyler Miller", true, new[] { "Pizza", "Coke" }, new OrderInfo(2345));
savedOrder.Debug();

Console.WriteLine("Cloned Order");
var clonedOrder = (FoodOrder)savedOrder.DeepCopy();
clonedOrder.Debug();

Console.WriteLine("Order Changes:");
savedOrder.CustomerName = "Jeff";
savedOrder.OrderInfo.Id = 5555;
savedOrder.Debug();
clonedOrder.Debug();

var manager = new PrototypeManager();
manager["2/3/2020"] = new FoodOrder("Steve", false, new []{"Chicken Parm", "Root Beer"}, new OrderInfo(8912));

Console.WriteLine("Manager Clone:");
var managerOrder = (FoodOrder)manager["2/3/2020"].DeepCopy();

managerOrder.Debug();