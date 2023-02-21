using System.Collections.Generic; //grants access to lists
namespace Anagrams.Models
{
  public class AnagramsFinder//passes 1st test
  {
    public static bool IsAnagrams(string word1, string word2) //false, theFalseReturn.IsAnagrams 
    {
      if(word1.Length != word2.Length) 
      {//added to pass 4th
        return false;
      }
      List<char> lettersInWord1 = new List<char>();  //char is data type of letter for example myChar = 'e' can only be 1 letter instead of string  

      foreach(char letter in word1) //letter is variable we are using to access char
      {
        lettersInWord1.Add(letter);//.Add is fucntion of a list. list is decalared by list and what is in bracket
      }
      foreach(char letter in word2)
      {
        if(!lettersInWord1.Contains(letter))//lists have contains function as well. list is like java array
        {
          return false; //passes second test
        }
      }
      return true; 
    }

    public static List<string> IsAnagramsFromList(string wordToCompare, List<string> words)
    {
      List<string> stringsToReturn = new List<string>();
      foreach(string word in words) 
      {
        if(IsAnagrams(wordToCompare, word)) 
        {
          stringsToReturn.Add(word);
        }
      }
      return stringsToReturn;// all of the above passes 5th test-- declares empty list, if anagrams returns true, add it to list and returns list
    }
  }
}