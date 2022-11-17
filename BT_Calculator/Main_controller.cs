using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BT_Calculator
{
    public class Main_controller
    {
        #region Method

        public long Addition(string[] data)
        {
            long res = 0;
            foreach (var item in data)
            {
                var i_item = Convert.ToInt64(item);
                res += i_item;
            }

            return res;
        }

        public long Subtraction(string[] data)
        {
            long res = int.Parse(data[0]);
            for (int index = 1; index < data.Length; ++index)
            {
                var i_item = Convert.ToInt64(data[index]);
                res -= i_item;
            }

            return res;
        }

        public long Multiplication(string[] data)
        {
            long res = 1;
            foreach (var item in data)
            {
                var i_item = Convert.ToInt64(item);
                res *= i_item;
            }

            return res;
        }

        public void Division(string[] data)
        {
            double res = Convert.ToDouble(data[0]);
            double temp = Convert.ToDouble(data[1]);

            if (temp == 0)
            {

                Console.WriteLine("Cant divide by 0");
                return;
            }

            Console.WriteLine(res / temp);
        }

        public void Print(double text)
        {
            Console.WriteLine("Result: " + text);
        }

        public bool CheckOpID(string opid)
        {
            if (opid == null) return false;
            for (int index = 0; index < opid.Length; ++index)
            {
                if (opid[index] < '0' || opid[index] > '9') return false;
            }
            return true;
        }

        public void Input(ref int option)
        {
            StartPoint:
            try
            {
                string optionID = Console.ReadLine();
                optionID = optionID.Trim();
                
                while (true)
                {
                    while (!CheckOpID(optionID))
                    {
                        Console.Write("Wrong input! Please choose again: ");
                        optionID = Console.ReadLine();
                        optionID = optionID.Trim();
                    }

                    option = Convert.ToInt32(optionID);
                    if (option >= 1 && option <= 5) break;
                }
            }
            catch (Exception e)
            {
                goto StartPoint;
            }
        } 

        #endregion


    }
}
