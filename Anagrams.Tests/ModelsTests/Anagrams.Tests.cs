
using Anagrams.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
  }
}
