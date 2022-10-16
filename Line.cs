using System;

class Line{

    private int x1;
    private int y1;
    private int x2;
    private int y2;
    private string strokeColour;
    private int strokeWidth;

    public Line(){
        x1 = 0;
        y1 = 0;
        x2 = 200;
        y2 = 200;
        strokeWidth = 2;
        strokeColour = "green";
    }

    public Line(int x1, int y1, int x2, int y2, string strokeColour, int strokeWidth){
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.strokeColour = strokeColour;
        this.strokeWidth = strokeWidth;
    }

    public string draw(){
        return "<line x1=\"" + x1 + "\"" + " y1=\"" + y1 + "\"" + " x2=\"" + x2 + "\"" + " y2=\"" + y2 + "\"" + " stroke=\"" + strokeColour + "\"" + " stroke-width=\"" + strokeWidth + "\"" + "/>";
    }
}