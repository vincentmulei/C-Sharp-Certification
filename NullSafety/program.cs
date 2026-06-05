namespace NullSafety
{
    record FooBar(int Id, string Name);

    public class NullSafetyImplementation
    {
        public void Run()
        {
            // FooBar fooBar = null;           

            // // Check for null
            // if (fooBar is not null)
            // {
            //     _ = fooBar.ToString();
            // }


            int? third = default; 
            int? fourth = new();
            DateTime? dateTime = default;
            DateTime? dateTime2 = new();

            Console.WriteLine($"dateTime: {dateTime}, dateTime2: {dateTime2}, third: {third}, fourth: {fourth}");   

        }
        
    }
    
}