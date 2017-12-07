//This class generates appointments for Appointed
//Takes in doctor name as a mandatory argument
//Takes in two optional arguments, number of empty cells at the beginning and number of empty cells at the end
//If optional arguments aren't provided, number of empty cells based on doctor
import java.io.*;
import java.util.*;

public class Appointment
{
	
	//Constants
	final static int MAX_HOUR = 12;									//How many hours we generate the appointments for
	final static int MAX_SLOT = 4;									//How many slots there are per hour
	//Number of empty cells at the beginning/end of the day for each doctor
	final static int START_EMPTY_CELLS_PEARSON = 4;					//Number of empty cells at the beginning of the day for Dr. Pearson
	final static int END_EMPTY_CELLS_PEARSON = 8;					//Number of empty cells at the end of the day for Dr. Pearson
	final static int START_EMPTY_CELLS_SPECTRE = 2;					//Number of empty cells at the beginning of the day for Dr. Spectre
	final static int END_EMPTY_CELLS_SPECTRE = 6;					//Number of empty cells at the end of the day for Dr. Spectre
	final static int START_EMPTY_CELLS_PAULSON = 6;					//Number of empty cells at the beginning of the day for Dr. Paulson
	final static int END_EMPTY_CELLS_PAULSON = 10;					//Number of empty cells at the end of the day for Dr. Paulson
	
	
	public static void main(String[] args)
	{	
		int startEmptySlots = 0;
		int endEmptySlots = 0;
		//Initialize the doctor name, color and number of empty cells
		final String docName;
		try
		{
			docName = args[0];		
		}
		catch (ArrayIndexOutOfBoundsException e)
		{
			//If user did not provide doctor's name, tell them what to do
			System.out.println("Please enter doctor's name as a command line argument!");
			return;
		}
		//Make sure it's valid and set the color
		String color = "";										//Color of the appointment, based on the doctor

		if (docName.equals("Dr. Pearson"))
		{
			color = "DarkTurquoise";
			startEmptySlots = START_EMPTY_CELLS_PEARSON;
			endEmptySlots = END_EMPTY_CELLS_PEARSON;
		}
		else if (docName.equals("Dr. Specter"))
		{
			color = "Violet";
			startEmptySlots = START_EMPTY_CELLS_SPECTRE;
			endEmptySlots = END_EMPTY_CELLS_SPECTRE;
		}
		else if (docName.equals("Dr. Paulsen"))
		{
			color = "Orange";
			startEmptySlots = START_EMPTY_CELLS_PAULSON;
			endEmptySlots = END_EMPTY_CELLS_PAULSON;
		}
		else
		{
			System.out.println("Error, invalid doctor name!");
			System.exit(1);
		}
		
		//If number of empty cells at beginning and end was entered as an argument, initialize those.
		if (args.length > 1)
		{
			try
			{
				startEmptySlots = Integer.parseInt(args[1]);
				endEmptySlots = Integer.parseInt(args[2]);
				if ((startEmptySlots+endEmptySlots) > (MAX_HOUR*MAX_SLOT))
				{
					System.out.println("Error, too many empty cells!");
					System.exit(3);
				}
			}
			catch (Exception e)
			{
				System.out.println("Incorrect usage!");
				System.exit(4);
			}
		}
		
		//Create the appointments and write
		
		Random rnd = new Random();									//Random number generator
		
		PrintWriter writer;
		try
		{
			writer = new PrintWriter("Appointments.txt");								//Create (overwrite) the file
			String patient;																//Patient name
			int numSlots = MAX_HOUR*MAX_SLOT;											//Number of slots
			AppointmentGenerator appointmentGen = new AppointmentGenerator(startEmptySlots, endEmptySlots, numSlots);			//Object that generates appointments
			
			for (int hour = 1; hour <= MAX_HOUR; hour++)
			{
				//Write comment for that hour
				writer.println("// " + numToString(hour));
				for (int slot = 1; slot <= MAX_SLOT; slot++)
				{
					//If this is the last appointment slot, don't book an appointment that takes more than one slot
					if ((hour*slot) == (MAX_HOUR*MAX_SLOT))
					{
						appointmentGen.setLastAppointment();
					}
					//Generate the line of code
					String code = appointmentGen.makeAppointment(docName, color);		//Line of code corresponding to that slot
					writer.println(code);												//Write the line of code
				}
				writer.println();									//Add a newline
			}
			writer.flush();											//Explicitly flush the printwriter
			writer.close();											//Close the file
		}
		catch (FileNotFoundException e)
		{
			System.out.println("Could not find/create output file!");
			System.exit(2);
		}
	}
		
	//Converts an integer from 1-24 (inclusive) to a word
	public static String numToString(int num)
	{
		String numString = "";			//Number as a string
		switch(num)
		{
			case 1: numString = "One";
			break;
			case 2: numString = "Two";
			break;
			case 3: numString = "Three";
			break;
			case 4: numString = "Four";
			break;
			case 5: numString = "Five";
			break;
			case 6: numString = "Six";
			break;
			case 7: numString = "Seven";
			break;
			case 8: numString = "Eight";
			break;
			case 9: numString = "Nine";
			break;
			case 10: numString = "Ten";
			break;
			case 11: numString = "Eleven";
			break;
			case 12: numString = "Twelve";
			break;
			case 13: numString = "Thirteen";
			break;
			case 14: numString = "Fourteen";
			break;
			case 15: numString = "Fifteen";
			break;
			case 16: numString = "Sixteen";
			break;
			case 17: numString = "Seventeen";
			break;
			case 18: numString = "Eighteen";
			break;
			case 19: numString = "Nineteen";
			break;
			case 20: numString = "Twenty";
			break;
			case 21: numString = "Twenty One";
			break;
			case 22: numString = "Twenty Two";
			break;
			case 23: numString = "Twenty Three";
			break;
			case 24: numString = "Twenty Four";
			break;
		}
		return numString;
	}
}