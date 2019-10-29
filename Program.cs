using System;namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("nintendo switch", 299.99m);

            Console.WriteLine($"Your product is a J_O_Y_C_O_N_B_O_Y_Z_ {product.Name} for {product.Price}. Represent.");
        }
    }
}
