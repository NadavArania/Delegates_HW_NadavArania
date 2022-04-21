using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_HW_NadavArania
{
    public class AtomicCalculator
    {
        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }

        public void Run()
        {
            GetNumberFromUser?.Invoke();
            MenuPrinter?.Invoke();
            GetUserChoice?.Invoke();
            Calculate?.Invoke(20, 15, 4);
            ResultPrinter?.Invoke(23d);
        }
    }
}
