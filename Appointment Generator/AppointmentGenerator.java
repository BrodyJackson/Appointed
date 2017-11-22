//This class generates appointments for Appointed
//Takes in doctor name as an argument

import java.io.*;
import java.util.*;

public class AppointmentGenerator
{
	
	public static void main(String[] args)
	{	
		//Initialize the doctor name
		final String docName = args[0];		
		
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
		
		
		File file = new File("Appointments.txt");					//The file the appointments will be written to
		PrintWriter writer;
		try
		{
			writer = new PrintWriter("Appointments.txt");			//Create (overwrite) the file
			String patient;											//Patient name
			Appointment appointment = new Appointment();			//Object that generates appointments
			
			for (int hour = 1; hour <= 12; hour++)
			{
				//Write comment for that hour
				writer.println("// " + numToString(hour));
				for (int slot = 1; slot <= 4; slot++)
				{
					//Generate the line of code
					String code = appointment.makeAppointment(docName, color);		//Line of code corresponding to that slot
					writer.println(code);											//Write the line of code
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
		
	//Converts an integer from 1-12 (inclusive) to a word
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
		}
		return numString;
	}
}