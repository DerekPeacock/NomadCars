using System;

namespace NomadCars.Models
{
    /// <summary>
    /// William, Daniel
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// A specific identification number that identifies the member of staff within the database.
        /// </summary>
        private int StaffID { get; set; }
        /// <summary>
        /// The department that the member of staff works for. The departments include sales, database administration and management
        /// </summary>
        private String Department { get; set; }
        /// <summary>
        /// The specific position that the member of staff holds within their department, e.g. sales representative or database administrator.
        /// </summary>
        private String JobPosition { get; set; }
        private Decimal Salary { get; set; }
        private DateTime StartDate { get; set; }
        private String ImageURL { get; set; }
        private String StaffDescription { get; set; }

        private Purchase purchase;

        private Person person;

    }
}
