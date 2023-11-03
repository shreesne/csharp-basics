using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using VendingMachineApplication.Model;
using VendingMachineApplication.Service;
using static System.Formats.Asn1.AsnWriter;

namespace VendingAppTesting
{
    public class UnitTest1
    {
        VendingMachineService machineService = new VendingMachineService();

        [Fact]
        public void TestShowAllPeoducts()
        {
            
            List<string> productInfo = machineService.ShowAll();

            // Assert
            // Add your assertions here to check if the productInfo contains the expected data
            Assert.Contains("D1,Coffee,25", productInfo);
            Assert.Contains("D2,Soda,25", productInfo);

        }
        [Fact]
        public void TestInsertMoney()
        {
            [Theory]
            [InlineData(1)]
            [InlineData(5)]
            [InlineData(10)]
            [InlineData(20)]
            [InlineData(50)]
            [InlineData(100)]
            [InlineData(500)]
            [InlineData(1000)]
            void InsertMoney_ValidDenomination(int denomination)
            {
               machineService.InsertMoney(denomination);
            }

            [Theory]
            [InlineData(2)]
            [InlineData(15)]
            [InlineData(25)]
            [InlineData(200)]
            void InsertMoney_InvalidDenomination(int denomination)
            {
                machineService.InsertMoney(denomination);
            }
        }
        [Fact]
        public void TestPurchase()
        {
            [Fact]
             void Purchase_ProductExists_ReturnsProduct()
            {
                Product product = new Drink("D1", "Coffee",25,"Chocolate");
                machineService.InsertMoney(50);
                var purchasedProduct = machineService.Purchase("D1");

                // Assert
                Assert.NotNull(purchasedProduct);
                Assert.Equal("D1", purchasedProduct.Id);
                Assert.IsType<Drink>(purchasedProduct);
                Assert.Equal("Coffee", purchasedProduct.Name);

            }
            [Fact]
            void Purchase_ProductDoesNotExist_ReturnsNull()
            {
                var result = machineService.Purchase("NonExistentProduct");
                Assert.Null(result);
            }

        }
        [Fact]
        public void TestEndTransaction()
        {
            [Fact]
            void EndTransaction_ExactChange_ReturnsEmptyDictionary()
            {
                Dictionary<int,int> dict1 = new Dictionary<int, int> { { 10, 0 }, { 5, 0 }, { 1, 0 } };
                Dictionary<int, int> dict2 = new Dictionary<int, int> { { 10, 0 }, { 5, 0 }, { 1, 0 } };
                bool overwriteExistingKeys = true ;
                var change = machineService.EndTransactions(dict1,dict2, overwriteExistingKeys);
                var expected = new Dictionary<int, int>
                  {
                     { 10, 0 },
                     { 5, 0},
                     { 1,0 }
                  };

                Assert.Equal(expected, change);
            }
            [Fact]
            void EndTransaction_EnoughPayment_ReturnsChange()
            {
                Dictionary<int, int> dict1 = new Dictionary<int, int> { { 10, 0 }, { 5, 0}, { 1, 0 } };
                Dictionary<int, int> dict2 = new Dictionary<int, int> { { 10, 1 }, { 5, 1 }, { 1, 5 } };
                bool overwriteExistingKeys = true;
                // Act
                var change = machineService.EndTransactions(dict1,dict2,overwriteExistingKeys);
                var expected = new Dictionary<int, int>
                  {
                     { 10, 1},
                     { 5, 1},
                     { 1,5}
                  };
                Assert.Equal(expected, change);
            }
        }
        [Fact]
        public void TestReturnChange()
        {
            machineService.InsertMoney(500);
            Product product = new Drink("D1", "Coffee", 50, "Chocolate");
            var purchasedProduct = machineService.Purchase("D1");
           int total= machineService.CalculateMoneyPoolTotal();
            int price=purchasedProduct.Price;
            int result = total - price;
            Assert.Equal(450, result);


        }

    }
}