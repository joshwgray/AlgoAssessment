using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(value));
            }
            
            return GetVowelCount(value);
        }

        private int GetVowelCount(string value)
        {
            var word = value.ToLower().ToCharArray();
            var vowelCount = 0;
            
            foreach (var character in word)
            {
                if (IsVowel(character))
                {
                    vowelCount += 1;
                }
            }

            return vowelCount;
        }

        private bool IsVowel(char character)
        {
            bool isVowel = false;
            var vowelArray = "aeiou".ToCharArray();
            foreach (var vowel in vowelArray)
            {
                if (character == vowel)
                {
                    isVowel = true;
                }
            }

            return isVowel;
        }
    }
}
