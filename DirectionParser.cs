namespace PP_Simulator._1;

internal static class DirectionParser
{
    public static Direction[] Parse(string directions)
    {
        var result = new List<Direction>();

        foreach (var direction in directions)
        {
            char direction_char = char.ToUpper(direction);

            switch (direction_char)
            {
                case 'U': result.Add(Direction.Up); break;
                case 'R': result.Add(Direction.Right); break;
                case 'D': result.Add(Direction.Down); break;
                case 'L': result.Add(Direction.Left); break;
            }
        }

        return result.ToArray();
    }
}
