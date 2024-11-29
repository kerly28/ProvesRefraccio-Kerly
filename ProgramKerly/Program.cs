using Utils2;
using System;

namespace Activitat
{
    public class ProvesRefraccio
    {
        public static void Main(string[] args)
        {
            //genero constants per als missatges
            // missatges d'entrada
            const string inputWidthRec = "Introdueix l'amplada del rectangle:";
            const string inputHeightRec = "Introdueix l'altura del rectangle:";
            const string radiusCercle = "Introdueix el radi del cercle";
            //missatges de sortida
            const string areaRec = "L'àrea del rectangle és:";
            const string circumCerc = "La circumferència del cercle és: ";

            try
            {
                // Invocar els mètodes per calcular l'àrea del rectangle
                Console.WriteLine(inputWidthRec);
                double inputWidthRecValue = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(inputHeightRec);
                double inputHeightRecValue = Convert.ToDouble(Console.ReadLine());

                double area = MyUtils.AreaRec(inputWidthRecValue, inputHeightRecValue);
                Console.WriteLine($"{areaRec}{area}");

                // Invocar el mètode per avaluar l'àrea del rectangle
                string rankArea = MyUtils.EvalueArea((int)area); // Pasamos el área real aquí
                Console.WriteLine(rankArea);

                // Invocar els mètodes per obtenir la circumferència del cercle
                Console.WriteLine(radiusCercle);
                double radiusCercleValue = Convert.ToDouble(Console.ReadLine());
                double circum = MyUtils.CirCerc(radiusCercleValue); // Llamamos al método estático
                Console.WriteLine($"{circumCerc}{circum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}