﻿using H2_Luggage_sorting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Luggage_sorting.Classes.Models
{
	internal class Passenger : IPassenger
	{
		public string FirstName { get; }
		public string LastName { get; }
		public string PassportNumber { get; }
		public string boarding_pass_number { get; }
	}
}