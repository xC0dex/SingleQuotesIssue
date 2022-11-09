using Xunit;
using System.Text.Json;
using BlazorQuoteIssue;
using BlazorSingleQuotesIssue;
using Bunit;
using FluentAssertions;

namespace BlazorSingleQuoteIssue;

public class AppTest : TestContext
{
    [Fact]
    public void Should_RenderAndDisplaySingleQuotesCorrectly()
    {
        // Arrange
        var user = new User("Justin", 24);
        var serializedUser = JsonSerializer.Serialize(user);
        var cut = RenderComponent<UserComponent>(parameters => parameters
            .Add(p => p.User, user));

        // Assert
        var divElement = cut.Find("p");
        var singleQuotes = divElement.Attributes.GetNamedItem("data-single-quotes");
        singleQuotes!.Value.Should().Be(serializedUser);
    }

    [Fact]
    public void Should_RenderAndDisplayDoubleQuotesCorrectly()
    {
        // Arrange
        var user = new User("Justin", 24);
        var serializedUser = JsonSerializer.Serialize(user);
        var cut = RenderComponent<UserComponent>(parameters => parameters
            .Add(p => p.User, user));

        // Assert
        var divElement = cut.Find("p");
        var doubleQuotes = divElement.Attributes.GetNamedItem("data-double-quotes");
        doubleQuotes!.Value.Should().Be(serializedUser);
    }
}