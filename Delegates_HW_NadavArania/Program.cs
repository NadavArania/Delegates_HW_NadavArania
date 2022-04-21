using System;

namespace Delegates_HW_NadavArania
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator sc = new SimpleCalculator();
            AtomicCalculator ac = new AtomicCalculator();
            ac.GetNumberFromUser += sc.NumberGetter;
            ac.MenuPrinter += sc.PrintMenu;
            ac.GetUserChoice += sc.GetUserChoice;
            ac.Calculate += sc.Calculate;
            ac.ResultPrinter += sc.PrintResultNicely;
            ac.Run();
        }
    }
}
