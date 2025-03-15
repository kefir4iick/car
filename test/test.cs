using System;
using System.IO;
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
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            adapter.Start();

            Assert.Contains("turn on", consoleOutput.ToString());
        }

        [Fact]
        public void stop_turnoff()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            adapter.Stop();

            Assert.Contains("turn off", consoleOutput.ToString());
        }

        [Fact]
        public void accelerate_speed()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            int speed = 120;

            adapter.Accelerate(speed);

            Assert.Contains($"speed: {speed}", consoleOutput.ToString());
        }
    }
    
    
  
    public class CarTests
    {
        [Fact]
        public void turnon()
        {
            var car = new Car();
            var original = Console.Out;

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
    
                car.TurnOn();
                Console.Out.Flush();
    
                Assert.Contains("turn on", consoleOutput.ToString());
            }
    
            Console.SetOut(original);
        }

        [Fact]
        public void turnoff()
        {
            var car = new Car();
            var original = Console.Out;

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
    
                car.TurnOff();
                Console.Out.Flush();
    
                Assert.Contains("turn off", consoleOutput.ToString());
            }
    
            Console.SetOut(original);
        }

        [Fact]
        public void Speed()
        {
            var car = new Car();
            var original = Console.Out;

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
    
                int speed = 120;
                car.SetSpeed(speed);
                Console.Out.Flush();
    
                Assert.Contains($"speed: {speed}", consoleOutput.ToString());
            }
    
            Console.SetOut(original);
        }
    }
}
