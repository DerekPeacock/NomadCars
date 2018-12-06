using System;
/// <summary>
/// Zeeshan
/// </summary>
public class CarSpec {
	/// <summary>
	/// An identification number assigned to each car specification for the purposes of representing a specification within the database.
	/// </summary>
	private int specID;
	/// <summary>
	/// What make the car is, all our cars are specifically BMW's
	/// </summary>
	private String make;
	/// <summary>
	/// What specific model number the car has been given by BMW
	/// </summary>
	private String model;
	/// <summary>
	/// Measured in cc. We are limiting this to one Engine Size only for a particular make and model
	/// </summary>
	private int engineSize;
	/// <summary>
	/// How many doors the car has including the trunk door
	/// </summary>
	private int doors;
	/// <summary>
	/// The length of the car, measured in centimeters
	/// </summary>
	private float length;
	/// <summary>
	/// The width of the car, measured in centimeters
	/// </summary>
	private float width;
	/// <summary>
	/// The amount of power the car can put out at maximum throttle
	/// </summary>
	private Integer bHP;
	/// <summary>
	/// Measured in litres
	/// </summary>
	private Integer bootCapacity;
	/// <summary>
	/// Type of fuel the specific BMW takes.
	/// </summary>
	private bool petrol;
	/// <summary>
	/// The number of miles the car can do before a gallon of petrol is depleted.
	/// </summary>
	private Integer mPG;
	/// <summary>
	/// Type of fuel the specific BMW takes.
	/// </summary>
	private bool diesel;
	/// <summary>
	/// This can be what the BMW is powered by
	/// </summary>
	private bool electric;
	/// <summary>
	/// How many seats the car has, including front and back seats
	/// </summary>
	private int seats;
	/// <summary>
	/// What tax band the BMW belongs in depending on emissions
	/// </summary>
	private String taxGroup;
	/// <summary>
	/// What the top speed of the BMW is, measured in MPH (Miles Per Hour)
	/// </summary>
	private int topSpeed;
	/// <summary>
	/// Whether the car is Front Wheel Drive (FWD), Rear Wheel Drive (RWD) or All/4 Wheel Drive (AWD/4WD)
	/// </summary>
	private String drivetrain;
	private String bodyType;
	private int range;

	private Car[] car;

}
