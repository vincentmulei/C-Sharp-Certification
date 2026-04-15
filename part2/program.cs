namespace part2
{

    public class MethodCall
    {
        public void GetLargerNumber()
        {
            int num1 = 500;
            int num2 = 600;

            int largest = Math.Max(num1, num2);


            Console.WriteLine(largest);
        }
    }

    public class Arrays
    {
        public void WorkingWithArrays()
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        }

        public void ArrayInitialization()
        {
            string[] students = ["vinnie", "Aaron", "faith", "Mary"]; //introduced in C# 12
            string[] fruits = { "Apple", "Mango", "Guava", "Melon", "Banana" }; // older version


            Console.WriteLine("{0} is the first student while {1} is the last student", students[0], students[3]);

            Console.WriteLine($"Fruit 1 is {fruits[0]}");
        }

        public void Foreach()
        {
            // int[] inventory = { 200, 450, 700, 175, 250 };
            // int sum = 0;
            // foreach (int items in inventory)
            // {
            //     sum += items;
            // }

            // Console.WriteLine($"We have {sum} items in inventory.");


            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }

        public void Challenge()
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
        }
    }

}