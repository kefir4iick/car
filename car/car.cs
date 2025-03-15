using System;

namespace Nyashka
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        void Accelerate(int speed);
    }

    class Car
    {
        public void TurnOn()
        {
            Console.WriteLine("turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("turn off");
        }

        public void SetSpeed(int speed)
        {
            Console.WriteLine($"speed: {speed}");
        }
    }

    class CarAdapter : IVehicle
    {
        private readonly Car _car;

        public CarAdapter(Car car)
        {
            this._car = car;
        }

        public void Start()
        {
            _car.TurnOn();
        }

        public void Stop()
        {
            _car.TurnOff();
        }

        public void Accelerate(int speed)
        {
            _car.SetSpeed(speed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            IVehicle vehicle = new CarAdapter(car);

            Console.WriteLine("usage car with adapter");
            vehicle.Start();
            vehicle.Accelerate(200);
            vehicle.Stop();
        }
    }
}
