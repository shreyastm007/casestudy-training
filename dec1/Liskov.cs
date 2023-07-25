using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec1 {
    public class Liskov {
        public void Parent() {
            Console.WriteLine("Superclass method");
        }
    }

    public class Child : Liskov {
        public void child1() {
            Console.WriteLine("subclass method1");
        }

        public void child2() {
            Console.WriteLine("subclass method2");
        }
    }
}
