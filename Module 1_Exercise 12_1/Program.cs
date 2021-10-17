using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас мы будем работать с окружностью.");
            Console.WriteLine("Введите радиус окружности.");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circelLen = Math.Round(WorkWithCircle.CircleLength(radius), 3);
            Console.WriteLine("Длина окружности с таким радиусом равна: {0}", circelLen);

            double circelArea = Math.Round(WorkWithCircle.CircleArea(radius), 3);
            Console.WriteLine("Площадь круга с таким радиусом равна: {0}", circelArea);

            Console.WriteLine("А теперь мы выясним, принадлежит ли точка с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.");

            Console.WriteLine("Введите координату X точки, которую собираемся проверять.");
            double pt_X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки, которую собираемся проверять.");
            double pt_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату X центра окружности.");
            WorkWithCircle.centerCircle_X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y центра окружности.");
            WorkWithCircle.centerCircle_Y = Convert.ToDouble(Console.ReadLine());

            if (WorkWithCircle.CheckPoint(radius, pt_X, pt_Y))
            {
                Console.WriteLine("Да, точка принадлежит кругу.");
            }
            else
            {
                Console.WriteLine("Нет, точка кругу не принадлежит.");
            }
            
            Console.WriteLine("Спасибо за внимание!");
            Console.ReadKey();
        }

        static class WorkWithCircle
        {
            public static double centerCircle_X;
            public static double centerCircle_Y;

            public static double CircleLength(double radius)
            {
                return 2 * Math.PI * radius;
            }
            public static double CircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }
            public static bool CheckPoint(double radius, double ptCh_X, double ptCh_Y)
            {
                double ptCheckCorrect_X = ptCh_X - centerCircle_X;
                double ptCheckCorrect_Y = ptCh_Y - centerCircle_Y;
                double radiusNeeded = Math.Sqrt(ptCheckCorrect_X * ptCheckCorrect_X + ptCheckCorrect_Y * ptCheckCorrect_Y);
                if (Math.Round(radiusNeeded, 3) == radius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
