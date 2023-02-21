using System;
using Anagrams.Models;
using System.Collections.Generic;

namespace Anagrams {

  class Program {

    public static void Main() {
      Console.WriteLine("Enter a word:");
      string word1 = Console.ReadLine();
      Console.WriteLine("Enter a word to compare it to:");
      string word2 = Console.ReadLine();
      Console.WriteLine(AnagramsFinder.IsAnagrams(word1, word2));
      Console.ReadLine();
    }

  }

}