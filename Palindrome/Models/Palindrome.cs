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
      char[] charArray = Input.ToUpper().ToCharArray();
      Array.Reverse(charArray);
      string stringedCharArray = String.Join("", charArray);
      if (Input.ToUpper() == stringedCharArray)
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