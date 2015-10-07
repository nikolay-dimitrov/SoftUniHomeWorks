import java.util.Scanner;

public class Problem5CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();

		String[] arrStr = str.split("\\W+");
		
		System.out.println(arrStr.length);

	}

}
