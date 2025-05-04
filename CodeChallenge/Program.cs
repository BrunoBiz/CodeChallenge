// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

public class OldPhone 
{
    public static Dictionary<string, string> keyPadValues = new Dictionary<string, string>(){
        {" "   , "_"},
        {"111" , "("},
        {"11"  , "'"},
        {"1"   , "&"},
        {"222" , "C"},
        {"22"  , "B"},
        {"2"   , "A"},
        {"333" , "F"},
        {"33"  , "E"},
        {"3"   , "D"},
        {"444" , "I"},
        {"44"  , "H"},
        {"4"   , "G"},
        {"555" , "L"},
        {"55"  , "K"},
        {"5"   , "J"},
        {"666" , "O"},
        {"66"  , "N"},
        {"6"   , "M"},
        {"7777", "S"},
        {"777" , "R"},
        {"77"  , "Q"},
        {"7"   , "P"},
        {"888" , "V"},
        {"88"  , "U"},
        {"8"   , "T"},
        {"9999", "Z"},
        {"999" , "Y"},
        {"99"  , "X"},
        {"9"   , "W"},
        {"_"   , "" },
        {"0"   , " "},
        {"#"   , "" },

    };

    // In OldPhonePad, replace each number group for the correct letter
    // 33444 44 444555 -> EIHIL

    static void Main(string[] args)
    {
        Console.Write(OldPhonePad("8 88777444666*664#"));
        //Console.Write(OldPhonePad("227778866 666#"));
        //Console.Write(OldPhonePad("5552887772#"));


    }

    public static String OldPhonePad(String input){
        // currentNumber -> current number in the for loop that runs the length of the input string
        // currentGroup -> current group of numbers being checked, i.e., "22", "333", "8"...
        // returnValue -> transformed output of the function
        string currentNumber = "", currentGroup = "", returnValue = "";
        
        // Runs the length of the string, checking for the number groups
        for (int i = 0; i < input.Length; i++){
            //  Current number in the for loop
            currentNumber = input[i].ToString();
            // If the current number matches the current group, or if the group is empty, it gets added to the end;
            if ((currentGroup.Contains(currentNumber) | currentGroup == "") & currentNumber != "*"){
                currentGroup = currentGroup + currentNumber;

            // If the current "number" is an empty string, it means the user has input a value with the same number as the previous group, adds the current group, and resets the variable for the next one
            } else if (currentNumber == " ") {
                if (!addKey(ref returnValue, currentGroup)){
                    break;
                }
                currentGroup = "";

            // If the current numer is an asterisk, does not add the current group;
            }else if (currentNumber == "*") {
                currentGroup = "";

            // If the current number does not match the current group, the current group is done, it gets added and the group starts again with the new value
            } else {
                if (!addKey(ref returnValue, currentGroup)){
                    break;
                }
                currentGroup = currentNumber;
            }
        }

        return returnValue;
    }

    private static bool addKey (ref String outputString, String dictionaryKey) {
         // Checks if the key exists in the dictionary
         if (keyPadValues.ContainsKey(dictionaryKey)){
            outputString = outputString + keyPadValues[dictionaryKey];
            return true;
         } else {
            outputString = "-1"; // Default value for invalid input
            return false; 
         }
    }
}