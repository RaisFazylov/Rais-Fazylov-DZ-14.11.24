using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab
{
    public enum AccType
    {
        Current,
        Savings
    }
    public struct BankAccount
    {
        public string AccNum;
        public AccType1 AccType1;
        public decimal Balance;
        public override string ToString()
        {
            return $"Номер счета: {AccNum}, Тип счета: {AccType1}, Баланс: {Balance:C}";
        }
    }
    public enum AccType1
    {
        Current,
        Savings
    }
    public enum Univer
    {
        КГУ,
        КАИ,
        КХТИ
    }
    public struct Employee
    {
        public string Name;
        public Univer Uni;
        public override string ToString()
        {
            return $"Имя: {Name}, ВУЗ: {Uni}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            // Создать перечислимый тип данных отображающий виды банковского
            // счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей
            // значение и вывести это значение на печать.
            AccType myAccType = AccType.Savings;
            Console.WriteLine($"Тип банковского счета: {myAccType}");
            Console.WriteLine("Задание 2");
            // Создать структуру данных, которая хранит информацию о банковском
            // счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            // значениями и напечатать результат.
            BankAccount myAccount = new BankAccount
            {
                AccNum = "666",
                AccType1 = AccType1.Savings,
                Balance = 666
            };
            Console.WriteLine(myAccount);
            Console.WriteLine("Задание 3");
            // Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            // структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и
            // распечатать.
            Employee em = new Employee
            {
                Name = "Раис Фазылов",
                Uni = Univer.КГУ
            };
            Console.WriteLine(em);
        }
    }
}
