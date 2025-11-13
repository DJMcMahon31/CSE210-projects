using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();
        string[] parts = text.Split("");
        foreach (string part in parts)
        {

        }


        public string GetDisplayText()
        {
            Console.WriteLine("reference");
            Console.WriteLine("List<Word>");
        }
        /*_words = text.Split("")
                     .Select(word => new Word())*/



        /*HideRandomWords(numberToHide:int) : void;
        GetDisplayText():string;
        IsCompletelyHidden():bool;
        */
    }


}

//static void DisplayMessage()

//refer reference class file and word class file
//data type is going to be the class
//reference John 3;16();