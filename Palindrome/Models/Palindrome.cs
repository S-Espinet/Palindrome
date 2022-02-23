using System;

namespace Palindrome

{
  public class OttoIsAPalindrome
  {
    public string Input { get; set; }
    public OttoIsAPalindrome(string input)
    {
      Input = input;
    }

    public bool CheckPalindrome()
    {
      char[] charArray = Input.ToCharArray();
      char[] reversal = new char[charArray.Length];
      Array.Copy(charArray, reversal, charArray.Length);
      Array.Reverse(reversal);
      if (charArray == reversal)
      {
        return true;
      }
      else
      {
      return false;
      }
    }
  }
}