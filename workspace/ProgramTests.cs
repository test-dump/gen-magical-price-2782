using System;
using System.IO;
using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    private StringWriter stringWriter;

    [SetUp]
    public void SetUp()
    {
        stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
    }

    [Test]
    public void Main_PrintsHelloWorld()
    {
        // Arrange
        string expected = "Hello World" + Environment.NewLine;

        // Act
        Program.Main(new string[] { });

        // Assert
        Assert.AreEqual(expected, stringWriter.GetStringBuilder().ToString());
    }

    [TearDown]
    public void TearDown()
    {
        stringWriter.Close();
    }
}
