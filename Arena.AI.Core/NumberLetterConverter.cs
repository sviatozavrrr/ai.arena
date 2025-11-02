namespace Arena.AI.Core;

public static class NumberLetterConverter
{
    const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static char GetLetter(int number)
    {
        if(number >= 1 && number <=28)
        {
            return UppercaseLetters[number - 1];
        }

        throw new ArgumentOutOfRangeException();
    }

    public static int GetNumber(char letter)
    {
        var index = UppercaseLetters.IndexOf(letter);
        if(index >= 0)
        {
            return index + 1;
        }

        throw new ArgumentOutOfRangeException();
    }
}
