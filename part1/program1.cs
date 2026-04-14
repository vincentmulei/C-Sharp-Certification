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
}