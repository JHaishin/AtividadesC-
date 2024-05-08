// See https://aka.ms/new-console-template for more information
[TestFixture]
public class EmailValidatorTests
{
    private EmailValidator validator;

    [SetUp]
    public void SetUp()
    {
        validator = new EmailValidator();
    }

    [Test]
    public void IsValidEmailFormat_ValidEmail_ReturnsTrue()
    {
        // Arrange
        string email = "example@example.com";

        // Act
        bool result = validator.IsValidEmailFormat(email);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidEmailFormat_InvalidEmail_ReturnsFalse()
    {
        // Arrange
        string email = "invalidemail";

        // Act
        bool result = validator.IsValidEmailFormat(email);

        // Assert
        Assert.IsFalse(result);
    }
}

[Test]
public void IsDomainActive_ActiveDomain_ReturnsTrue()
{
    // Arrange
    string email = "example@example.com";

    // Act
    bool result = validator.IsDomainActive(email);

    // Assert
    Assert.IsTrue(result);
}

[Test]
public void IsDomainActive_InactiveDomain_ReturnsFalse()
{
    // Arrange
    string email = "example@nonexistentdomain.com";

    // Act
    bool result = validator.IsDomainActive(email);

    // Assert
    Assert.IsFalse(result);
}


[Test]
public void IsMailServerResponding_ServerResponding_ReturnsTrue()
{
    // Arrange
    string email = "example@example.com";

    // Act
    bool result = validator.IsMailServerResponding(email);

    // Assert
    Assert.IsTrue(result);
}

[Test]
public void IsMailServerResponding_ServerNotResponding_ReturnsFalse()
{
    // Arrange
    string email = "example@nonexistentdomain.com";

    // Act
    bool result = validator.IsMailServerResponding(email);

    // Assert
    Assert.IsFalse(result);
}


