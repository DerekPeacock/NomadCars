using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Daniel
/// </summary>
namespace NomadCars.Models
{
    public class Images
    {
        /// <summary>
        /// A number assigned to each image as
        /// a unique identifier.
        /// </summary>
        public int ImageID;

        /// <summary>
        /// The URL of the image being used on 
        /// our website.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.ImageUrl)]
        public string ImageURL;

        /// <summary>
        /// A short description of what is being 
        /// displayed in the image.
        /// </summary>
        [Required, StringLength(255), Display(Name = "Description")]
        public string Description;

        /// <summary>
        /// A message that will appear alongside 
        /// the image as a one sentance summary 
        /// of the image's contents.
        /// </summary>
        [Required, StringLength(50)]
        public string Caption;

        /// <summary>
        /// Refers to the positioning of the car 
        /// from where the photo was taken, e.g. 
        /// front, back or interior.
        /// </summary>
        [Required, StringLength(20)]
        public string ImageType;

        public ICollection<Car> car;

    }
}

