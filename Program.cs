namespace PP_Simulator._1;

internal class Program
{
    static void Main(string[] args)
    {
        static void Lab5b()
        {
            try
            {
                var map = new PP_Simulator._1.Maps.SmallSquareMap(10);

                var point = new Point(5, 5);
                Console.WriteLine(map.Exist(point)); // True
                Console.WriteLine(map.Next(point, Direction.Up)); // (5, 6)
                Console.WriteLine(map.Next(point, Direction.Down)); // (5, 4)
                Console.WriteLine(map.Next(point, Direction.Left)); // (4, 5)
                Console.WriteLine(map.Next(point, Direction.Right)); // (6, 5)

                var edgePoint = new Point(9, 9);
                Console.WriteLine(map.Next(edgePoint, Direction.Up)); // (9, 9) - Out of bounds

                var diagonalPoint = new Point(8, 8);
                Console.WriteLine(map.NextDiagonal(diagonalPoint, Direction.Right)); // (9, 7)
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
        }

        Lab5b();
    }
}

