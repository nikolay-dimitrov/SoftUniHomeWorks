
public class Problem8ExtractEmails {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();

		Pattern emailPattern = Pattern
		// .compile("[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}");
		// .compile("[\\w-+]+(?:\\.[\\w-+]+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*(\\s*\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)*");
				.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");

		Matcher matcher = emailPattern.matcher(str);
		while (matcher.find()) {
			System.out.println(matcher.group());
		}

	}

}
