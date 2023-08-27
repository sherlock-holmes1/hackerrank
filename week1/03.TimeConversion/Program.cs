using System.Text;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s)
    {
        var sb = new StringBuilder(s);
        string AMPM = s.Substring(s.Length - 2, 2);
        bool isPM = AMPM == "PM";
        int hours = int.Parse(s.Substring(0, 2));
        
        if (isPM)
        {
            if (hours != 12)
            {
                hours += 12;
                sb[0] = (hours - (hours % 10)).ToString()[0];
                sb[1] = (hours % 10).ToString()[0];
            }

            return sb.ToString(0, s.Length - 2);
        }
        else if (!isPM && hours == 12)
        {
            sb[0] = '0';
            sb[1] = '0';

            return sb.ToString(0, s.Length - 2);
        }

        return s.Substring(0, s.Length - 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Path.Combine(@System.Environment.CurrentDirectory, "out.txt"), true);

        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
