using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint5.TaskReview.V18.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint5.TaskReview.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Иванов Я.Д.  | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #Ревью                                                          *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Иванов Я.Д. | ПКТб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask7V18.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5  и      *");
            Console.WriteLine("* скопировать в неё файл). в котором есть набор символьных данных.        *");
            Console.WriteLine("* Заменить н на нн и сохранить полученный результат                       *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V18.txt.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string pathsave = $@"C:\DataSprint5\OutPutDataFileTask7V18.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathsave = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат находится в файле: " + pathsave);
            Console.ReadKey();
        }
    }
}