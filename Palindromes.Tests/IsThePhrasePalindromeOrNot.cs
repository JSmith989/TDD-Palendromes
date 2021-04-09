using System;
using Xunit;

namespace Palindromes.Tests
{
    public class IsThePhrasePalindromeOrNot
    {
        [Theory]
        [InlineData("stats", true)]
        [InlineData("Some men interpret nine memos", true)]
        [InlineData("Amore, Roma", true)]
        [InlineData("Was it a cat I saw?", true)]
        public void the_phrase_entered_is_a_palendrome(string palindromePhrase, bool isPalindrome)
        {
            //Arrange
            var translator = new PalindromesOrNot();
            //Act
            var actualResult = translator.PalindromeChecker(palindromePhrase);
            //Assert
            Assert.Equal(isPalindrome, actualResult);
        }
    }
}
