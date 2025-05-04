namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void OldPhonePad_ReturnOK()
    {
        string padInput = "5552887772#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("LAURA", output);
    }

    [Fact]
    public void OldPhonePad_HandleBackspace()
    {
        string padInput = "8 88777444666*664#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("TURING", output);
    }

    [Fact]
    public void OldPhonePad_HandleSpaces()
    {
        string padInput = "227778866 666#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("BRUNO", output);
    }

    [Fact]
    public void OldPhonePad_HandleInvalidNumberGroup()
    {
        string padInput = "5552887777772#";
        
        string output = OldPhone.OldPhonePad(padInput);

        Assert.Equal("-1", output);
    }
}
