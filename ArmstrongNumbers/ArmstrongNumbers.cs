using System;

namespace ArmstrongNumbers
{
    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int numberToCheck)
        {
            string numberStr = numberToCheck.ToString();
            int numberOfDigits = numberStr.Length;
            int sum = 0;
            int temp = numberToCheck;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                temp /= 10;
            }

            return sum == numberToCheck;
        }
    }
}
