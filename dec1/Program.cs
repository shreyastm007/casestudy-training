using System;
using static dec1.BearCareTaker;

namespace dec1 {
    class Program {
        static void Main(string[] args) {

            //solid
            Carnivorous carnivorous = new Carnivorous();
            carnivorous.Animal1();
            
            //open-closed
            car cr = new car();
            cr.brake();

            //liskov
            Child ch = new Child();
            ch.Parent();

            //interface
            BearCareTaker bc = new BearCareTaker();
            bc.FeedTheBear();
            bc.WashTheBear();
            Trainer tr = new Trainer();
            tr.TrainTheBear();

            //dependency
            Tiger tg = new Tiger();
            tg.animalChacter();
        }
    }
}
