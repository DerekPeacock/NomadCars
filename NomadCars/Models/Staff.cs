using System;
/// <summary>
/// Daniel
/// </summary>
public class Staff {
	/// <summary>
	/// A specific identification number that identifies the member of staff within the database.
	/// </summary>
	private int staffID;
	/// <summary>
	/// The department that the member of staff works for. The departments include sales, database administration and management
	/// </summary>
	private String department;
	/// <summary>
	/// The specific position that the member of staff holds within their department, e.g. sales representative or database administrator.
	/// </summary>
	private String jobPosition;
	private BigDecimal salary;
	private Integer startDate;
	private String imageURL;
	private String staffDescription;

	private Purchase purchase;

	private Person person;

}
