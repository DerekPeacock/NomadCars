using System;
/// <summary>
/// William
/// </summary>
public class Car {
	/// <summary>
	/// A specific identification number given to each car being sold. This is so they can be easily identified in the database.
	/// </summary>
	private int carID;
	/// <summary>
	/// The specific colour of the car e.g. black, white or silver.
	/// </summary>
	private Integer colour;
	/// <summary>
	/// The identifiable number plate on the lower front and rear of the car for official identification purposes. For British cars it is generally laid out as a 'AB12 ABC' manner unless personalised.
	/// </summary>
	private Integer numberPlate;
	/// <summary>
	/// Vehicle identification number - A specific number for identifying the car. Similar to a fingerprint, no two cars have the same VIN number.
	/// </summary>
	private Integer vIN_No;
	/// <summary>
	/// A specific style of build that alters how the cars is labeled e.g. as a hatchback or sedan.
	/// </summary>
	private String bodyType;
	/// <summary>
	/// How many miles the car has done in total up to the point of purchase.
	/// </summary>
	private Integer mileage;
	/// <summary>
	/// The manner by which a car may change gear e.g. manually, via the driver, or automatically.
	/// </summary>
	private String transmissionType;
	/// <summary>
	/// The number of previous owners the car has had.
	/// </summary>
	private Integer previousOwner;
	/// <summary>
	/// The power of the cars acceleration, calculated in the number of seconds it takes for the car to reach 60 miles per hour.
	/// </summary>
	private Time accelerationTo60;
	private bool sold;
	private bool delivered;
	private Integer cO2Emissions;

	private Purchase purchase;
	private Accessory[] accessory;
	private Images[] images;

	private CarSpec carSpec;

}
