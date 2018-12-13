using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NomadCars.Models
{
    public enum MaritalSatusOptions
    {
        SINGLE,
        MARRIED,
        DIVORCED
    }

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
        [StringLength(16), DataType(DataType.PhoneNumber), Display(Name = "Home Phone")]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// The phone number of a person, assigned to their mobile phone.
        /// </summary>
        [StringLength(16), DataType(DataType.PhoneNumber), Display(Name = "Mobile Phone")]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The e-mail held by a person by which they can be contacted
        /// </summary>
        [Required, StringLength(100), Display(Name = "E-mail Address")]
        public string Email { get; set; }

        /// <summary>
        /// The date of birth of the person
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The is a current statement of someone's personal relationship status, 
        /// e.g. single, married or divorced. This kind of information is often 
        /// used in forms to determine details such as financial needs.
        /// </summary>
        [Display(Name = "Marital Status"), StringLength(20)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// A boolean statement that refers to whether or not the person 
        /// concerned is a customer.
        /// </summary>
        public bool IsCustomer { get; set; }

        // Can be a member of staff and a customer, but must be at least one
        public bool IsStaff { get; set; }

        //public int AdressID { get; set; }

        public virtual Address Address { get; set; }

        public Staff Staff { get; set; }

        public ICollection<Purchase> PurchaseList;

        public virtual PaymentCard PaymentCard { get; set; }

    }
}
