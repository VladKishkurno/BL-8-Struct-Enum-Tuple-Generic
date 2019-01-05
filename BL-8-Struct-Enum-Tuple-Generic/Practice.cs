using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        class Rectangle2D
        {
            public int weight;
            public int height;

            public Coordinate coord;

            public Rectangle2D (int weight, int height, int coordX, int coordY)
            {
                this.weight = weight;
                this.height = height;
                this.coord = new Coordinate(coordX, coordY);
            }

            public Rectangle2D(int sideSquare, int coordX, int coordY)
            {
                this.height = this.weight = sideSquare;
                this.coord = new Coordinate(coordX, coordY);
            }

            public override string ToString()
            {
                return $"{this.weight} {this.height} {this.coord}";
            }
        }

        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        public static void Lb8_P1_3()
        {
            Rectangle2D rectangle = new Rectangle2D(5, 10, 3, 7);
            Console.WriteLine(rectangle);
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static void Lb8_P2_3()
        {
            Rectangle2D[] massSquare = new Rectangle2D[100];
            for(int i = 0; i < massSquare.Length; i++)
            {
                massSquare[i] = new Rectangle2D(random.Next(10), random.Next(10), random.Next(10));
            }

            List<Rectangle2D> listSquare = new List<Rectangle2D>();
            int numDublicate = 0;

            foreach(var item in massSquare)  // для структуры работает, так как сравниваем по значению, для класса не работает
            {
                if (!listSquare.Contains(item))
                {
                    listSquare.Add(item);
                }
                else numDublicate++;
            }

            Console.WriteLine(numDublicate);

            var listSquare2 = new List<Rectangle2D>();
            int numDublicate2 = 0;
            int flag = 0;

            for (int i = 0; i < massSquare.Length; i++)  // работает для структуры и класса, так как сравниваем каждое поле
            {
                foreach (var item in listSquare2)
                {
                    if (massSquare[i].height == item.height && massSquare[i].coord.x == item.coord.x && massSquare[i].coord.y == item.coord.y)
                    {
                        numDublicate2++;
                        flag = 1;
                        break;
                    }
                    else flag = 0;
                   
                }
                if (flag == 0)
                {
                    listSquare2.Add(massSquare[i]);
                }
            }

            Console.WriteLine(numDublicate2);

        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {            
        }
    }
}
