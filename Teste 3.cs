class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 7, 11, 15 };
        var enter = 9;
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (dictionary.ContainsKey(enter - numbers[i]))
            {
                var index = dictionary[enter - numbers[i]];
                Console.WriteLine(
                    $"Valor de soma da entrada: {enter}\n{enter} é a soma entre {numbers[index]} "
                    + $"+ {numbers[i]}\n{numbers[index]} "
                    + $"+ {numbers[i]} são os valores do de entrada.");
                return;
            }
            dictionary[numbers[i]] = i;
        }
    }
}