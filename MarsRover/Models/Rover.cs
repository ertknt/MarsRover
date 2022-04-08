using MarsRover.Interfaces;
using System;
using System.Linq;

namespace MarsRover.Models
{
    public class Rover : IMove, ITurn
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public char Direction { get; set; }

        public void Move(double radian)
        {
            int cos = Convert.ToInt32(Math.Cos(Math.PI * radian));
            int sin = Convert.ToInt32(Math.Sin(Math.PI * radian));

            CoordinateX += cos;
            CoordinateY += sin;
        }
        public void Turn(char command, double radian)
        {
            switch (command)
            {
                case 'L':
                    radian += 0.5;
                    break;

                case 'R':
                    radian -= 0.5;
                    break;
            }
            radian = Helper.Helper.TryConvertRadianToBaseMeasure(radian);
            Direction = Helper.Helper.Directions.FirstOrDefault(item => item.Value == radian).Key;
        }
    }
}
