namespace CSharpDay5
{
    #region Parent Class
    public class HtmlElement
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual void Render()
        {
            Console.WriteLine($"{Type} {Value} {Type}");
        }
    }
    #endregion

    public class ImgElement : HtmlElement
    {
        public string Src { get; set; }

        public ImgElement(string src)
        {
            Type = "Img";
            Src = src;
        }

        public override void Render()
        {
            Console.WriteLine($"Type : {Type} <> Src : {Src}");
        }
    }

    public class TextElement : HtmlElement
    {
        public string FontSize { get; set; }
        public string FontColor { get; set; }
    }

    public class H1Element : TextElement
    {
        public H1Element(string value, string fontSize, string fontColor)
        {
            Type = "Html";
            Value = value;
            FontSize = fontSize;
            FontColor = fontColor;
        }

        public override void Render()
        {
            Console.WriteLine($"fontSize : {FontSize} color : {FontColor} < {Value} >< {Type} >");
        }
    }


    public class H2Element : TextElement
    {
        public H2Element(string value, string fontSize, string fontColor)
        {
            Type = "Img";
            Value = value;
            FontSize = fontSize;
            FontColor = fontColor;
        }

        public override void Render()
        {
            Console.WriteLine($"{Type} fontSize : {FontSize} color : {FontColor} < {Value} >< {Type} >");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HtmlElement> List_elements = new List<HtmlElement>
            {
              new ImgElement("Html"), new H1Element("Html", "300", "Red"), new H2Element("Html", "493", "Red")
            };

            foreach (var element in List_elements)
            {
                element.Render();
            }
        }
    }
}
