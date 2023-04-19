using System;
namespace HelloWorld 
{ 

    public class Car{

        public Wheel wheel = new Wheel();

        public void AddWheelToWheels(){
            wheel.AddWheel();
        }

        public void RemoveWheelToWheels(){
            wheel.RemoveWheel();
        }
        public int CheckWheelsCar(){
            return wheel.CheckWheels();
        }
    }

    public class Wheel{
        private int _wheels;

        public void AddWheel(){
            _wheels += 1;
        }

        public void RemoveWheel(){
            _wheels -= 1;
        }

        public int CheckWheels(){
            return _wheels;
        }
    }
}