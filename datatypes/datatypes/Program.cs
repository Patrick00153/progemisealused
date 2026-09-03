namespace datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string e tähaemarkide jada, mis on defineeritu andmetüübiga string
            //andmetüüp toetab ainult true ja false väärtusi
            //mystring on muutuja, mis on defineeritud andmetüübiga string
            //saab sisestada kõike mis on klaviatuuril
            string mystring = "hello, world21!";
            Console.WriteLine(mystring);
            //kirjutage cw ja vajatage tab, et genereerida console. writeline
            string one = "1";
            string two = "2";
            Console.WriteLine(one + two);

            Console.WriteLine("----Täisarvud----");
            //int on täisarvuline andmetüüp, mis toetab ainult täisarve
            int myint = 5;
            int secondint = 10;
            Console.WriteLine(myint);
            //kui kaks int tüüpi muutujat liita siis liidetakse nende vääartused kokku
            Console.WriteLine(myint + secondint);

            Console.WriteLine("----bool----");
            //see on andmetüüp, mis toetab ainult true voi false väärtusi
            bool mybool = true;
            Console.WriteLine(mybool);

            Console.WriteLine("---ujukomaarvud-----");
            //ouble on ujukomaarvuline andmetüüp mis toetab ainult ujukomaarve
            double mydouble = 5.5;
            double myseconddouble = 10.5;
            //kui kaks double tüüpi muutujat liita siis liidetakse nende vaartused kokku 
            Console.WriteLine(mydouble + myseconddouble);
        }
    }
}
