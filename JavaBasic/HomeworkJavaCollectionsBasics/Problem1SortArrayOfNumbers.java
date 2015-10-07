
import java.util.Arrays;
import java.util.Scanner;

public class Problem1SortArrayOfNumbers {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner scanner = new Scanner(System.in);
		int arrayLength = scanner.nextInt();
		scanner.nextLine();
		
		int [] arrayOfNumbers = new int[arrayLength];
		
		for (int i = 0; i < arrayOfNumbers.length; i++) {
			arrayOfNumbers[i] = scanner.nextInt();

		}
		Arrays.sort(arrayOfNumbers);
		
		for (int i = 0; i < arrayOfNumbers.length; i++) {
			System.out.println(arrayOfNumbers[i] + " ");
		}

	}

}
