package src;
import java.util.Arrays;
import java.util.Scanner;

public class Problem10ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine().toLowerCase();
		String[] arrStr = str.split("\\W+");

		Arrays.sort(arrStr);

		System.out.print(arrStr[0] + " ");
		for (int i = 1; i < arrStr.length; i++) {
			if (arrStr[i].equals(arrStr[i - 1])) {
				continue;
			}
			System.out.print(arrStr[i] + " ");
		}


	}

}
