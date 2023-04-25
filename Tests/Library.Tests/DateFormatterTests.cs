


namespace TestDateFormat;

public class DateFormatterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDateFormatOk()
    {
        const string input = "10/11/1997";
        const string expected = "1997-11-10";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void WrongDateFormat()
    {
        const string input = "10/11/197";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void BlankDate()
    {
        const string input = "";
        const string expected = "escriba una fecha";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

}