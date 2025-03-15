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
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            
            adapter.Start();
            Console.Out.Flush();

            Assert.Contains("turn on", consoleOutput.ToString());

            Console.SetOut(original);
            consoleOutput.Dispose();
        }

        [Fact]
        public void stop_turnoff()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            
            adapter.Stop();
            Console.Out.Flush();

            Assert.Contains("turn off", consoleOutput.ToString());

            Console.SetOut(original);
            consoleOutput.Dispose();
        }

        [Fact]
        public void accelerate_speed()
        {
            var car = new Car();
            var adapter = new CarAdapter(car);
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            int speed = 120;
            adapter.Accelerate(speed);
            Console.Out.Flush();

            Assert.Contains($"speed: {speed}", consoleOutput.ToString());

            Console.SetOut(original);
            consoleOutput.Dispose();
        }
    }
    
    
  
    public class CarTests
    {
        [Fact]
        public void turnon()
        {
            var car = new Car();
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
    
            car.TurnOn();
            Console.Out.Flush();
    
            Assert.Contains("turn on", consoleOutput.ToString());
    
            Console.SetOut(original);
            consoleOutput.Dispose();
        }
        
        [Fact]
        public void turnoff()
        {
            var car = new Car();
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
    
            car.TurnOff();
            Console.Out.Flush();
    
            Assert.Contains("turn off", consoleOutput.ToString());
    
            Console.SetOut(original);
            consoleOutput.Dispose();
        }

        [Fact]
        public void Speed()
        {
            var car = new Car();
            var original = Console.Out;

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
    
            int speed = 120;
            car.SetSpeed(speed);
            Console.Out.Flush();
    
            Assert.Contains($"speed: {speed}", consoleOutput.ToString());
    
            Console.SetOut(original);
            consoleOutput.Dispose();
        }
    } 
}
