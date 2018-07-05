using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Forces_Assignments
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            //saves input from readline in integers when seperated with a space
            int lenghtSquare = int.Parse(input[0]),
                widthSquare = int.Parse(input[1]),
                brickSize = int.Parse(input[2]);

            int squareSizeX,
                squareSizeY;

            //checks if the lenght divided by the bricksize has no remaining value, if so add 1 extra to the answer at the end
            squareSizeX = lenghtSquare % brickSize == 0? lenghtSquare / brickSize : (lenghtSquare / brickSize) +1;
            squareSizeY = widthSquare % brickSize == 0? widthSquare / brickSize : (widthSquare / brickSize) +1;

            Console.WriteLine(squareSizeX * squareSizeY);
            Console.Read();
        }
    }
}
