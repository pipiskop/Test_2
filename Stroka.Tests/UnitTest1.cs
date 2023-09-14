using NUnit.Framework;

[TestFixture]
public class StringManipulationTests
{
    [Test]
    public void TestShortestWord()
    {
        string input = "Придет осень, за все спросит.";
        string shortestWord = YourStringManipulationClass.FindShortestWord(input);
        Assert.AreEqual("за", shortestWord);
    }

    [Test]
    public void TestWordCount()
    {
        string input = "Придет осень, за все спросит.";
        int wordCount = YourStringManipulationClass.CountWords(input);
        Assert.AreEqual(5, wordCount);
    }

    [Test]
    public void TestCharacterCount()
    {
        string input = "Придет осень, за все спросит.";
        int charCount = YourStringManipulationClass.CountCharacters(input);
        Assert.AreEqual(29, charCount);
    }

    [Test]
    public void TestNthCharacter()
    {
        string input = "Придет осень, за все спросит.";
        char ninthChar = YourStringManipulationClass.GetNthCharacter(input, 9);
        Assert.AreEqual('е', ninthChar);
    }

    [Test]
    public void TestDigitCount()
    {
        string input = "Прид3т ос3нь, 3а все спр0сит.";
        int digitCount = YourStringManipulationClass.CountDigits(input);
        Assert.AreEqual(4, digitCount);
    }

    [Test]
    public void TestMaxConsecutiveDigits()
    {
        string input = "Прид37 0сень, за все спросит.";
        int maxConsecutiveDigits = YourStringManipulationClass.FindMaxConsecutiveDigits(input);
        Assert.AreEqual(2, maxConsecutiveDigits);
    }

    [Test]
    public void TestAmCount()
    {
        string input = "Придет осень, за все спросит.";
        int amCount = YourStringManipulationClass.CountAmCombinations(input);
        Assert.AreEqual(0, amCount);
    }
}
