namespace Algorithm.String
{
    /// <summary>
    /// Reverse words in a given string
    /// Example: Let the input string be "i like this program very muc". 
    /// The function should change the string to "much very program this like i"
    /// Time Complexity: O(n)
    /// </summary>
    class WordReverser
    {
        public static string Reverse(string input)
        {
            return GetReverse(input, 0, "", "");
        }

        private static string GetReverse(string input, int currentIndex, string temp, string output)
        {
            if (currentIndex == input.Length)
                return temp + output;
            else
            {
                if (input[currentIndex] == ' ')
                {
                    output = ' ' + temp + output;
                    temp = "";
                }
                else
                    temp += input[currentIndex];


                currentIndex++;

                return GetReverse(input, currentIndex, temp, output);
            }
        }
    }
}
