using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PersonInfo
{
    public class Program
    {

        static void Main(string[] args)
        {
            var countries = ReadJson<Country>(@"C:\Users\user\source\repos\PersonInfo\PersonInfo\Countries.json");
            var citizens = ReadJson<Citizen>(@"C:\Users\user\source\repos\PersonInfo\PersonInfo\Citizen.json");

            foreach (var country in countries)
            {
                country.WriteToConsole();
            }

            foreach (var citizen in citizens)
            {
                citizen.WriteToConsole();
            }

            //создаём счёт у первого гражданина из списка
            citizens[0].BankAccount = new Account(50);
            //подключаем к счёту оповещение
            citizens[0].BankAccount.Notify += Messages.SendMessage;
            citizens[0].BankAccount.PutFunds(20);
            citizens[0].BankAccount.Notify -= Messages.SendMessage;

            citizens[0].WriteToConsole();
            Console.WriteLine(citizens[0].BankAccount.Sum);

            //сериализуем гражданинов обратно в файл
            var citizenFileContent = JsonSerializer.Serialize(citizens);
            File.WriteAllText(@"C:\Users\user\source\repos\PersonInfo\PersonInfo\Citizen.json", citizenFileContent);
        }

        private static List<TResult> ReadJson<TResult>(string path)
        {
            var fileContent = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<TResult>>(fileContent);
        }

    }
}
