
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

    public void IsAnagrams_ReturnsFalseIfNotAnagrams()
    {
      AnagramsFinder theFalseReturn = new AnagramsFinder();
      Assert.AreEqual(false, theFalseReturn.IsAnagrams("pizza", "beard")); 
    }

    [TestMethod]

    public void IsAnagrams_ReturnsTrueIfAnagrams()
    {
      AnagramsFinder aFinder = new AnagramsFinder();
      Assert.AreEqual(true, aFinder.IsAnagrams("beard", "bread"));
    }
  }
}
