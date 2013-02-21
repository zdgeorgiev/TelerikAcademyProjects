using System;

namespace DefiningClassesPartI
{
    class Display
    {
        private int displaySize;
        private decimal numbersOfColors;

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
