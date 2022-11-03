namespace MVCEmpty.Models
{
    public class TempCheck
    {
        public static string TempTest(double temp)
        {
                if (temp >= 40)
                    return "You have a deadly fever";
                if (temp > 37 && temp < 40)
                    return "You have a small fever";
                if (temp == 37)
                    return "Your body temperature is normal";
                if (temp < 37)
                    return "You are freezing";
                else
                    return "please input a valid number";
        }
    }
}
