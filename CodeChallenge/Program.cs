// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

class OldPhone 
{
    // Build the input string
    // In OldPhonePad, replace each number group for the correct letter
    // 33444 44 444555 -> EIHIL


    static void Main(string[] args)
    {
        //OldPhonePad("123#");
        //OldPhonePad("1*23*#");
        //OldPhonePad("*1*23*#");
        OldPhonePad("8 88777444666*664#");
        OldPhonePad("227*#");
    }

    public static String OldPhonePad(String input){
        // Removes asterisks
        removeAsterisk(ref input);

        Console.Write(input + "\r\n");

        return "";
    }

/// <summary>
/// Removes any asterisk from the main input received through the OldPhonePad method.
/// This method is recursive and will call itself until every asterisk is removed.
/// </summary>
/// <param name="input"> The sequence of keypad presses from the OldPhonePad </param>
    private static void removeAsterisk (ref String input) {
        int pos;
        
        // Checks if there is any asterisk in input string
        pos = input.IndexOf("*");
        switch (pos) {
            case -1: // No asterisk found, returns
                break;

            case 0: // Asterisk found as first character, he is the only one removed;
                input = input.Remove(pos, 1);
                removeAsterisk(ref input);
                break;

            default: // Valid asterist found, it's removed alongside the previous character;
                input = input.Remove(pos -1, 2);
                removeAsterisk(ref input);
                break;
        }

        return;
    }
}

