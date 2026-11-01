using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradebookConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradebookSystem gradebookSystem = new GradebookSystem();

            gradebookSystem.Run();
        }
    }
}
