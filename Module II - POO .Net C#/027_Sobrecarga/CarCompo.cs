using System;
namespace HelloWorld 
{ 

    // Dicho de otro modo, en esta relación, no tiene sentido que la clase Wheel viva de forma independiente sin formar parte de la clase Car.
    // También diremos que al eliminar la clase Car, eliminaremos por lo tanto, la clase Wheel, ya que la relación entre ambas clases, es estrech

    public class Car
    {
        public Wheel wheel = new Wheel();

        public void AddWheelToWheels()
        {
            wheel.AddWheel();
        }

        public int CheckWheels()
        {
            return wheel.CheckWheels();
        }
    }

    public class Wheel
    {
        private int _wheels;

        public void AddWheel()
        {
            _wheels += 1;
        }

        public int CheckWheels()
        {
            return _wheels;
        }
    }

}
