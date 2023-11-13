int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int m = Convert.ToInt32(Console.ReadLine().Trim());

List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

List<int> result = MissingNumbers(arr, brr);

static List<int> MissingNumbers(List<int> diffList, List<int> orginalList)
{
	Dictionary<int, int> numberFrequencies = new Dictionary<int, int>();

	foreach (int num in orginalList)
	{
		if (numberFrequencies.ContainsKey(num))
		{
			numberFrequencies[num]++;
		}
		else
		{
			numberFrequencies[num] = 1;
		}
	}

	foreach (int num in diffList)
	{
		numberFrequencies[num]--;
	}

	List<int> missingNumbers = new List<int>();
	foreach (var pair in numberFrequencies)
	{
		if (pair.Value > 0)
		{
			missingNumbers.Add(pair.Key);
		}
	}

	missingNumbers.Sort();
	return missingNumbers;
}