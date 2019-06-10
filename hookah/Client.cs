using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hookah
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Список заказов
        /// </summary>
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " (" + DateOfBirth.ToShortDateString() + ")";
        }
    }
}
