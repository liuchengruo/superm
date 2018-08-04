using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Service;

namespace Vic.SuperS.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingService shoppingService = new ShoppingService();

            var allProducts = shoppingService.GetAllProducts();
            allProducts.ForEach(i => Console.WriteLine(i));

            var cart = shoppingService.CreateShoppingCart();

            string input = "";
            bool canExit = false;

            string removeCmd = "";

            do
            {
                Console.WriteLine("please input product id or command...");

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "exit":
                    case "quit":
                        canExit = true;
                        break;
                    case "checkout":
                        var receipt = shoppingService.Checkout(cart.Id);
                        Console.WriteLine(receipt);
                        canExit = true;
                        break;
                    case "list":
                        var list = shoppingService.GetShoppingCartItems(cart.Id);
                        list.ForEach(i => Console.WriteLine(i));
                        break;
                    default:
                        break;
                }
                /*
                if (input.StartsWith(removeCmd))
                {
                    string id = input.Substring(removeCmd.Length);
                    int prodId = ParseProductId(id);

                    if (prodId > 0)
                    {
                        shoppingService.RemoveProduct(cart.Id, prodId);
                    }
                    continue;
                }
                */
                int productId = 0;

                if (int.TryParse(input, out productId))
                {
                    var buy = shoppingService.BuyProduct(cart.Id, productId);
                    Console.WriteLine(buy.ToString());
                }
                else
                {
                    Console.WriteLine("please input right product id");
                }

            } while (!canExit);

            cart.ShoppingItems.ForEach(i => Console.WriteLine($"ProductId={i.ProductId}, Count={i.Count}, TotalPrice={i.TotalPrice}"));

            Console.WriteLine("thank you, bye");
            Console.ReadLine();
        }

        /*
        public static int ParseProductId(string productId)
        {
            int result = 0;
            int.TryParse(productId, out result);
            return result;
        }
        */
    }
}
