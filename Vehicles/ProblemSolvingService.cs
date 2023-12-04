namespace Vehicles;

public class ProblemSolvingService
{
    public string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        return new string(charArray);
    }

    public bool IsPalindrome(string s)
    {
        s = s.ToLower();

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public IEnumerable<int> MissingElements(int[] arr)
    {
        List<int> missingElements = new List<int>();

        if (arr.Length == 0)
        {
            return missingElements;
        }

        int expected = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != expected)
            {
                while (expected < arr[i])
                {
                    missingElements.Add(expected);
                    expected++;
                }
            }

            expected++;
        }

        return missingElements;
    }
}
