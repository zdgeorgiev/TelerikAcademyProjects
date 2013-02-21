using System;

namespace Constructors
{
    class Display
    {
        private int displaySize;
        private decimal numbersOfColors;

        public Display()
        {
            this.displaySize = 0;
            this.numbersOfColors = 0M;
        }

        public int DisplaySize
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }

        public decimal NumberOfColors
        {
            get { return this.numbersOfColors; }
            set { this.numbersOfColors = value; }
        }
    }
}
