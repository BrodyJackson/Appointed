import java.util.*;
import java.lang.*;
import java.io.*;

public class Appointment
{
	//Appointment types
	final String CONSULTATION = "Consultation";
	final String STANDARD = "Standard";
	final String NO_APPOINTMENT = "";
	
	//Appointment type frequencies
	//Should always add up to 1
	final double CONSULTATION_FREQUENCY = 0.10;			//Probability of having a consultation in a given slot. Always followed by no appointment.
	final double STANDARD_FREQUENCY = 0.50;				//Probability of having a standard appointment in a given slot.
	final double APPOINTMENT_FREQUENCY = CONSULTATION_FREQUENCY + STANDARD_FREQUENCY;	//Probability of having any appointment in a given slot
	final double NO_APPOINTMENT_FREQUENCY = 1 - APPOINTMENT_FREQUENCY;					//Probability of there being no appointment in a given slot
	final double APPOINTMENT_CELL_OPACITY = 0.4;			//Opacity of the appointment cell if there is an appointment there
	
	boolean skipNextSlot;				//When an appointment fills more than one slot, we need to skip the next slot
	Random rnd;							//A random number generator
	ArrayList<String> patientList;		//List of possible patients
	
	public Appointment()
	{
		skipNextSlot = false;				//Initialize to false
		rnd = new Random();					//Initialize generator
		patientList = getPatientList();		//List of possible patients
	}
	
	public String makeAppointment(String docName, String color)
	{
		String patient = patientList.get(rnd.nextInt(patientList.size()));				//Get a random patient
		
		String appointmentType = getAppointmentType();
		String[] appointmentTypeSplit = appointmentType.split(" ");
		String type = appointmentTypeSplit[0];
		int length = Integer.parseInt(appointmentTypeSplit[1]);

		String docNameString = "\"" + docName + "\"";
		String colorString = "\"" + color + "\"";
		String patientString = "\"" + patient + "\"";
		
		String typeString = "\"" + type + "\"";
		String heightString = "\"" + Integer.toString(35*length) + "\"";
		String marginString = "\"0," + Integer.toString(length) + ",0,0\"";
		String rowspanString = "\"" + Integer.toString(length) + "\"";
		
		String opacityString;
		if (type == NO_APPOINTMENT)
		{
			opacityString = "\"0.4\"";
		}
		else
		{
			opacityString = "\"0\"";
		}
		
		if (length == 2)
		{
			skipNextSlot = true;
		}
		else if (length == 1)
		{
			skipNextSlot = false;
		}
		else
		{
			throw new Error("Code is only set up to handle appointments of length 2!");
		}
		
		String appointment = "new Appointment ( ){ DateTime = DateTime.Today, Type = " + typeString + ", Height = " + heightString + ", Margin = " + marginString + ", Patient = " + patientString + ", DoctorName = " + docNameString + ", Colour = " + colorString + ", Visibility = \"Visible\", Cursor = \"Hand\", RowSpan = " + rowspanString + ", Opacity = " + opacityString + " },";
		
		return appointment;
	}
	
	//Get the appointment type and length
	//Length can be one or two
	private String getAppointmentType()
	{
		double randomNum = rnd.nextDouble();						//Generate a random floating point number
		if (randomNum > APPOINTMENT_FREQUENCY)
		{
			String type = NO_APPOINTMENT;
			int length = 1;
			return NO_APPOINTMENT + " " + Integer.toString(length);
		}
		else
		{
			if (randomNum < CONSULTATION_FREQUENCY)
			{
				String type = CONSULTATION;
				int length = 2;
				return NO_APPOINTMENT + " " + Integer.toString(length);
			}
			else
			{
				String type = STANDARD;
				int length = 1;
				return NO_APPOINTMENT + " " + Integer.toString(length);
			}
		}
	}
	
	private ArrayList<String> getPatientList()
	{
		ArrayList<String> list = new ArrayList<String>();		//List of patients
		File patientNames = new File("Patient List.txt");		//File containing names of patients
		Scanner reader;											//File reader
		try
		{
			reader = new Scanner(patientNames);					//Load file
			while (reader.hasNextLine())						//While there are still names to be read...
			{
				list.add(reader.nextLine());					//Read the next name and add it to the list
			}
		}
		catch (FileNotFoundException e)
		{
			System.out.println("Patient name file not found!");
			System.exit(2);
		}
		return list;											//Return the list with the names of all the patients
	}
}