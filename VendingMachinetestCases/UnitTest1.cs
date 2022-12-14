using Repository;

namespace VendingMachinetestCases
{
    public class Tests
    {

        private VendingMachineIMPL _vendingMachineIMPL;
        private string product;
        private float overallmoney;

        [SetUp]
        public void Setup()
        {

            _vendingMachineIMPL = new VendingMachineIMPL();
            product = "CO";
            overallmoney = 100;
        }

        [Test]
        public void Product_Buy_Positive_Test()
        {
            float returnValue = _vendingMachineIMPL.buy(product, overallmoney);
            Assert.Greater(returnValue, 0);
        }

        [Test]
        public void Product_Buy_Negetive_Test()
        {
            product = "InvalidProduct";
            float returnValue = _vendingMachineIMPL.buy(product, overallmoney);
            Assert.LessOrEqual(returnValue, 0);
        }
    }
}