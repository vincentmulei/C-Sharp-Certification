namespace part4
{
    public class DataTypes
    {
        public void SignedIntegralTypes()
        {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        }

        public void UnsignedIntegralTypes()
        {
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        }

        public void SignedFloatingPointTypes()
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public void ReferenceTypeVariable()
        {
            // int[] data = { 5, 3, 1 };

            // int test = 5;

            // Console.WriteLine($"The value of the first item of the array is {data[0]} and the test data is {test}");

            // ModifyInt(test);
            // Console.WriteLine(test);

            // ModifyArray(data);

            // Console.WriteLine(data[0]);


            // int val_A = 2;
            // int val_B = val_A;
            // val_B = 5;

            // Console.WriteLine("--Value Types--");
            // Console.WriteLine($"val_A: {val_A}");
            // Console.WriteLine($"val_B: {val_B}");

            // int[] ref_A = new int[1];
            // ref_A[0] = 2;
            // int[] ref_B = ref_A;
            // ref_B[0] = 5;

            // Console.WriteLine("--Reference Types--");
            // Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            // Console.WriteLine($"ref_B[0]: {ref_B[0]}");


            string message = "My name is Vincent";
            string newMessage = message;
            newMessage = "My name is Mulei";

            Console.WriteLine(message);


        }

        private void ModifyInt(int a)
        {
            a = 10;
        }

        private void ModifyArray(int[] a)
        {
            a[0] = 10;
        }

        public void TypeCasting()
        {
            //does the casting result in an exception or does the casting result in loss of information

            // int first = 2;
            // string second = "4";
            // int result = first + second;
            // Console.WriteLine(result);


            //widening conversion - no loss of information - implicit conversion is applicable
            // int myInt = 3;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = myInt;
            // Console.WriteLine($"decimal: {myDecimal}");


            // decimal myDecimal = 3.14m;
            // Console.WriteLine($"decimal: {myDecimal}");

            // int myInt = (int)myDecimal;
            // Console.WriteLine($"int: {myInt}");


            // decimal myDecimal = 1.23456789m;
            // float myFloat = (float)myDecimal;

            // Console.WriteLine($"Decimal: {myDecimal}");
            // Console.WriteLine($"Float  : {myFloat}");

            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);
        }


        public void ArrayHelperMethods()
        {
            // string[] pallets = ["B14", "A11", "B12", "A13"];
            // Console.WriteLine("");

            // Console.WriteLine($"Before: {pallets[0]}");
            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"After: {pallets[0]}");

            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }


            // string[] pallets = ["B14", "A11", "B12", "A13"];
            // Console.WriteLine("");

            // Console.WriteLine($"Before: {pallets[0].ToLower()}");
            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"After: {pallets[0].ToLower()}");

            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }


            // string[] pallets = ["B14", "A11", "B12", "A13"];
            // Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 6);
            // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            // pallets[4] = "C01";
            // pallets[5] = "C02";

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }


            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }


        public void StringFormatting()
        {
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");

            //more decimal points
            Console.WriteLine($"Measurement: {measurement:N4} units");

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            //more decimal places
            Console.WriteLine($"Tax rate: {tax:P5}");
        }

    }
}