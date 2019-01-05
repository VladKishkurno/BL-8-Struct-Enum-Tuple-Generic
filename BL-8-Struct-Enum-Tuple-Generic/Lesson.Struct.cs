using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Lesson
    {

        public static void StructExsample2()
        {
            var array = new Coordinate[] { new Coordinate (15, 20) };
            var listCoordinate = new List<Coordinate> { (new Coordinate(20, 25)) };

            var arrayElement1 = array[0];
            var listElement1 = listCoordinate[0];

            arrayElement1.y = 1;
            listElement1.y = 2;

            Console.WriteLine(array[0]);
            Console.WriteLine(listCoordinate[0]);
        }
        public static void StructExample()
        {
            //Coordinate coord0 = new Coordinate(0, 0);
            //Coordinate coord1;
            //Coordinate coord2;

            //coord1.x = 15;
            //coord1.y = 15;

            //coord2 = coord1;

            //coord2.y = 10;
            //Console.WriteLine(coord1.Vector());
            //Console.WriteLine(coord2.Vector());
            StructExsample2();
        }
    }

    public struct Color
    {
        public string rgb;
        public string name;
    }

    public struct Coordinate
    {
        public int x;
        public int y;

        public double lenght
        {
            get
            {
                return Vector();
            }
        }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Vector()
        {
            var lenght = Math.Sqrt(x * x + y * y);
            return lenght;
        }

        public override string ToString()
        {
            return $"{this.x} {this.y}";
        }
    }
}
