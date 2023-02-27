using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation_password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            string pass;
            pass = Console.ReadLine();
            Console.WriteLine("chek password");
            Program ob = new Program();
            ob.chekpassword(pass);
            Console.ReadKey();
        }
        void chekpassword(string password)
        {
            int lw = 0;
            int up = 0;
            int di = 0;
            int sc = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 97 && password[i] <= 122)
                    lw = 1;
                else if (password[i] >= 65 && password[i] <= 90)
                    up = 1;
                else if (password[i] >= 48 && password[i] <=57)
                    lw = 1;
                else
                {
                    sc = 1;
                }
            }
            
            if (password.Length < 8)
            {
                Console.WriteLine("please 8 litter write ");
            }
            else if (lw == 1 && up == 1 && di == 1 && sc == 1)
            {
                Console.WriteLine("Very strong");
            }
            else if (lw == 1 && up == 1 && sc == 1)
            {
                Console.WriteLine("strong");
            }
            else if (lw == 1 && up == 1 && di == 1)
            {
                Console.WriteLine("good");
            }
            else if ((lw == 1 && up == 1) || (di == 1 && sc == 1))
            {
                Console.WriteLine("weak");
            }
        }
    }
}
