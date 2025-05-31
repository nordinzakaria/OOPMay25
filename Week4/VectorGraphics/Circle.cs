using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle
    {
    // attributes / field
    public float radius;
    public float posX, posY;

    public Circle()
        {
        radius = 1;
        posX = 0;
        posY = 0;
        }

     public Circle(float radius, float posX, float posY)
        {
        radius = radius;

        // this: current object
        this.posX = posX;
        this.posY = posY;
    }


    // methods
    public float Area()
    {
        return (float) Math.PI * radius * radius;
    }

    public float Perimeter()
    {
        return 0;
    }

}
