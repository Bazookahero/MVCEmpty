using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MVCEmpty.Properties.Controllers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MVCEmpty.Models
{
    public class GuessTest : GuessController
    {

        
        public static int RandomNumber()
        {
            int rndNumber;
            Random rnd = new Random();
            rndNumber = rnd.Next(101);
            return rndNumber;
        }
        public static string GuessCheck(int guess, string storedNum)
        {
            int p = int.Parse(storedNum);
            if (guess == p)
            {
                return "Congratulations, you won!";
            }
            if (guess < p)
            {
                return "Your guess was too small";
            }
            if (guess > p)
            {
                return "Your guess was too big";
            }
            else
            {
                return "error";
            }
        }
        //public static int GuessC(int guess) 
        //{ 
        //    int rndnum = RandomNumber(guess)
        //    if (guess != 0)
        //    {
        //        while (guess != rndnum)
        //        {
        //            if (guess > rndnum)
        //                viewbag.msg = "your guess was too high";
        //            if (guess < rndnum)
        //                viewbag.msg = "your guess was too low";
        //            return view();
        //        }
        //        if (guess == rndnum)
        //        {
        //            viewbag.msg = "congratulations, you won!";
        //            models.guesstest.randomnumber();
        //            rndnum = models.guesstest.randomnumber;
        //            return view();
        //        }
        //    }
        //    }
    }
}
