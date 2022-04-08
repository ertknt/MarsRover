using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Helper
{
    public static class Helper
    {
        public static Dictionary<char, double> Directions = new Dictionary<char, double>()
        {
            {'E', 0 },
            {'N', 0.5 },
            {'W', 1 },
            {'S', 1.5 }
        };

        //esas ölçüye çevrilir çünkü 'Directions Dictionary' esas ölçülere göre tanımlandı.
        public static double TryConvertRadianToBaseMeasure(double radian)
        {
            while (radian < 0)
                radian += 2; //açı 0'dan büyük olmalı
            return radian % 2;
        }
    }
}
