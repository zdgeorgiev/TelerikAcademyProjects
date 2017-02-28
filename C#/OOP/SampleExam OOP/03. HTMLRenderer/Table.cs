using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HTMLRenderer
{
    public class Table : Element, ITable
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        private const string TableName = "table";
        private readonly IElement[,] childElements;

        public Table(int rows, int cols) : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.childElements = new IElement[rows, cols];
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.childElements[row, col];
            }
            set
            {
                this.childElements[row,col] = value;
            }
        }

        public string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("Tables cannot have text content.");
            }
        }

        public void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    this.childElements[row, col].Render(output);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Render(result);
            return result.ToString();
        }
    }
}
