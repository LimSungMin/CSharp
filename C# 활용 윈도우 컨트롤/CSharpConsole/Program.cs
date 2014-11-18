using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounterCategory[] categories = PerformanceCounterCategory.GetCategories();
            foreach(var category in categories)
            {
                string[] instanceNames = category.GetInstanceNames();
                foreach (string instanceName in instanceNames)
                {
                    Console.WriteLine(instanceName);
                }
                    
            }
            
        }
    }
}
