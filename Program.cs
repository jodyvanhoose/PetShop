using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace PetShop
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    
                    Console.WriteLine("Enter 1 for Cat Product or 2 for Dog Product");
                    userInput = Console.ReadLine();
                    while (userInput != "1" && userInput != "2")
                    {
                        Console.WriteLine("Invalid input. Please enter 1 for Cat Product or 2 for Dog Product");
                        userInput = Console.ReadLine();
                    }

                    if (userInput == "1")
                    { 
                        CatFood catFood = new CatFood();
                        Console.WriteLine("Enter cat food name");
                        catFood.name = Console.ReadLine();
                        Console.WriteLine("Is this product for a kitten? Enter yes or no");
                        string isKitten = Console.ReadLine();
                        if (isKitten.ToLower() == "yes")
                        {
                            catFood.kittenFood = true;

                        }
                        Console.WriteLine("Enter 10 for 10lb bag or 20 for 20lb bag");
                        catFood.weightPounds = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter price");
                        catFood.price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter quantity");
                        catFood.quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter brief description");
                        catFood.description = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        // Console.WriteLine(JsonSerializer.Serialize(catFood));

                        Console.WriteLine("You have entered the following product: ");
                        Console.WriteLine($"Cat food name: {catFood.name}");
                        Console.WriteLine($"Price: ${catFood.price}");
                        Console.WriteLine($"Quantity: {catFood.quantity}");
                        Console.WriteLine($"Description: {catFood.description}");
                        Console.WriteLine($"Weight: {catFood.weightPounds}lb bag");
                        Console.WriteLine($"Kitten Food: {isKitten.ToUpper()}");

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        DogLeash dogLeash = new DogLeash();
                        Console.WriteLine("Enter product");
                        dogLeash.name = Console.ReadLine();
                        Console.WriteLine("Enter price");
                        dogLeash.price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter quantity");
                        dogLeash.quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter brief description");
                        dogLeash.description = Console.ReadLine();
                        Console.WriteLine("Enter length in inches");
                        dogLeash.lengthInches = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter type of material");
                        dogLeash.material = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("You have entered the following product: ");
                        Console.WriteLine($"Dog Leash name: {dogLeash.name}");
                        Console.WriteLine($"Price: ${dogLeash.price}");
                        Console.WriteLine($"Quantity: {dogLeash.quantity}");
                        Console.WriteLine($"Description: {dogLeash.description}");
                        Console.WriteLine($"Length: {dogLeash.lengthInches} inches");
                        Console.WriteLine($"Leash material: {dogLeash.material}");

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    
                }

                

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
        }
    }

   
 
}
