//This class generates appointments for Appointed
//Takes in doctor name as an argument

import java.io.*;
import java.util.*;

public class Appointment
{
	
	//Constants
	final static int MAX_HOUR = 12;									//How many hours we generate the appointments for
	final static int MAX_SLOT = 4;										//How many slots there are per hour
	
	
	public static void main(String[] args)
	{	
		//Initialize the doctor name
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
		}
		else if (docName.equals("Dr. Specter"))
		{
			color = "Violet";
		}
		else if (docName.equals("Dr. Paulsen"))
		{
			color = "Orange";
		}
		else
		{
			System.out.println("Error, invalid doctor name!");
			System.exit(1);
		}
		
		//Create the appointments and write
		
		Random rnd = new Random();									//Random number generator
		
		PrintWriter writer;
		try
		{
			writer = new PrintWriter("Appointments.txt");								//Create (overwrite) the file
			String patient;																//Patient name
			AppointmentGenerator appointmentGen = new AppointmentGenerator();			//Object that generates appointments
			
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