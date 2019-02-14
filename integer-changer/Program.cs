using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using integer_changer;

namespace integer_changer
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Having fun with math");
            int answer = PromptForInteger();
            Console.WriteLine("Oh, you like " + answer + ", do you? Just wait til you see what I'm going to do with " + answer);
            Console.WriteLine("Function1(" + answer + ") = " + Class1.ChangeMyIntA(answer).ToString());
            Console.WriteLine("Function2(" + answer + ") = " + Class1.ChangeMyIntB(answer).ToString());
            Console.WriteLine("Function3(" + answer + ") = " + Class1.ChangeMyIntC(answer).ToString());
            Console.WriteLine("How do you like that? Ha. Your precious " + answer + " ain't so tough.");
            Console.Read();
        }
        static int PromptForInteger()
        {
            Console.Write("What's your favorite integer?");
            int usersFavoriteInteger = 0;
            bool goodAnswerReceived = false;
            while (goodAnswerReceived == false)
                try
                {
                    usersFavoriteInteger = Convert.ToInt32(Console.ReadLine());
                    goodAnswerReceived = true;
                    return usersFavoriteInteger;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("That was not an integer, please give me your favorite integer. I need it to have fun");
                }
            return 0;
        }
    }
}
