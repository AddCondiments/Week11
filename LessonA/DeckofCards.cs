using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LessonA
{
    /* Matthew Watada
     * July 25th 2017
     * This is some kind of magic, we turnede a class into a list.
     * A class that inherits from the list collection, and creates a list of type Card.
     * Version 0.4 - Adding public shuffle method, and clone interface.
     */
    public class DeckofCards:List<Card>
    {
        // Private Instance Variables

        private Random _random;

        // Private Properties

        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // Public Properties

        // Constructors

            /// <summary>
            /// Main/Default constructor, this takes no arguments.
            /// </summary>

        public DeckofCards()
        {
            _initialize();
        }

        // Private Methods

            /// <summary>
            /// This is the private _initialize method that creates a deck of (4x13) 52 cards in a for nested for loop.
            /// Initializes other private variables.
            /// </summary>

        private void _initialize()
        {
            // Initialize the random object
            this._random = new Random();

            // Load list with cards.
            for (int suit = 0; suit < (int)Suit.Spades; suit++)
            {
                for(int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // Trying to keep up with Tom is a goddamn nightmare..

        // Public Methods

            /// <summary>
            /// This is the public oveerride "ToString()" method. Returns a string filled with the entire deck (this), and returns.  
            /// </summary>
            /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        public void shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {

                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }

        }
    }
}