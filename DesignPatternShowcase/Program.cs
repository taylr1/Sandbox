// See https://aka.ms/new-console-template for more information

using DesignPatternShowcase.Bridge;
using DesignPatternShowcase.Bridge.Abstract;
using DesignPatternShowcase.Factory;
using DesignPatternShowcase.Factory.Interface;
using DesignPatternShowcase.Mediator;
using DesignPatternShowcase.Mediator.Base;
using DesignPatternShowcase.Mediator.SubTypes;
using DesignPatternShowcase.Singleton;
using DesignPatternShowcase.Utility;

ConsoleUtil.CreateDivider("Singleton");

var singleton = Singleton.Instance;
singleton.SayHello();

ConsoleUtil.CreateDivider("Factory");

var factory = new TeamFactory();
ITeam team = factory.GetTeam(TeamFactory.Teams.OregonOddities);
Console.WriteLine($"Your selected team is: {team.TeamName}!");

ConsoleUtil.CreateDivider("Mediator");

var med = new ShopMediator();

var clerkA = new ClerkA(med);
var clerkB = new ClerkB(med);
var shopperA = new ShopperA(med);
var shopperB = new ShopperB(med);

med.Clerks = new List<ClerkAbstract>() { clerkA, clerkB };
med.Shopper = shopperA;

shopperA.InitiateCheckout();

ConsoleUtil.CreateDivider("Bridge");

ShopAbstract @abstract;

@abstract = new StandardShop(new Shop_1());
@abstract.ListShopAttributes();
@abstract.CalculateEmployeePay();

@abstract = new StandardShop(new Shop_2());
@abstract.ListShopAttributes();
@abstract.CalculateEmployeePay();

ConsoleUtil.CreateDivider("End");