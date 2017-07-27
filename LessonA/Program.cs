using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Matthew Watada
 * Tuesday July 25th 2017
 * Description: Supposedly doing some sort of card game.
 * Version 0.1 Created the Face and Suit enum, addeed members via the class diagram.
 * 
 */


namespace LessonA
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckofCards deck = new DeckofCards();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
        }
    }

    // Aron pointed out that i didn't put the _initialize() mehtod in the DeckofCards class constructor.
}
