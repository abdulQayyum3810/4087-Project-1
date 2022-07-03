using System;

namespace CarParking

{
    class Program
    {
        static void Main(string[] args)
        {
            double hours; string vehicleType;
            Console.Write("Enter vehicle type (bus, car, motorbike):  ");
            vehicleType = Console.ReadLine();
            Console.Write("Enter parking hours:  ");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your Parking Fee is: {0}", PrintParkingFee(vehicleType, hours));
        }
        public static double PrintParkingFee(string vehicleType, double hours)
        {
            double fee = 0;
            switch (vehicleType.ToLower())
            {
                case "bus":
                    Bus bus = new Bus();
                    fee = bus.CalculateParkingFee(hours);
                    break;

                case "car":
                    Car car = new Car();
                    fee = car.CalculateParkingFee(hours);
                    break;

                case "motorbike":
                    MotorBike bike = new MotorBike();
                    fee = bike.CalculateParkingFee(hours);
                    break;

            }
            return fee;
        }
    }
}
