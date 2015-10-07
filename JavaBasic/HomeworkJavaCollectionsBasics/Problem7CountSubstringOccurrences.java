
public class Problem7CountSubstringOccurrences {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String str = input.nextLine().toLowerCase();
		String lookingWord = input.nextLine();

		int count = 0;

		for (int i = 0; i <= str.length() - lookingWord.length(); i++) {
			if (str.substring(i, lookingWord.length() + i) //looking for a substring of a word shifted by i.. or 1
					.contains(lookingWord)) {
				count++;
			}
		}

		System.out.println(count);

	}

}
