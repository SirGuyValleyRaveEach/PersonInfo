using System;

namespace PersonInfo
{
    public class People
    {
        public int Age { get; protected set; }
        public string Sex { get; protected set; }
        public virtual void WriteToConsole() //метод переопеделен в классе Citizen
        {
            Console.WriteLine("Age:{0},\tSex:{1}", Age, Sex);
        }
    }
}
