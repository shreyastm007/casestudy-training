using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec1 {
   public  class DIP {
        public void humanCharacter() {
            Console.WriteLine("i can walk and talk");
        }

        public void animalChacter() {
            Console.Write("i can kill and hunt");
        }
    }

    public class Doctor : DIP {

    }

    public class Teacher : DIP {

    }

    public class Tiger : DIP {

    }
}
