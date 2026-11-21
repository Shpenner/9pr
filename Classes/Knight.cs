using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr.Classes
{
    public class Knight
    {
        public int Health {  get; set; }
        public Knight()
        {
            this.Health = Health;
        }

        private void Attack(int health)
        {
            Health -= 10;
        }
    }
}
