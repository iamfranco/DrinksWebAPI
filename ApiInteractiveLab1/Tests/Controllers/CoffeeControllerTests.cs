using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers;

public class CoffeeControllerTests
{
    [Test]
    public void TestGetCoffeeLover()
    {
        string expectedResult = "I like coffee!";

        var controller = new CoffeeController();
        
        string result = controller.GetLover();

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void TestGetCoffee_With_No_QueryParams()
    {
        var controller = new CoffeeController();

        Coffee coffee = controller.Get();

        Assert.AreEqual("latte", coffee.Name);
        Assert.AreEqual(-1, coffee.Id);
    }

    [Test]
    public void TestGetCoffee_With_Name_Param_Cappuccino()
    {
        var controller = new CoffeeController();

        Coffee coffee = controller.Get("Cappuccino");

        Assert.AreEqual("Cappuccino", coffee.Name);
        Assert.AreNotEqual(-1, coffee.Id);
    }

    [Test]
    public void TestGetCoffee_With_Name_Param_Frappe()
    {
        var controller = new CoffeeController();

        Coffee coffee = controller.Get("frappe");

        Assert.AreEqual("frappe", coffee.Name);
        Assert.AreNotEqual(-1, coffee.Id);
    }
}
