import java.util.Scanner;

public class CountOfBitsOne {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner reader = new Scanner(System.in);
		System.out.println("Enter number n: ");
		int number = reader.nextInt();
		
		//Invoke the method "bitCounter"
		bitCounter(number);
		
		//Using the build-in method bitCounnt (Java.lang.Integer.bitCount() Method)
		System.out.println(Integer.bitCount(number));
	} 
	
	//A method for counting the 1 bits in a binary representation of an integer number
	public static void bitCounter(int num){
		String binaryNumber = Integer.toBinaryString(num);
		int counter = 0;
		for (int i = 0; i < binaryNumber.length(); i++) {
			if (binaryNumber.charAt(i) =='1') {
				counter ++;
			}
		}
		System.out.println(counter);
	}

}
