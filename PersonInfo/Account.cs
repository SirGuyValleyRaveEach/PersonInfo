using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Account //банковский счёт гражданина, класс был создан для изучения событий и делегатов
    {
        public int Sum { get; private set; }
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Account(int sum)
        {
            Sum = sum;
        }

        public Account()
        {
        }

        public void PutFunds (int sum)
        {
            Sum += sum;
            Notify?.Invoke($"funds have been credited to the account\nYour balance is {Sum}");
        }

        public void WithdrawFunds (int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"funds are withdrawn from the account\nYour balance is {Sum}");
            }
            else
                Notify?.Invoke($"Insufficient funds\nYour balance is {Sum}");
        }
    }
}
