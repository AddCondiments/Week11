using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LessonA
{
    /*
     * Matthew Watada
     * July 25th 2017
     * This is the card class, I have no idea how it will end up
     * Version 0.2
     */
    public class Card: ICloneable
    {
        // Private Instance Variables
        private Face _face;
        private Suit _suit;

        // Public Properties

        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        // Constructors

            /// <summary>
            /// This is the main constructor for the Card class. It takes 2 parameters:
            /// face of type Face, and suit of type Suit
            /// </summary>
            /// <param name="face"></param>
            /// <param name="suit"></param>

        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        // Private Methods

        // Public Methods

        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

    }
}