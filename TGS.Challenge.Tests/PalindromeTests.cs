using System;
using Xunit;

namespace TGS.Challenge.Tests;

public class PalindromeTests
{
    private readonly Palindrome _palindrome;

    public PalindromeTests()
    {
        this._palindrome = new Palindrome();
    }
    
    [Fact]
    public void Word_IsRequired()
    {
        Assert.Throws<ArgumentException>(() => _palindrome.isPalindrome(string.Empty));
    }
    
    [Fact]
    public void hello_Returns_True_()
    {
        var result = _palindrome.isPalindrome("hello");

        Assert.False(result);
    }
    
    [Fact]
    public void level_Returns_True_()
    {
        var result = _palindrome.isPalindrome("level");

        Assert.True(result);
    }
}