namespace part3
{
    public class Branching
    {
        public void SwitchMethod()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }

        public void ForLoop()
        {
            // for (int i = 0; i < 10; i += 3)
            // {
            //     Console.WriteLine(i);
            // }


            //exit the loop prematurely

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            //     if (i == 7) break;
            // }


            //more control in how we loop through array Items

            // string[] names = { "Alex", "Eddie", "David", "Michael" };
            // for (int i = names.Length - 1; i >= 0; i--)
            // {
            //     Console.WriteLine(names[i]);
            // }


            //foreach can't do this

            string[] names = { "Alex", "Eddie", "David", "Michael" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                string label = "";

                if (divisibleBy3 && divisibleBy5) label = "FizzBuzz";
                else if (divisibleBy3) label = "Fizz";
                else if (divisibleBy5) label = "Buzz";
                else { }

                Console.WriteLine($"{i} - {label}");
            }

        }
    }
}