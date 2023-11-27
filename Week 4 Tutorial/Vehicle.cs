using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab
{
    public abstract class Vehicle
    {
        public VehicleType Type;
        public float EngineCapacity;

        //public Vehicle(VehicleType type, float engineCapacity )
        //{
        //    EngineCapacity = engineCapacity;
        //    Type = type;
        //}
        public abstract void GetVehicleDetail();
    }

    public class Motorcycle : Vehicle
    {
        public bool HasABS;
        public Motorcycle( float _engineCapacity, bool _hasAbs)
        {
            HasABS = _hasAbs;
            EngineCapacity = _engineCapacity;
            Type = VehicleType.Motorcycle;
        }

        //private string _abs;

        public override void GetVehicleDetail()
        {
            //string _abs = HasABS ? "has" : "doesn't have";
            //Console.WriteLine($"It is a  and it {_abs} abs");
            Console.WriteLine($"Vehicle = {Type}, Engine Capacity = {EngineCapacity}, ABS = {HasABS}");
        }
    }
    public class Bus : Vehicle
    {
        public int SeatCapacity;
        public int FuelTankCapacity;
        public Bus( float _engineCapacity, int _seatCapacity, int _fuelTankCapacity)
        {
            SeatCapacity = _seatCapacity;
            FuelTankCapacity = _fuelTankCapacity;
            EngineCapacity = _engineCapacity;
            Type = VehicleType.Bus;
        }
        public override void GetVehicleDetail()
        {
            Console.WriteLine($"Vehicle = {Type}, Engine Capacity = {EngineCapacity}, Total seats = {SeatCapacity}, Fuel tank = {FuelTankCapacity}");
        }
    }


    public class MainClass
    {
        public static void Main(string[] args)
        {
            Bus bus1 = new Bus(1400, 40, 40);
            bus1.GetVehicleDetail();
        }
    }

}
