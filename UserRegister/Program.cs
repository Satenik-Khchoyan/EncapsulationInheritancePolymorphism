using System;
using System.Collections.Generic;

namespace UserRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorfism ger koden flexibilitet.
            //Ex. bas klassens samma metod kan implementeras på olika sätt i subklasserna, beroende på deras behov.
            //Interface har bara publika medlemmar och innehåller bara definitioner.
            //Medan abstract klassen kan ha blandning av public och private. Och kan ha definitioner av abstrakta metoder
            //samt implementerade vanliga metoder.
            //Men i C# 8 Interface har också fått möjlighet att innehålla private och implementationer.
            //Så jag tror skillnaden mellan de twå är nu att vi kan ärva från flera interface, men bara en abstract klass.

            List<UserError> errorList = new List<UserError>();
            errorList.Add(new NumericInputError());
            errorList.Add(new TextInputError());
            errorList.Add(new InvalidInputError());
            errorList.Add(new MandatoryFieldInputError());
            errorList.Add(new SymbolInputError());

            foreach (var error in errorList)
            {
                Console.WriteLine( error.UEMessage() ); 
            }

            foreach (var error in errorList)
            {
                if (error is InvalidInputError)
                {
                    var invalidError = error as InvalidInputError;
                    Console.WriteLine(invalidError.UEMessage(true));
                }
                else
                    if(error is MandatoryFieldInputError)
                {
                    var mandError = error as MandatoryFieldInputError;
                    Console.WriteLine(mandError.UEMessage("error"));
                }
                else
                    if(error is SymbolInputError)
                {
                    var symbError = error as SymbolInputError;
                    Console.WriteLine(symbError.UEMessage("+"));
                }

            }
        }
    }
}
