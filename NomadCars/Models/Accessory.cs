using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Daniel
/// </summary>
namespace NomadCars.Models
{
    public enum AccessoryTypes
    {
        BlueTooth,
        BlindSpotMonitor,
        DashCam,
        FrontCamera,
        HeatedSeats,
        ParkingSensor,
        Radio,
        ReverseCamera,
        SatNav,
    }

    /// <summary>
    /// Daniel
    /// </summary>
    public class Accessory
    {
        public int AccessoryID { get; set; }

        [StringLength(255), Required]
        public string Description {get;set;}

        public AccessoryTypes AccessoryType { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
