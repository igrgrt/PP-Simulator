using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Simulator._1.Maps
{
    public class SmallSquareMap : Map
    {
        public int Size { get; }

        public SmallSquareMap(int size)
        {
            if (size < 5 || size > 20)
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be between 5 and 20.");

            Size = size;
        }

        public override bool Exist(Point p)
        {
            return p.X >= 0 && p.X < Size && p.Y >= 0 && p.Y < Size;
        }

        public override Point Next(Point p, Direction d)
        {
            var nextPoint = p.Next(d);
            return Exist(nextPoint) ? nextPoint : p;
        }

        public override Point NextDiagonal(Point p, Direction d)
        {
            var nextPoint = p.NextDiagonal(d);
            return Exist(nextPoint) ? nextPoint : p;
        }
    }
}

