
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
    
  }
}
