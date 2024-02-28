using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class SmallEnemy : Enemy
    {

        public override void Update()
        {
            base.Update();
            Console.WriteLine("SmallEnemy Updated");
        }

    }
}
