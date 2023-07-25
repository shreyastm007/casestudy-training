using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec1 {
    public interface IOpenClosed {
        public void engine();
        public void tyres();
        public void brake();
    }

    public class car : IOpenClosed {

        public void CarColor() {
            Console.WriteLine(" blue car");
        }
        public void brake() {
            Console.WriteLine("i stop the car");
        }

        public void engine() {
            Console.WriteLine("starts the car");
        }

        public void tyres() {
            Console.WriteLine("Im round....I help the car to move");
        }
    }
}
