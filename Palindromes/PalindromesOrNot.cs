using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public class PalindromesOrNot
    {
        public bool PalindromeChecker(string palindromePhrase)
        {
            string reversedPhrase;
            char[] arr = palindromePhrase.ToCharArray();
            Array.Reverse(arr);
            reversedPhrase = new string(arr);
            var finalReversal = Regex.Replace(reversedPhrase, @"[^0-9a-zA-Z]+", "");
            var finalPhrase = Regex.Replace(palindromePhrase, @"[^0-9a-zA-Z]+", "");
            bool isPalindrome = finalPhrase.Equals(finalReversal, StringComparison.OrdinalIgnoreCase);

            if (isPalindrome == true)
            {
                return true;
            }
            return false;
        }
    }
}
