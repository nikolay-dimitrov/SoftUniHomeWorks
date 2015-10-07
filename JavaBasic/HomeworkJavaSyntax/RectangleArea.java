import java.awt.Rectangle;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		int width = 0;
		int length = 0;
		
		try {
			BufferedReader readInput = new BufferedReader(new InputStreamReader( System.in));
			System.out.println("Please enter length of a rectangle ");
			length = Integer.parseInt(readInput.readLine());
			
			System.out.println("Please enter width of a rectangle");
			width = Integer.parseInt(readInput.readLine());
			
		} catch (NumberFormatException invalidValue) {
			System.out.println("Ivalid value" + invalidValue);
			System.exit(0);
		}
		catch (IOException invalidInputOrOutPut ) {
			System.out.println("Invalid input:" + invalidInputOrOutPut);
			System.exit(0);
			
		}
		int area = length * width;
		
		System.out.println("Area of a rectangle is " + area);

	}

}
