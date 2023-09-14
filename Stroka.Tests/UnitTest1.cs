using NUnit.Framework;

[TestFixture]
public class StringManipulationTests
{
    [Test]
    public void TestShortestWord()
    {
        string input = "������ �����, �� ��� �������.";
        string shortestWord = YourStringManipulationClass.FindShortestWord(input);
        Assert.AreEqual("��", shortestWord);
    }

    [Test]
    public void TestWordCount()
    {
        string input = "������ �����, �� ��� �������.";
        int wordCount = YourStringManipulationClass.CountWords(input);
        Assert.AreEqual(5, wordCount);
    }

    [Test]
    public void TestCharacterCount()
    {
        string input = "������ �����, �� ��� �������.";
        int charCount = YourStringManipulationClass.CountCharacters(input);
        Assert.AreEqual(29, charCount);
    }

    [Test]
    public void TestNthCharacter()
    {
        string input = "������ �����, �� ��� �������.";
        char ninthChar = YourStringManipulationClass.GetNthCharacter(input, 9);
        Assert.AreEqual('�', ninthChar);
    }

    [Test]
    public void TestDigitCount()
    {
        string input = "����3� ��3��, 3� ��� ���0���.";
        int digitCount = YourStringManipulationClass.CountDigits(input);
        Assert.AreEqual(4, digitCount);
    }

    [Test]
    public void TestMaxConsecutiveDigits()
    {
        string input = "����37 0����, �� ��� �������.";
        int maxConsecutiveDigits = YourStringManipulationClass.FindMaxConsecutiveDigits(input);
        Assert.AreEqual(2, maxConsecutiveDigits);
    }

    [Test]
    public void TestAmCount()
    {
        string input = "������ �����, �� ��� �������.";
        int amCount = YourStringManipulationClass.CountAmCombinations(input);
        Assert.AreEqual(0, amCount);
    }
}
