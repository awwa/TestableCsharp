using Moq;

namespace Testable.Test;

public class TextAnalyzerTests
{
    [Fact]
    public void ReverseNormal()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { "abcde" });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        string reversed = analyzer.Reverse();
        // Assert
        Assert.Equal("edcba", reversed);
    }

    [Fact]
    public void ReverseEmpty()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { "" });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        string reversed = analyzer.Reverse();
        // Assert
        Assert.Equal("", reversed);
    }

    [Fact]
    public void ReverseNull()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { null! });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        // Assert
        NullReferenceException actual = Assert.Throws<NullReferenceException>(() => analyzer.Reverse());
        Assert.Equal("Object reference not set to an instance of an object.", actual.Message);
    }

    [Fact]
    public void CountNormal()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { "abcde" });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        int count = analyzer.Count();
        // Assert
        Assert.Equal(5, count);
    }

    [Fact]
    public void CountEmpty()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { "" });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        int count = analyzer.Count();
        // Assert
        Assert.Equal(0, count);
    }

    [Fact]
    public void CountNull()
    {
        // Arrange
        Mock<ITextRepository> mock = new();
        mock.Setup(x => x.ReadAllLines()).Returns(new string[] { null! });
        TextAnalyzer analyzer = new(mock.Object);
        // Act
        // Assert
        NullReferenceException actual = Assert.Throws<NullReferenceException>(() => analyzer.Count());
        Assert.Equal("Object reference not set to an instance of an object.", actual.Message);
    }
}