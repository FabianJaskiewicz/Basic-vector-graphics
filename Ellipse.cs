using System;

class Ellipse{

    private int cx;
    private int cy;
    private int rx;
    private int ry;
    private string fill;
    private int strokeWidth;
    private string strokeColour;

    public Ellipse(){
        cx = 150;
        cy = 150;
        rx = 100;
        ry = 50;
        fill = "yellow";
        strokeWidth = 4;
        strokeColour = "orange";
    }

    public Ellipse(int cx, int cy, int rx, int ry, string fill, int strokeWidth, string strokeColour){
        this.cx = cx;
        this.cy = cy;
        this.rx = rx;
        this.ry = ry;
        this.fill = fill;
        this.strokeWidth = strokeWidth;
        this.strokeColour = strokeColour;
    }

    public string draw(){
        return "<ellipse cx=\"" + cx + "\"" + " cy=\"" + cy + "\"" + "rx=\"" + rx + "\"" + " ry=\"" + ry + "\"" +  " style=\"fill:" + fill + ";stroke-width:" + strokeWidth + ";stroke:"+ strokeColour + "\"" +  "/>";
    }
}