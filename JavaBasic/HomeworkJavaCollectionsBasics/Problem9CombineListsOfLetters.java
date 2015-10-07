import java.util.ArrayList;
import java.util.Scanner;

public class Problem9CombineListsOfLetters {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		ArrayList<Character> arrLineOne = new ArrayList<>();
		ArrayList<Character> arrLineTwo = new ArrayList<>();

		for (Character c : input.nextLine().toCharArray()) {
			arrLineOne.add(c);
		}
		for (Character c : input.nextLine().toCharArray()) {
			arrLineTwo.add(c);
		}
		
		ArrayList<Character> outputList = new ArrayList<>();
		
		outputList.addAll(arrLineOne);
		
		for (int i = 0; i < arrLineTwo.size(); i++) {
			if (!arrLineOne.contains(arrLineTwo.get(i))) {
				outputList.add(' ');
				outputList.add(arrLineTwo.get(i));
			}
		}
		
		for (Character character : outputList) {
			System.out.print(character);
		}
	}

}
