using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BT_Calculator
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Main_controller _cls = new Main_controller();

        bool running = true;
            while (running) {
                int option = 5;
                Console.WriteLine("This is ur calculator" +
                    "\n1.+" +
                    "\n2.- " +
                    "\n3.*" +
                    "\n4./" +
                    "\n5.Exit\n");
                Console.Write("Choose your option: ");
                //Input
                _cls.Input(ref option);

                if(option == 5) System.Environment.Exit(0);

                //Body
                StartBody:
                Console.Write("Enter 2 values: ");

                var input = Console.ReadLine();
                input = input.Trim();
                var data = input.Split(' ');
                double d_result;

                try
                {
                    switch (option)
                    {
                        case 1:
                            d_result = _cls.Addition(data);
                            _cls.Print(d_result);
                            break;

                        case 2:
                            d_result = _cls.Subtraction(data);
                            _cls.Print(d_result);
                            break;
                       
                        case 3:
                            d_result = _cls.Multiplication(data);
                            _cls.Print(d_result);
                            break;
                        
                        case 4:
                            _cls.Division(data);
                            break;
                    }


                }
                catch(Exception e)
                {
                    goto StartBody;
                }
                //Ask if user want to end the program
                EndPoint:
                Console.Write("Do you want to end the program? Y/N: ");
                var op2 = Console.ReadLine();
                op2 = op2.Trim();
                if (op2 == "Y" || op2 == "y") System.Environment.Exit(0);
            }
        }
        
    }
}
