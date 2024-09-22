using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_3
{
    internal class Program
    {
        // This one took like 2 hours to figure out, but I got it. I will try to explain it all in some detail, because while I do understand it, I want to state most of it for myself also.

        //The List sets up the Products in the cart, placed outside of ALL of it so that ALL of it can access the List.
        //Same with each of the objects. I did this mostly so that AddProduct and RemoveProduct could access the Products themselves.
        public static List<Product> cartProducts = new List<Product>();
        //The Products!!!
        public static Product ItemOne = new Product("A", "Water", 1.00);
        public static Product ItemTwo = new Product("B", "Bread", 3.50);
        public static Product ItemThree = new Product("C", "Milk", 2.00);
        public static Product ItemFour = new Product("D", "Candy", 5.00);
        
        public class Product
        {
            //In this case, I am still unsure if get, set is necessary. I understand what it does when used, but I don't know if it is wholly needed. SO I use it in case.
            //Set the ID
            public string ProductID { get; set; }
            //Set the Name
            public string ProductName { get; set; }
            //Set the Price
            public double Price { get; set; }
            //Sets up so the Items from above can create the values of the products used in the code
            public Product(string productID, string productName, double price)
            {
                this.ProductID = productID;
                this.ProductName = productName;
                this.Price = price;
            }
        }
        public class ShoppingCart
        {
            public void AddProduct(string addedProduct)
            {
                //Even though the List and initialization of the products gave me some trouble, the if statements to Add the items were a breeze, comparatively.
                //Each product checks if the user input the exact name (which is stated), and adds to the list. It does this for each product.
                if (addedProduct == "Water")
                {
                    cartProducts.Add(ItemOne);
                    Console.WriteLine("Item Added!");
                    Console.ReadLine();
                }
                else if (addedProduct == "Bread")
                {
                    cartProducts.Add(ItemTwo);
                    Console.WriteLine("Item Added!");
                    Console.ReadLine();
                }
                else if (addedProduct == "Milk")
                {
                    cartProducts.Add(ItemThree);
                    Console.WriteLine("Item Added!");
                    Console.ReadLine();
                }
                else if (addedProduct == "Candy")
                {
                    cartProducts.Add(ItemFour);
                    Console.WriteLine("Item Added!");
                    Console.ReadLine();
                }
                else
                { Console.WriteLine("There was an error. Make sure to type the item exactly as shown."); Console.ReadLine(); }
            }
            public void RemoveProduct(string takenProduct)
            {
                //Most are near the same, this is EXACTLY the same as the Add program, but to do the opposite. Same wording and all. This is the easy part, I just needed some time to think it out.
                if (takenProduct == "Water")
                {
                    cartProducts.Remove(ItemOne);
                    Console.WriteLine("Item Removed!");
                    Console.ReadLine();
                }
                else if (takenProduct == "Bread")
                {
                    cartProducts.Remove(ItemTwo);
                    Console.WriteLine("Item Removed!");
                    Console.ReadLine();
                }
                else if (takenProduct == "Milk")
                {
                    cartProducts.Remove(ItemThree);
                    Console.WriteLine("Item Removed!");
                    Console.ReadLine();
                }
                else if (takenProduct == "Candy")
                {
                    cartProducts.Remove(ItemFour);
                    Console.WriteLine("Item Removed!");
                    Console.ReadLine();
                }
                else
                { Console.WriteLine("There was an error. Make sure to type the item exactly as shown."); Console.ReadLine(); }
            }
            public void CalculateTotalPrice()
            {
                //I was confused on what to do at first, but the funny part is, once I initialized the totalPrice, VS just recommended the exact code I needed, and it works!
                //I understand it anyway, that it takes each Product in the list, finds the Price field, and sums it up into totalPrice, then print!
                double totalPrice = 0;

                foreach (Product product in cartProducts)
                {
                    totalPrice += product.Price;
                }
                Console.WriteLine("Your total price is " + totalPrice);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            int action = 0;
            //initialize the action so the user input functions
            ShoppingCart cart = new ShoppingCart();
            //create the actual cart so the methods and classes can be called by something.
            while (action != 4)
            {
                Console.WriteLine("*SHOPPING*");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 to add an item, 2 to remove one, 3 to check price, and 4 to exit.");
                action = Convert.ToInt32(Console.ReadLine());

                //easy if statement to sort through each decision. For the Add and Remove, I was going to go with the ID (A, B, C, D), but it seemed that it would be clearer to a user if it had the name,
                //not a random ID that they may or may not know the product of. I also forwent ToLower, so it would understand as long as the user puts in the exact name. It prints the name, and clarifies if it goes wrong, so I'm proud.
                if (action == 1)
                {
                    Console.WriteLine("What product would you like to add?");
                    Console.WriteLine("Water, Bread, Milk, or Candy?");
                    string addedProduct = Console.ReadLine();
                    cart.AddProduct(addedProduct);
                }
                else if (action == 2)
                {
                    Console.WriteLine("What product would you like to remove?");
                    Console.WriteLine("Water, Bread, Milk, or Candy?");
                    string takenProduct = Console.ReadLine();
                    cart.RemoveProduct(takenProduct);
                }
                else if (action == 3)
                {
                    cart.CalculateTotalPrice();
                }
                else if (action == 4)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("That number doesn't have an action associated. Try again!");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
            //CONSOLE.READLINE();, WOOHOO!
            //Overall though, I am glad that this one was last, because it broke me out of the 'write a few comments because I'm confident' thing.
            //As in, I was confident prior, and am now confident, but I put a lot of comments here because DURING the writing, I was not confident. But I understand better now.

            //(Again, I am not perfect and a pop quiz will likely result in my brain malfunctioning.) Just saying.
        }
    }
}

