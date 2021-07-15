using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>() { new Car(), new Airplane()};
            foreach (var transport in transports)
            {
                transport.Move();
            }
        }
    }

    public abstract class Transport
    {
        public abstract void Move();
    }
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Car is driving");
        }
    }
    public class Airplane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Airplane is Flying");
        }
    }


    public class VehicleService
    {
        Transport _transport;
        // Constructor
        public VehicleService(Transport transport)
        {
            _transport = transport;
        }
        public void Move()
        {
            _transport.Move();
        }
    }
}
