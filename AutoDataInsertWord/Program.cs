using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Threading;


namespace AutoDataInsertWord
{
    class Program
    {
        static Timer timer = null;
       
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                timer = new Timer(new TimerCallback(TimerCallBack), null, 0, 100000);
            }

           

            //DataInWord inWord = new DataInWord();
            //if (inWord.MyWord(DateTime.Now.ToString(), false, true) == 0)
            //{
            //    Console.WriteLine("OK");
            //}




        }

        public static void TimerCallBack(object o)
        {
           
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss:fff"));
        }

    }
}
