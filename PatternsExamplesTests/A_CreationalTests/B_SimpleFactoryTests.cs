// #region Copyright
// /* 
// ============================================================
// PatternsExamplesTests - B_SimpleFactoryTests.cs
// All samples copyright 5/26/2013 Phil Japikse, www.skimedic.com
// see License.txt for license information
// ============================================================
// */
// Phil Japikse
// #endregion    

#region Copyright

#endregion

using PatternsExamples.A_Creational.B_SimpleFactory;
using NUnit.Framework;
using System.Linq;
using PatternsExamples.A_Creational.D_AbstractFactory;

namespace PatternsExamplesTests.A_CreationalTests
{
    [TestFixture]
    public class SimpleFactoryTests
    {
        [Test]
        public void ShouldCreateCheesePizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.Cheese);
            //Assert.Contains(pizza.Toppings, PizzaType.Cheese.ToString());
        }

        [Test]
        public void ShouldCreateASausagePizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.Sausage);
            //Assert.Contains(pizza.Toppings, PizzaType.Cheese.ToString());
            //Assert.Contains(pizza.Toppings, PizzaType.Sausage.ToString());
        }

        [Test]
        public void ShouldCreateAPepperoniPizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.Pepperoni);
            //Assert.Contains(pizza.Toppings, PizzaType.Cheese.ToString());
            //Assert.Contains(pizza.Toppings, PizzaType.Pepperoni.ToString());
        }

        [Test]
        public void ShouldReturnNullIfInvalidPizzaType()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.UnKnown);
            Assert.IsNull(pizza);
        }
    }
}