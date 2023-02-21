
using Anagrams.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramsTest //class corresponds to file
  {
    [TestMethod]
    public void AnagramsFinderConstructor_CreatesInstanceOfAnagramsFinder_AnagramsFinder()
    {
      AnagramsFinder theAnagrams = new AnagramsFinder();
      Assert.AreEqual(typeof(AnagramsFinder), theAnagrams.GetType());
    }

    [TestMethod]

    public void IsAnagrams_ReturnsFalseIfNotAnagrams_Bool()
    {
      Assert.AreEqual(false, AnagramsFinder.IsAnagrams("pizza", "beard")); 
    }

    [TestMethod]

    public void IsAnagrams_ReturnsTrueIfAnagrams_Bool()
    {
      Assert.AreEqual(true, AnagramsFinder.IsAnagrams("beard", "bread"));
    }

    [TestMethod]

    public void IsAnagrams_ReturnsFalseIfLengthsAreDifferent_Bool()
    {
      Assert.AreEqual(false, AnagramsFinder.IsAnagrams("racecar", "rracecar"));
    }

    [TestMethod]
    
    public void IsAnagramsFromList_ReturnsListOfWordsThatAreAnagrams_List() 
    {
      string wordToCompare = "beard";
      List<string> words = new List<string>();
      words.Add("bread");
      words.Add("berad");
      words.Add("dearb");
      words.Add("pizza");
      words.Add("ttttt");
      List<string> answerWords = new List<string>();
      answerWords.Add("bread");
      answerWords.Add("berad");
      answerWords.Add("dearb");
      List<string> testAnswers = AnagramsFinder.IsAnagramsFromList(wordToCompare, words);
      foreach(string word in testAnswers) 
      {
        Assert.AreEqual(true, answerWords.Contains(word));
      }
    }
  }
}
