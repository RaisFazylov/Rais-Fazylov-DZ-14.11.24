using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Rais_Fazylov_DZ_14._11._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            // 1. Выведите на экран информацию о каждом типе данных в виде:
            // Тип данных – максимальное значение – минимальное значение
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine("Задание 2");
            // Напишите программу, в которой принимаются данные пользователя в виде имени,
            // города, возраста и PIN - кода.Далее сохраните все значение в соответствующей
            // переменной, а затем распечатайте всю информацию в правильном формате.
            Console.Write("имя: ");
            string name = Console.ReadLine();
            Console.Write("город: ");
            string city = Console.ReadLine();
            Console.Write("возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("код: ");
            string code = Console.ReadLine();
            Console.WriteLine("\n--- Ваша информация ---");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Kод: {code}");
            Console.WriteLine("Задание 3");
            // Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            // строчные.
            Console.Write("Введите строку: ");
            char[] chars = Console.ReadLine().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
                else if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
            }
            Console.WriteLine(new string(chars));
            Console.WriteLine("Задание 5");
            // Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            // нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            // покрыла расходы на ваш отпуск.Вам будет предоставлена стандартная цена(normPrice),
            // скидка в Duty Free(salePrice) и стоимость отпуска(holidayPrice).Например, если бутылка
            // обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10 %, вы
            // сэкономите 1 фунт стерлингов на каждой бутылке.Если ваш отпуск стоит 500 фунтов
            // стерлингов, ответ, который вы должны вернуть, будет 500.Все входные данные будут
            // целыми числами.Пожалуйста, верните целое число.Округлить в меньшую сторону.
            Console.Write("Введите стандартную цену: ");
            int norm = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free): ");
            int sale = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            int holiday = int.Parse(Console.ReadLine());
            int bottles = Calculate(norm, sale, holiday);
            Console.WriteLine($"Необходимо купить {bottles} бутылок виски.");
        }
        static int Calculate(int norm, int sale, int holiday)
        {
            int savings = norm * sale / 100;
            int bottles = holiday / savings;
            return bottles;
        }
    }
}
