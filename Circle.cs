using System;

class Circle{

    private int cx;
    private int cy;
    private int r;
    private string stroke;
    private int strokeWidth;
    private string fill;

    public Circle(){
        cx = 250;
        cy = 250;
        r = 50;
        stroke = "black";
        strokeWidth = 2;
        fill = "green";
    }

    public Circle(int cx, int cy, int r, string stroke, int strokeWidth, string fill){
        this.cx = cx;
        this.cy = cy;
        this.r = r;
        this.stroke = stroke;
        this.strokeWidth = strokeWidth;
        this.fill = fill;
    }

    public string draw(){
        return "<circle cx=\"" + cx + "\"" + " cy=\"" + cy + "\"" + "r=\"" + r + "\"" + " stroke=\"" + stroke + "\"" + " stroke-width=\"" + strokeWidth + "\"" + " fill=\"" + fill + "\"" + "/>";
    }
}