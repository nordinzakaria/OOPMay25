using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VectSharp;        // package: a collection/library of classes
using VectSharp.SVG;



namespace TestVSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Width of the page.
            double width = 100;

            // Height of the page.
            double height = 100;

            // Create the page.
                // Page is a class from VectSharp
            Page page = new Page(width, height); // calling construc with 2 param

            // Get the Graphics object.
                // Graphics is a class from VectSharp
            Graphics graphics = page.Graphics;

            // Position and size of the rectangle.
            double rectangleX = 10;
            double rectangleY = 10;
            double rectangleWidth = 80;
            double rectangleHeight = 80;

            // Colour of the rectangle.
                    // Colour, Colours come from VectSharp
            Colour fillColour = Colours.Green;

            // Draw the rectangle.
            graphics.FillRectangle(rectangleX, rectangleY, rectangleWidth, rectangleHeight, fillColour);
                    // attrib or *method* or object or class?

            // Set the page background to a light grey.
            page.Background = Colour.FromRgb(200, 200, 200);

            // Output file name.
            string outputFile = "Rectangle.svg";

            // Save the page as an SVG document.
            page.SaveAsSVG(outputFile);
        }
    }
}
