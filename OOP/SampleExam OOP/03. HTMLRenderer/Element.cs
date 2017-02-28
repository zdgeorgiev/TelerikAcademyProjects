using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLRenderer
{
    public class Element : IElement
    {
        private readonly List<IElement> childElements;
        private readonly string name;
        public string TextContent { get; set; }

        public Element(string name = null, string content = null)
        {
            this.name = name;
            this.TextContent = content;
            this.childElements = new List<IElement>();
        }

        public string Name
        {
            get { return name; }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                output.Append("<" + this.Name + ">");
            }

            if (!string.IsNullOrEmpty(this.TextContent))
            {
                output.Append("<" + ConvertTheText(this.TextContent) + ">");
            }

            if (this.childElements.Count != 0)
            {
                foreach (var element in this.childElements)
                {
                    output.Append(element);
                }
            }

            if (!string.IsNullOrEmpty(this.Name))
            {
                output.Append("</" + this.Name + ">");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Render(result);
            return result.ToString();
        }

        private string ConvertTheText(string text)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                switch (currentChar)
                {
                    case '<': result.Append("&lt;"); break;
                    case '>': result.Append("&gt;"); break;
                    case '&': result.Append("&amp;"); break;
                    default:
                        result.Append(currentChar); break;
                }
            }

            return result.ToString();
        }
    }
}
