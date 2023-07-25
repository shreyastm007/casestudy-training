using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec1 {
    public interface BearCleaner {
        void WashTheBear();
    }

    public interface BearFeeder {
        void FeedTheBear();
    }

    public interface BearTrainer {
        void TrainTheBear();
    }

    public class BearCareTaker:BearCleaner, BearFeeder {

    public void WashTheBear() {
            Console.WriteLine("I wash the bear");
    }

    public void FeedTheBear() {
            Console.WriteLine("I feed the bear");
    }

        public class Trainer : BearTrainer {
            public void TrainTheBear() {
                Console.WriteLine("I Train the bear");
            }
        }
    }
}
