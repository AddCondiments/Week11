using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Matthew Watada
 * July 27th 2017
 * Version 0.5 - This will be interesting...
 */

namespace LessonA
{
    public abstract class CardList: List<Card>
    {
        // Private Instance variables

        // Public Properties

        // Constructors
        public CardList()
        {
            this._initialize();
        }

        // Private methods

        protected abstract void _initialize();

        // Public Methods
    }
}