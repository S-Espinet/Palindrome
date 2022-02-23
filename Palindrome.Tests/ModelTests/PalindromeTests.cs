using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class OttoIsAPalindromeTests
  {
    [TestMethod]
    public void CheckPalindrome_ReturnInput_False()
    {
      OttoIsAPalindrome testPalindrome = new OttoIsAPalindrome ("otter");
      Assert.AreEqual(false, testPalindrome.CheckPalindrome());
    }

    [TestMethod]
    public void CheckPalindrome_Checks_True()
    {
      OttoIsAPalindrome testPalindrome = new OttoIsAPalindrome("otto");
      Assert.AreEqual(true, testPalindrome.CheckPalindrome());
    }
  }
}