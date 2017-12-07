import java.util.*;
import java.lang.*;
import java.io.*;

public class AppointmentGenerator
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
	boolean lastAppointment;			//If this is the last appointment, we don't want to set any appointment that takes longer than one slot
	Random rnd;							//A random number generator
	ArrayList<String> patientList;		//List of possible patients
	int startEmptySlots;				//Number of empty cells at the beginning
	int endEmptySlots;					//Number of empty cells at the end
	int numSlots;						//Total number of appointment slots this day
	int appointmentCounter;				//Number of appointments generated so far
	
	public AppointmentGenerator(int new_startEmptySlots, int new_endEmptySlots, int new_numSlots)
	{
		skipNextSlot = false;								//Initialize to false
		lastAppointment = false;							//Initialize to false
		rnd = new Random();									//Initialize generator
		patientList = getPatientList();						//List of possible patients
		startEmptySlots = new_startEmptySlots;				//How many empty cells in the beginning
		endEmptySlots = new_endEmptySlots;					//How many empty cells at the end
		numSlots = new_numSlots;							//Number of appointment slots
		appointmentCounter = 0;								//No appointments generated so far
	}
	
	//Returns a line of C# code to make an appointment as a String
	public String makeAppointment(String docName, String color)
	{
		// if (appointmentCounter < startEmptySlots)
		// {
			// appointmentCounter++;
			// return "\"\"	// Empty start appointment " + Integer.toString(appointmentCounter);
		// }
		
		// if (appointmentCounter >= (numSlots - endEmptySlots))
		// {
			// appointmentCounter++;
			// return "\"\"	// Empty end appointment " + Integer.toString(appointmentCounter - (numSlots - endEmptySlots));
		// }
		
		String patient = patientList.get(rnd.nextInt(patientList.size()));				//Get a random patient
		
		String type;																	//What kind of appointment is it?
		int length;																		//How many time slots does it occupy
		
		if (appointmentCounter < startEmptySlots)										//Is it too early for this doctor to have appointments?
		{
			type = NO_APPOINTMENT;
			length = 1;
		}
		
		else if (appointmentCounter >= (numSlots - endEmptySlots))						//Is it too late for this doctor to have appointments?
		{
			type = NO_APPOINTMENT;
			length = 1;
		}
		else
		{
			String appointmentType = getAppointmentType();
			type = appointmentType.substring(0,appointmentType.length() - 1);											//Everything except last character
			String lastCharacter = appointmentType.substring(appointmentType.length()-1,appointmentType.length());		//Only last character, which is the length
			length = Integer.parseInt(lastCharacter);																	//Convert length from String to int
		}

		String docNameString = "\"" + docName + "\"";
		String colorString = "\"" + color + "\"";
		String patientString = "\"" + patient + "\"";
		
		String typeString = "\"" + type + "\"";
		String heightString = "\"" + Integer.toString(35*length) + "\"";
		String marginString = "\"0," + Integer.toString(length) + ",0,0\"";
		String rowspanString = "\"" + Integer.toString(length) + "\"";
		
		String opacityString;
		if (type.equals(NO_APPOINTMENT))
		{
			opacityString = "\"0\"";
		}
		else
		{
			opacityString = "\"" + Double.toString(APPOINTMENT_CELL_OPACITY) + "\"";
		}
		
		String appointment = "new Appointment ( ){ DateTime = DateTime.Today, Type = " + typeString + ", Height = " + heightString + ", Margin = " + marginString + ", Patient = " + patientString + ", DoctorName = " + docNameString + ", Colour = " + colorString + ", Visibility = \"Visible\", Cursor = \"Hand\", RowSpan = " + rowspanString + ", Opacity = " + opacityString + " },";
		
		appointmentCounter++;

		return appointment;
	}
	
	//Get the appointment type and length
	//Length can be one or two
	//Don't use - character in appointment name
	private String getAppointmentType()
	{
		double randomNum = rnd.nextDouble();						//Generate a random floating point number
		if (randomNum > APPOINTMENT_FREQUENCY || skipNextSlot)
		{
			skipNextSlot = false;									//We've skipped a slot, so we don't necessarily need to skip the next
			String type = NO_APPOINTMENT;
			int length = 1;
			return type + Integer.toString(length);
		}
		else
		{
			if (randomNum < CONSULTATION_FREQUENCY)
			{
				String type = CONSULTATION;
				int length = 2;
				skipNextSlot = true;								//Length is more than one, so we can't schedule an appointment in the next slot!
				return type + Integer.toString(length);
			}
			else
			{
				String type = STANDARD;
				int length = 1;
				return type + Integer.toString(length);
			}
		}
	}
	
	//Load the list of possible patients from a file
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
	
	public void setLastAppointment()
	{
		lastAppointment = true;
	}
}