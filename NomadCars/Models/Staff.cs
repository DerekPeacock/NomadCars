using System;
namespace NomadCars.Models
{
    /// <summary>
    /// Daniel's Class
    /// Each Member of staff is a Person working for Nomad Cars
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// A specific identification number that identifies the member 
        /// of staff within the database.
        /// </summary>
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

        public decimal Salary { get; set; }

        public int StartDate { get; set; }

        public String ImageURL { get; set; }

        public String Description { get; set; }

        // Foriegn Key
        public int PersonID { get; set; }

        public virtual Person Person { get; set; }

    }
}
