using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    // Inheritance
    public class Programmer : Creator
    {
        public override void Create()
        {
            if(base.Creativity >= 70 && base.Energy >= 80)
            {
                this.BrainStormSolutions();
                this.OptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                // Exception Handling
                throw new Exception("Cannot create a program. Out of ideas or tired.");
            }
            
        }

        // Encapsulation
        private void BrainStormSolutions()
        {
            base.Creativity -= 15;
            base.Energy -= 10;
            Console.WriteLine("Brainstorming Solutions....");
        }

        private void OptimalSolution()
        {
            base.Creativity -= 5;
            base.Energy -= 5;
            Console.WriteLine("Picking Optimal Solution....");
        }

        private void WriteCode()
        {
            base.Creativity -= 7;
            base.Energy -= 5;
            Console.WriteLine("Writing Code....");
        }

        private void TestCode()
        {
            base.Creativity -= 3;
            base.Energy -= 3;
            Console.WriteLine("Testing Code...");
        }
    }
}
