﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Luggage_sorting.Interfaces
{
    public interface IPlane
	{
        public string PlaneId { get; }
        public string Airline {  get; }
        public string PlaneModel { get; }
        public string FlightId { get; } 
        public string DepartureTime { get; set; }
        public uint WeightLimit { get; }
        public uint TotalWeight { get; set; }
        public ushort Seats { get; set; }


        void DepartPlane();
	}
}
