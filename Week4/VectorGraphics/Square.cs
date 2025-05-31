using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Square
    {
    public double Side;
    public float posX, posY;

    public Square()
    {
        Side = 1;
        posX = 0;
        posY = 0;
    }

    public Square(double side, float posX, float posY)
    {
        Side = side;
        this.posX = posX;
        this.posY = posY;
    }

    public float Area()
    {
        return 0;
    }

    public float Perimeter()
    {
        return 0;
    }

}
