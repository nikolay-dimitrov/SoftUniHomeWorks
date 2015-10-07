import java.util.Iterator;
import java.util.Scanner;

public class Problem3LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();

		String[] arrStr = str.split(" ");

		int largestSequence = 1, index = 0, tempLargest = 1;
		
		for (int i = 1; i < arrStr.length; i++) {
			if (arrStr[i].equals(arrStr[i - 1])) {
				tempLargest++;
			} else {
				tempLargest = 1;
			}
			
			if (tempLargest > largestSequence) {
				largestSequence = tempLargest;
				index = i-largestSequence+1;
			}

		}
		for (int i = 0; i < largestSequence; i++) {

			System.out.print(arrStr[index] + " ");
		}

	}

}
