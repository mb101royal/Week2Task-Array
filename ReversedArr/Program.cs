namespace ReversedArr
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = {1, 2, 3, 7, 4, 5, 6};
			int temp;

			if (numbers.Length < 2)
			{
				Console.WriteLine("Array should have at least 2 elements.");
			}
			else
			{
				for (int iter = 0; iter < numbers.Length / 2; iter++)
				{
					temp = numbers[iter];
					numbers[iter] = numbers[numbers.Length - iter - 1];
					numbers[numbers.Length - iter - 1] = temp;
				}
				Console.WriteLine(string.Join(", ", numbers));
			}

			/*int[] reversedNumbers = { };
			for (int i = 1; i < numbers.Length - 1; i++)
			{
				reversedNumbers."elaveEt"(numbers[numbers.Length - i]); // ilkin arraydaki sondan elementleri yeni arraya ardicilliqla elave edir.
			}
			Console.WriteLine(string.Join(", ", reversedNumbers));*/
		}
	}
}