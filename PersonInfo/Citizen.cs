using System;

namespace PersonInfo
{
    public class Citizen : People
    {
        public Country BirthPlace { get; set; }
        public int CountryCode { get; set; }
        public long Passport { get; set; }
        public Account BankAccount { get; set; }



        public override void WriteToConsole()
        {
            Console.WriteLine("Age:{0},\tSex:{1},\tBirthPlace:{2},\tCountryCode:{3},\tPassport:{4}",Age,Sex,BirthPlace,CountryCode,Passport);
        }
    }
}
