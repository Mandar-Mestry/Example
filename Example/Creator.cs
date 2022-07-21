using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    // abstract class
    public abstract class Creator
    {
        // access modifiers
        private int _creativity = 100;
        private int _energy = 100;

        public int Creativity
        {
            // Use of get and set properties for returning and assigning value respectively
            get { return _creativity; }
            set 
            {
                // Conditional Statements
                if (value >=0 && value <= 100)
                {
                    _creativity = value;
                }
                else
                {
                    //Exception Handling
                    throw new Exception("Creativity Level can only be a value between 0 to 100");
                }
            }
        }

        public int Energy
        {
            // Use of get and set properties
            get { return _energy; }
            set
            {
                // Conditional Statements
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    //Exception Handling
                    throw new Exception("Energy Level can only be a value between 0 to 100");
                }
            }
        }
        
        // abstract method
        public abstract void Create();
    }
}
