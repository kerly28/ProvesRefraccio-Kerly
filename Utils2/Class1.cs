using System;

namespace Utils2
{
    public class MyUtils
    {
        public static double AreaRec(double width, double height)
        {
            return width * height;
        }
        // Metòde per evaluar en quin rang està l'àrea
        public static string EvalueArea(int area)
        {
            return area > 50 ? "L'àrea és més gran de 50" :
                   area > 20 ? "L'àrea és entre 21 i 50" :
                               "L'àrea és menor o igual a 20";
        }
        // Metòde per calcular la circumferència d'un cercle
        public static double CirCerc(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}