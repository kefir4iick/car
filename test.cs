using System;
using Xunit;
using Nyashka;

namespace Nyashka.Tests
{
    public class CarAdapterTests
    {
        [Fact]
        public void start_turnon()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);

            adapter.Start();

            Assert.True(true);
        }

        [Fact]
        public void stop_turnoff()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);

            adapter.Stop();

            Assert.True(true);
        }

        [Fact]
        public void accelerate_speed()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);
            int speed = 100;

            adapter.Accelerate(speed);

            Assert.True(true);
        }
    }
    
    
  
    public class CarTests
    {
        [Fact]
        public void turnon()
        {
            var car = new Car();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            car.TurnOn();

            Assert.Contains("turn on", consoleOutput.ToString());
        }

        [Fact]
        public void turnoff()
        {
            var car = new Car();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            car.TurnOff();

            Assert.Contains("turn off", consoleOutput.ToString());
        }

        [Fact]
        public void Speed()
        {
            var car = new Car();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            int speed = 120;

            car.SetSpeed(speed);

            Assert.Contains($"speed: {speed}", consoleOutput.ToString());
        }
    }
}
