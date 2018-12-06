using System;

namespace NomadCars.Models
{
    /// <summary>
    /// William
    /// </summary>
    public class Person
    {
        public int PersonID { get; set; }
        /// <summary>
        /// The Forename of any given person.
        /// </summary>
        public String FirstName { get; set; }
        /// <summary>
        /// The surname of any given person.
        /// </summary>
        public String LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HomePhoneNumber { get; set; }
        /// <summary>
        /// The phone number any given person, by which they can be contacted with.
        /// </summary>
        public int MobilePhoneNumber { get; set; }
        /// <summary>
        /// The e-mail held by a person by which they can be contacted
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// The date of birth of the person
        /// </summary>
        public Date DateOfBirth { get; set; }
        /// <summary>
        /// The is a current statement of someone's personal relationship status, e.g. single, married or divorced. This kind of information is often used in forms to determine details such as financial needs.
        /// </summary>
        public String MaritalStatus { get; set; }
        public bool Customer { get; set; }


        public Staff staff;
        public Address[] address;
        public Purchase purchase;

        public _Payment_Card card;

    }
}
