using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleThree
{
    public class daysOfWeek
    {
        public enum dniNedeli : byte
        {
            monday=1,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        
        public enum Semaphore : int
        {
            red=100,
            yellow=200,
            green=300
        }
    }
}
