package src;

public class Problem11MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] arrStr = input.nextLine().toLowerCase().split("\\W+");

		TreeMap<String, Integer> wordCounterMap = new TreeMap<String, Integer>();

		Integer oldValue = 0, maxCount = 0;
		for (String wordCount : arrStr) {
			oldValue = wordCounterMap.get(wordCount);
			if (oldValue == null)
				oldValue = 0;// first time is always null

			if (oldValue + 1 > maxCount) {
				maxCount = oldValue + 1;
			}
			
			wordCounterMap.put(wordCount, oldValue + 1);

		}

		for (Map.Entry<String, Integer> entry : wordCounterMap.entrySet()) {
			if (entry.getValue() == maxCount) {
				System.out.println(entry.getKey() + " - > " + entry.getValue()
						+ " times");
			}

		}

	}

}
