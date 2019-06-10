using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hookah
{
    public class Employee
    {
        public string FullName { get; set; }
        /// <summary>
        /// Стаж
        /// </summary>
        public int Experience { get; set; }

        public override string ToString()
        {
            var years = "лет";
            if (Experience == 1)
                years = "год";
            if (Experience > 1 && Experience <= 4)
                years = "года";
            return FullName + " (стаж: " + Experience + " " + years + ")";
        }
    }
}
