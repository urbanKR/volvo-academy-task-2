﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;

namespace VolvoAcademyTask2
{
    internal abstract class Vehicle
    {
        public int Id { get; set; }
        public VehicleBrand Brand { get; set; }
        public VehicleModel Model { get; set; }
        public int ManufactureYear  { get; set; }
        public Color Color { get; set; }
        public decimal Price { get; set; }
        public string RegistrationNumber { get; set; }
        public ComfortClass ComfortClass { get; set; }
        public abstract bool ExceedsTenure { get; }
        public abstract int CalculateCurrentValue();
        public abstract int RequiresMaintenanceIn();
    }
}
