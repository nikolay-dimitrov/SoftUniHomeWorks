import java.util.Scanner;

public class TheSmallestOf3Numbers {

	public static void main(String[] args) {
	
		Scanner reader = new Scanner(System.in);
		System.out.println("Enter your numbers: ");
		double firstNumber = reader.nextDouble();
		double secondNumber = reader.nextDouble();
		double thirdNumber = reader.nextDouble();
		
		System.out.println("Min = ");
		System.out.print(Math.min(firstNumber,Math.min(secondNumber, thirdNumber)));
	}

}
