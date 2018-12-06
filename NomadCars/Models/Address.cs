using System;
/// <summary>
/// Daniel
/// </summary>
public class Address {
	/// <summary>
	/// A unique identification number used to identify the address details of a person within the database. This applies to both customers and staff. No other attribute was applied as the primary key as the other attributes are not unique enough to be an identifier.
	/// </summary>
	private int addressID;
	/// <summary>
	/// This is either the name or number of the house a person lives in.
	/// </summary>
	private int houseID;
	/// <summary>
	/// The name of the street the person lives on as part of their declared address.
	/// </summary>
	private Integer streetName;
	/// <summary>
	/// The name of the town the person lives in.
	/// </summary>
	private int townName;
	/// <summary>
	/// A set of letters and number used to identify a sector, within a district, within an area. The British makeup of postcodes follows the layout of, for example: HP12 3AB. Postcodes do not identify specific houses however, making them not specific enough for use as a primary key.
	/// </summary>
	private int postcode;
	/// <summary>
	/// A large area of bordered land within a country where a person will live.
	/// </summary>
	private int county;

	private Person person;

}
