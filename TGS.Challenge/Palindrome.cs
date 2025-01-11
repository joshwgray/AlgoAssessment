using System;

namespace TGS.Challenge;

/*
      Devise a function that checks if a word is a palindrome, if the word is a palindrome return true, else return false

      "Palindrome": a word, phrase, number, or sequence of characters that reads the same backward as forward, ignoring spaces, punctuation, and capitalization. For example
      Words: radar, level, madam
      Phrases: A man, a plan, a canal, Panama
      Numbers: 121, 12321

      isPalindrome("radar") should return true
      isPalindrome("delightful") should return false

      NOTE: Punctuation, including spaces should be ignored, e.g.

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */

public class Palindrome
{
    public bool isPalindrome(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(word));
        }

        return IsPalindromeCheck(word);
    }

    private static bool IsPalindromeCheck(string word)
    {
        var value = word.ToCharArray();
        Array.Reverse(value);
        var reversedWord = new string(value);
        
        if (word == reversedWord)
        {
            return true;
        }
        
        return false;
    }
}