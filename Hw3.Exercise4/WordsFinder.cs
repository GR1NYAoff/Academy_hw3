namespace Hw3.Exercise4
{

    public static class WordsFinder
    {
        public static List<string>? FindWords(string word, List<string> listOfWords)
        {
            if (word is null || word.Length <= 0)
                throw new ArgumentNullException(word);

            var result = listOfWords.Select(x => x)
            .Where(a => a.Length == word.Length && Validate(a, word)).ToList();

            return result;
        }

        private static bool Validate(string a, string word)
        {
            var arr1 = a.ToCharArray().OrderBy(x => x);
            var arr2 = word.ToCharArray().OrderBy(x => x);

            return arr1.SequenceEqual(arr2);
        }
    }
}
