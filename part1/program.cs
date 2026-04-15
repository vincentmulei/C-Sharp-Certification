namespace part1
{
    public class MyFirstCode
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello from the HelloWorld class!");

            Console.WriteLine("Congratulations!");
            Console.WriteLine("You wrote your first lines of code.");

            Console.WriteLine("This is the first line.");

            Console.Write("This is ");
            Console.Write("the second ");
            Console.Write("line.");
        }
    }

    public class Literals
    {
        public void StringLiterals()
        {
            Console.WriteLine('b');
            //Console.WriteLine('Hello World!'); //CS1012: Too many characters in character literal
        }

        public void IntegerLiterals()
        {
            Console.WriteLine(123);
        }

        public void FloatingPointLiterals()
        {
            Console.WriteLine(0.25F);

            //To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.
            Console.WriteLine(3.14);

            Console.WriteLine(12.39816m); // decimal literal with m suffix
        }

        public void BooleanLiterals()
        {
            Console.WriteLine(true);
            Console.WriteLine(false);
        }

        public void ImplicitlyTypedLocalVariables()
        {
            var myString = "Hello World!";
            var myInt = 123;
            var myFloat = 0.25F;
            var myDouble = 3.14;
            var myDecimal = 12.39816m;
            var myBool = true;

            Console.WriteLine(myString);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myBool);
        }
    }

    public class StringFormatting
    {
        public void CharacterEscapes()
        {
            Console.WriteLine("This is a string with a newline character.\nSee? It goes to the next line.");
            Console.WriteLine("This is a string with a tab character.\tSee? It adds a tab space.");
            Console.WriteLine("This is a string with a backslash character.\\ See? It prints a backslash.");
            Console.WriteLine("This is a string with a double quote character. \"See? It prints a double quote.\"");
        }

        public void VerbatimStringLiterals()
        {
            Console.WriteLine(@"    c:\source\repos    
                (this is where your code goes)");
        }

        public void StringInterpolation()
        {
            string name = "Alice";
            int age = 30;

            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }

        public void CompositeFormatting()
        {
            string name = "Bob";
            int age = 25;

            Console.WriteLine("My name is {0} and I am {1} years old.", name, age);
        }

        public void StringConcatenation()
        {
            string name = "Charlie";
            int age = 35;

            Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
        }

    }

    public class NumberOperations
    {
        public void Addition()
        {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);
        }

        public void MathOperations()
        {
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
        }

        public void DivisionByDecimalLiteral()
        {
            // decimal decimalQuotient = 7.0m / 5;
            // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            //For this to work, the quotient (left of the assignment operator) must be of type decimal and at least one of numbers being divided must also be of type decimal (both numbers can also be a decimal type).


            //invalid code
            // int decimalQuotient = 7 / 5.0m;
            // int decimalQuotientB = 7.0m / 5;
            // int decimalQuotientC = 7.0m / 5.0m;
            //decimal decimalQuotient = 7 / 5;
            //Console.WriteLine($"Decimal quotient: {decimalQuotient}");
        }

        public void CastIntegerDivision()
        {
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
        }

        public void incrementOperatorBeforeAndAfterTheValue()
        {
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            //value++ - Retrieve the current value of the variable value and use that in the string interpolation operation, then increament it.
            //++value - Retrieve the new incremented value of the variable value and use that in the string operation.
        }

        public void Challenge()
        {
            int fahrenheit = 94;
            decimal multiplier = (decimal)5 / (decimal)9;
            fahrenheit -= 32;
            decimal result = (decimal)fahrenheit * multiplier;

            Console.WriteLine($"{result} Celcius");

            // answer
            int fahrenheitA = 94;
            decimal celsius = (fahrenheitA - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }
    }
}






















