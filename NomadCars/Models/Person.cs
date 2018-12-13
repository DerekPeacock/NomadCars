using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NomadCars.Models
{
    /// <summary>
    /// William
    /// </summary>
    public class Person
    {
        /// <summary>
        /// A unique number given to a person who 
        /// involves themselves with our cars business,
        /// primarily a customer.
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The Forename of any given person.
        /// </summary>
        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The surname of any given person.
        /// </summary>
        [Required, StringLength(20), Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number of a person, assigned to a home phone.
        /// </summary>
        [StringLength(16), DataType(DataType.PhoneNumber), Display(Name = "Home Phone Number")]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// The phone number of a person, assigned to their mobile phone.
        /// </summary>
        [StringLength(16), DataType(DataType.PhoneNumber), Display(Name = "Mobile Phone NUmber")]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The e-mail held by a person by which they can be contacted
        /// </summary>
        [Required, StringLength(100), Display(Name = "E-mail Address")]
        public string Email { get; set; }

        /// <summary>
        /// The date of birth of the person
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "dd/mm/yy")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The is a current statement of someone's personal relationship status, 
        /// e.g. single, married or divorced. This kind of information is often 
        /// used in forms to determine details such as financial needs.
        /// </summary>
        [Required, StringLength(20), Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// A boolean statement that refers to whether or not the person 
        /// concerned is a customer.
        /// </summary>
        public bool Customer { get; set; }

        public int? StaffID { get; set; }
       
        public virtual Staff Staff { get; set; }

        public int AdressID { get; set; }

        public virtual Address Address { get; set; }

        public ICollection<Purchase> PurchaseList;

        public virtual PaymentCard PaymentCard { get; set; }

    }
}
