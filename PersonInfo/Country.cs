using System;

namespace PersonInfo
{
    public class Country
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public void WriteToConsole()
        {
            Console.WriteLine("Name:{0},\tCode:{1}", Name, Code);
        }

    }
}
