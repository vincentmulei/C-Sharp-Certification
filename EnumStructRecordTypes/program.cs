namespace enumstructrecordtypes
{
    enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Order {OrderId} status updated to {Status}");
        }
    }

    public class WorkwithEnum
    {
        public enum DaysOfTheWeek : ushort
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        public void DisplayEnumValues()
        {
            DaysOfTheWeek day = DaysOfTheWeek.Wednesday;
            Console.WriteLine($"The day of the week for the value 3 is: {day}");
        }

        public void ValidateEnumValue(ushort value)
        {
            if (Enum.IsDefined(typeof(DaysOfTheWeek), value))
            {
                DaysOfTheWeek day = (DaysOfTheWeek)value;
                Console.WriteLine($"The day of the week for the value {value} is: {day}");
            }
            else
            {
                Console.WriteLine($"The value {value} is not a valid day of the week.");
            }
        }

        public void IsWeekend(ushort value)
        {
            DaysOfTheWeek day = (DaysOfTheWeek)value;
            if (day == DaysOfTheWeek.Saturday || day == DaysOfTheWeek.Sunday)
            {
                Console.WriteLine($"{day} is a weekend.");
            }
            else
            {
                Console.WriteLine($"{day} is a weekday.");
            }
        }

        public void updateOrderStatus()
        {
            Order order = new Order { OrderId = 123, Status = OrderStatus.Pending };
            Console.WriteLine($"Initial order status: {order.Status}");
            order.UpdateStatus(OrderStatus.Shipped);
            order.UpdateStatus(OrderStatus.Delivered);
        }
    }
 
    public struct Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area => width * height;
    }
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}