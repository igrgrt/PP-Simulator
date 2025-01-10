namespace PP_Simulator._1;

internal class Program
{
    static void Main(string[] args)
    {
        static void Lab5a()
        {
            try
            {
                var rect1 = new Rectangle(10, 10, 20, 20);
                Console.WriteLine(rect1);

                var rect2 = new Rectangle(new Point(20, 20), new Point(10, 10));
                Console.WriteLine(rect2);

                var rect3 = new Rectangle(10, 10, 10, 20); // Exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            var rect = new Rectangle(10, 10, 20, 20);
            var p1 = new Point(15, 15);
            var p2 = new Point(25, 25);

            Console.WriteLine($"Rectangle contains {p1}: {rect.Contains(p1)}");
            Console.WriteLine($"Rectangle contains {p2}: {rect.Contains(p2)}");
        }
        Lab5a();
    }
}

