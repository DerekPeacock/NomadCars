using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Daniel
/// </summary>
namespace NomadCars.Models
{
    public enum ImageFormats
    {
        img,
        jpg,
        png
    }

    public enum ImagePositions
    {
        [Display(Name ="Car Front")]
        CAR_FRONT,
        [Display(Name = "Car Back")]
        CAR_BACK,
        [Display(Name = "Car Interior")]
        CAR_INTERIOR,
        [Display(Name = "Car Side")]
        CAR_SIDE,
        [Display(Name = "Car Accessory")]
        CAR_ACCESSORY
    }

    /// <summary>
    /// Daniel
    /// </summary>

    public class CarImage
    {
        /// <summary>
        /// A number assigned to each image as
        /// a unique identifier.
        /// </summary>
        public int CarImageID { get; set; }

        /// <summary>
        /// The URL of the image being used on our website.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        /// <summary>
        /// A short description of what is being 
        /// displayed in the image.
        /// </summary>
        [Required, StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// A message that will appear alongside 
        /// the image as a one sentance summary 
        /// of the image's contents.
        /// </summary>
        [Required, StringLength(50)]
        public string Caption { get; set; }

        /// <summary>
        /// Refers to the positioning of the car 
        /// from where the photo was taken, e.g. 
        /// front, back or interior.
        /// </summary>
        public ImageFormats ImageFormat { get; set; }

        public ImagePositions Position { get; set; }

        // FK
        public int CarID { get; set; }

        public virtual Car Car { get; set; }

    }
}

