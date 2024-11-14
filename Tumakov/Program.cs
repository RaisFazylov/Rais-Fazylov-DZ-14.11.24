using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{   // Создать перечислимый тип данных отображающий виды банковского
    // счета(текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
    // значение и вывести это значение на печать.
    public enum AccType
    {
        Current,
        Savings
    }
    internal class Program

    {
        static void Main(string[] args)
        {
        AccType myAccType = AccType.Savings;
        Console.WriteLine($"Тип счета: {myAccType}");
    }
    }
    // Создать структуру данных, которая хранит информацию о банковском
    // счете – его номер, тип и баланс.Создать переменную такого типа, заполнить структуру
    // значениями и напечатать результат.
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
            BankAccount myAccount = new BankAccount
            {
                AccNum = "123456789",
                AccType1 = AccType1.Savings,
                Balance = 1000.50m
            };
            Console.WriteLine(myAccount);
}
