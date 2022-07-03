namespace CarParking
{
    class Vehicle
    {
        public double ThreeHoursRate { get; set; }
        public double ExtraHoursRate { get; set; }
        public double MaxFeeForOneDay { get; set; }

        public virtual double CalculateParkingFee(double hours)
        {
            double fee=0.00;
            if (hours <= 3)
                fee =ThreeHoursRate;
            else if (hours >3)
            {
                fee = ThreeHoursRate + (hours - 3) * ExtraHoursRate;
                if (fee > MaxFeeForOneDay)
                    fee = MaxFeeForOneDay;
            }
            return fee;
        }

    }
}
