using API_Interactive_Lab_1.Controllers;
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
}
