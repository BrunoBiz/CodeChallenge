namespace CodeChallenge.Tests;

public class UnitTest1
{
    
    // No asterisks, no spaces, valid return value
    [Fact]
    public void OldPhonePad_ReturnOK()
    {
        string padInput = "5552887772#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("LAURA", output);
    }

    // Asterisks, no spaces, valid return value
    [Fact]
    public void OldPhonePad_HandleBackspace()
    {
        string padInput = "555288*7772*#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("LAR", output);
    }

    // No asterisks, spaces, valid return value
    [Fact]
    public void OldPhonePad_HandleSpaces()
    {
        string padInput = "227778866 666#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("BRUNO", output);
    }

    // Asterisks, spaces, valid return value
    [Fact]
    public void OldPhonePad_HandleSpacesBackspaces()
    {
        string padInput = "8 88777444666*664#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("TURING", output);
    }

    // Number group over 4 numbers long, invalid return value (Default "-1")
    [Fact]
    public void OldPhonePad_HandleInvalidNumberGroup()
    {
        string padInput = "5552887777772#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("-1", output);
    }
}
