using System;

namespace PersonInfo
{
    //класс с extension методом для делегатов (в моём случае в классе Account)
    public static class Messages
    {
        public static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
