using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Matthew Watada
 * July 27th 2017
 * Version 0.6 - Inherits fromt the CardList class...
 */

namespace LessonA
{
    public class Hand : CardList
    {
        // Private Instance variables

        // Public Properties

        // (No need for) Constructors

        // Private Methods
        protected override void _initialize()
        {
            throw new NotImplementedException();
        }

        // Public Methods

        /// <summary>
        /// Overrides the base ToString() method.
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            string outputString = "";
            outputString += "The hand contains: /n";
            outputString += "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
    }
}