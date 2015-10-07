import java.util.Scanner;

public class Problem4LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		
		String [] arrStrings = str.split(" ");
		int [] numbers = new int [arrStrings.length];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(arrStrings[i]);
		}
		int largestSequence = 1, index = 0, tempLargest = 1;
		
		System.out.println(numbers[0]);
		
		for (int i = 1; i < arrStrings.length; i++) {
			if (numbers[i] > numbers[i - 1]) {
				tempLargest++;
				System.out.print(" " + numbers[i]);

			} else {
				tempLargest = 1;

				System.out.println();
				System.out.print(numbers[i]);
			}

			if (tempLargest > largestSequence) {
				largestSequence = tempLargest;
				index = i;
			}

		}
		
		System.out.println();
		
		System.out.print("Longest: ");

		for (int i = 0; i < largestSequence; i++) {

			System.out.print(arrStrings[index - largestSequence + 1 + i] + " ");
		}

	}

}
