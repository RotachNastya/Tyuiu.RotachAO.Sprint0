using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RotachAO.Sprint0.Task3.V0.Lib
{
    public static class DataService
    {
        ///
        ///модификаторы доступа (первое слово на 9й строке, это оно)
        ///public - торчит наружу, доступен всем и везде
        ///private - только сам для себя доступен
        ///protected - доступен наследникам класса и не торчит наружу
        ///internal - доступен только внутри библиотеки классов. 
        ///
        
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}