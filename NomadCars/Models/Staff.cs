using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NomadCars.Models
{
    /// <summary>
    /// William
    /// Each Member of staff is a Person working for Nomad Cars
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// A specific identification number that identifies the member 
        /// of staff within the database.
        /// </summary>
        [ForeignKey("Person")]
        public int StaffID { get; set; }
        /// <summary>
        /// The department that the member of staff works for. 
        /// The departments include sales, database administration and management
        /// </summary>
        public String Department { get; set; }
        /// <summary>
        /// The specific position that the member of staff holds within 
        /// their department, e.g. sales representative or database administrator.
        /// </summary>
        public String JobPosition { get; set; }

        /// <summary>
        /// The monthly payment of the employee.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// The starting date of the employee's employment, 
        /// measured in a numerical value e.g. 12/09/2013
        /// </summary>
        public int StartDate { get; set; }

        /// <summary>
        ///  The URL of the image of the satff memeber,
        ///  being used on the website.
        /// </summary>
        public String ImageURL { get; set; }

        public String Description { get; set; }

        public virtual Person Person { get; set; }

    }
}
