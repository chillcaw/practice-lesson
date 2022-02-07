using System;

public class Program
{
    public static void Main()
    {    
        while (true) {
            Console.WriteLine("Enter a number: (x to exit)");
            string input = Console.ReadLine();

            if (input == "x") {
                break;    
            } else {
                int n = Convert.ToInt32(input);

                bool isPrime = true;
                bool endsIn5Or3 = false;
                bool digitsAddToTen = false;

                for (int i = n - 1; i > 1; --i) {
                    if (n % i == 0) {
                        isPrime =  false;
                    }
                }

                char[] chars = n.ToString().ToCharArray();
                string[] digits = new string[chars.Length];

                for (int i = 0; i < chars.Length; ++i) {
                    digits[i] = chars[i].ToString();
                }

                int sum = 0;
                for (int i = 0; i < digits.Length; ++i) {
                    sum += Convert.ToInt32(digits[i]);
                }

                if (sum % 10 == 0) {
                    digitsAddToTen = true;
                }

                Console.WriteLine(Convert.ToInt32(digits[digits.Length - 1]));

                if (Convert.ToInt32(digits[digits.Length - 1]) == 3 || Convert.ToInt32(digits[digits.Length - 1]) == 5) {
                    endsIn5Or3 = true;
                }

                Console.WriteLine(isPrime);
                Console.WriteLine(endsIn5Or3);
                Console.WriteLine(digitsAddToTen);

                if (isPrime && endsIn5Or3 && digitsAddToTen) {
                    Console.WriteLine("Number is very interesting");    
                } else if ((isPrime && endsIn5Or3) || (endsIn5Or3 && digitsAddToTen) || (isPrime && digitsAddToTen)) {
                    Console.WriteLine("Number is intersting");    
                } else if (isPrime || endsIn5Or3 || digitsAddToTen) {
                    Console.WriteLine("Number is okay");
                } else {
                    Console.WriteLine("Number is boring");    
                }    
            }
        }    
    }
}