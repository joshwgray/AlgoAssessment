using System;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
        if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
        {
          throw new ArgumentException("word is null or empty");
        }
        word1 = NormalizeString(word1);
        word2 = NormalizeString(word2);

        word1 = SortString(word1);
        word2 = SortString(word2);
        
        return word1 == word2;
      }

      private static string SortString(string word)
      {
        char[] result = word.ToCharArray();
        for (int i = 0; i < result.Length - 1; i++)
        {
          for (int j = 0; j < result.Length - i - 1; j++)
          {
            if (result[j] > result[j + 1])
            {
              //swap the characters
              char temp = result[i];
              result[j] = result[j + 1];
              result[j + 1] = temp;
            }
          }
        }
        return new string(result);
      }

      private static string NormalizeString(string word)
      {
        char[] result = new char[word.Length];
        int index = 0;

        foreach (char c in word)
        {
          if (char.IsLetter(c))
          {
            result[index++] = char.ToLower(c);
          }
        }
        
        return new string(result);
      }
    }
}
