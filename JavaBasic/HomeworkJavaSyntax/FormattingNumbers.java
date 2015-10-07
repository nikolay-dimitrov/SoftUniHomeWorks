import java.util.Scanner;

public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		System.out.println("enter 3 number : an integer 'a' and floating-points 'b' and 'c'\n"
				+ "on a sigle line: ");
		int a = reader.nextInt();
		double b = reader.nextDouble();
		double c = reader.nextDouble();
		String hexadcimal =Integer.toHexString(a).toUpperCase();
		String binary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
		if ( c == Math.floor(c)) {
			System.out.printf("|%-10s|%s|%10.2f|%-10.0f|\n",hexadcimal,binary,b,c);
		}
		else {
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|\n",hexadcimal,binary,b,c);
		}		

	}

}
