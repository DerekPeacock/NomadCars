using System;
using System.Collections.Generic;

/// <summary>
/// Zeeshan
/// </summary>
namespace NomadCars.Models
{
    public class Car
    {
        /// <summary>
        /// A specific identification number given to each car being sold. This is so they can be easily identified in the database.
        /// </summary>
        public int CarID { get; set; }
        /// <summary>
        /// The specific colour of the car e.g. black, white or silver.
        /// </summary>
        public string Colour { get; set; }
        /// <summary>
        /// The identifiable number plate on the lower front and rear of the car for official identification purposes. For British cars it is generally laid out as a 'AB12 ABC' manner unless personalised.
        /// </summary>
        public string NumberPlate { get; set; }
        /// <summary>
        /// Vehicle identification number - A specific number for identifying the car. Similar to a fingerprint, no two cars have the same VIN number.
        /// </summary>
        public string VINNo { get; set; }
        /// <summary>
        /// A specific style of build that alters how the cars is labeled e.g. as a hatchback or sedan.
        /// </summary>
        public string BodyType { get; set; }
        /// <summary>
        /// How many miles the car has done in total up to the point of purchase.
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// The manner by which a car may change gear e.g. manually, via the driver, or automatically.
        /// </summary>
        public string TransmissionType { get; set; }
        /// <summary>
        /// The number of previous owners the car has had.
        /// </summary>
        public int NoPreviousOwner { get; set; }
        /// <summary>
        /// The power of the cars acceleration, calculated in the number of seconds it takes for the car to reach 60 miles per hour.
        /// </summary>
        public int AccelerationTo60 { get; set; }
        /// <summary>
        /// A specification to state whether or not the car is sold.
        /// </summary>
        public bool Sold { get; set; }
        /// <summary>
        /// A specification to state if a car has been delivered to the customer or not.
        /// </summary>
        public bool Delivered { get; set; }
        /// <summary>
        /// The grams of CO2 emitted per kilometer, the less the better.
        /// </summary>
        public int CO2Emissions { get; set; }

        public virtual ICollection<Accessory> AccessoriesList { get; set; }

        public virtual ICollection<CarImage> ImagesList { get; set; }
        /// <summary>
        /// The car specification identification number, being used as a foreign key in the car entity. 
        /// This is so that the specifications of an individual car can be identified in the database.
        /// </summary>
        public int CarSpecID { get; set; }

        public virtual CarSpec CarSpec { get; set; }

    }

}
