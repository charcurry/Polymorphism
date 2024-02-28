using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Enemy : Entity
    {
        public override void Update()
        {
            base.Update();
            Console.WriteLine("Enemy Updated");
        }

    }
}
