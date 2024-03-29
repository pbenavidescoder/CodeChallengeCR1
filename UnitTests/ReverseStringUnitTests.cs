// This file was auto-generated based on version 1.1.0 of the canonical data.
//TDD File
using Xunit;
using ReverseStringChallenge;


public class ReverseStringTest
{
    [Fact]
    public void An_empty_string()
    {
        Assert.Equal("", ReverseString.Reverse(""));
    }

    [Fact]
    public void A_word()
    {
        Assert.Equal("tobor", ReverseString.Reverse("robot"));
    }

    [Fact]
    public void A_capitalized_word()
    {
        Assert.Equal("nemaR", ReverseString.Reverse("Ramen"));
    }

    [Fact]
    public void A_sentence_with_punctuation()
    {
        Assert.Equal("!yrgnuh m'I", ReverseString.Reverse("I'm hungry!"));
    }

    //[Fact(Skip = "Remove to run test")]
    [Fact]
    public void A_palindrome()
    {
        Assert.Equal("racecar", ReverseString.Reverse("racecar"));
    }
}