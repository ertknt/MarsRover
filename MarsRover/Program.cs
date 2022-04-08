using MarsRover.Models;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            #region Platonun konumunun alınması
            char[] plateauInformations = Console.ReadLine().ToCharArray(); //Beklenen input formatı: 55
            Plateau plateau1 = new Plateau()
            {
                CoordinatX = int.Parse(plateauInformations[0].ToString()),
                CoordinatY = int.Parse(plateauInformations[1].ToString())
            };
            #endregion

            #region Rover 1
            //Rover 1
            string[] rover1Informations = Console.ReadLine().Split(' '); // Beklenen input formatı : 1 2 N

            Rover rover1 = new Rover()
            {
                CoordinateX = int.Parse(rover1Informations[0]),
                CoordinateY = int.Parse(rover1Informations[1]),
                Direction = char.Parse(rover1Informations[2])
            };
            //Instructions for rover 1  Beklenen input formatı : LMLMLMLMM
            string rover1Instructions = Console.ReadLine();

            foreach (var instruction in rover1Instructions)
            {
                double radian = Helper.Helper.Directions[rover1.Direction];

                if (instruction == 'M')
                {
                    rover1.Move(radian);
                }
                else if (instruction == 'L' || instruction == 'R')
                {
                    rover1.Turn(instruction, radian);
                }
            }
            #endregion

            #region Rover 2
            string[] rover2Informations = Console.ReadLine().Split(' '); // Beklenen input formatı : 3 3 E

            Rover rover2 = new Rover()
            {
                CoordinateX = int.Parse(rover2Informations[0]),
                CoordinateY = int.Parse(rover2Informations[1]),
                Direction = char.Parse(rover2Informations[2])
            };

            //Instructions for rover 2  Beklenen input formatı : MMRMMRMRRM
            string rover2Instructions = Console.ReadLine();

            foreach (var instruction in rover2Instructions)
            {
                double radian = Helper.Helper.Directions[rover2.Direction];

                if (instruction == 'M')
                {
                    rover2.Move(radian);
                }
                else if (instruction == 'L' || instruction == 'R')
                {
                    rover2.Turn(instruction, radian);
                }
            }
            #endregion

            #region roverların son pozisyonlarını ekrana yazdırma kısmı
            Console.Write(rover1.CoordinateX + " " + rover1.CoordinateY + " " + rover1.Direction + "\n" + rover2.CoordinateX + " " + rover2.CoordinateY + " " + rover2.Direction);
            Console.ReadLine();
            #endregion
        }
    }
}
