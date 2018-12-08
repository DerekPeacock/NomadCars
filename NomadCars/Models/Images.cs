using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// William
/// </summary>
namespace NomadCars.Models
{

    public class Images
    {
        private int ImageID;
        private String ImageURL;
        private String Description;
        private String Caption;
        private String ImageType;

        private ICollection<Car> car;

    }
}

