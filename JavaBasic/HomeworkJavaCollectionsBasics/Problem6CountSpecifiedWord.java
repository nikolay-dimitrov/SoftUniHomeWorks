import java.util.Scanner;

public class Problem6CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String str = scanner.nextLine();
		String lookingWord = scanner.nextLine();
		
		String [] arrStr = str.split("\\W+");
		
		int count = 0;
		for (int i = 0; i < arrStr.length; i++) {
			if (arrStr[i].toLowerCase().equals(lookingWord)) {
				count++;
			}
		}
		System.out.println(count);
	}

}
