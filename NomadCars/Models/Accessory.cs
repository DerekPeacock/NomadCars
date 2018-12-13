using System;
using System.Collections.Generic;

/// <summary>
/// Daniel
/// </summary>
namespace NomadCars.Models
{
    public class Accessory
    {
        public int AccessoryID { get; set; }

        public string Description {get;set;}

        public string AccessoryType { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
