import java.util.Scanner;

public class Problem2SequencesOfEqualStrings {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner scanner = new Scanner(System.in);
		String inputWord = scanner.nextLine();
		
		String [] arrayOfStrings = inputWord.split(" ");
		
		System.out.println(arrayOfStrings[0]);
		for (int i = 0; i < arrayOfStrings.length; i++) {
			if (arrayOfStrings[i].equals(arrayOfStrings[i-1])) {
				System.out.println(" " + arrayOfStrings);
			} else {
				System.out.println();
				System.out.print(arrayOfStrings[i]);	
			}
		}
		

	}

}
