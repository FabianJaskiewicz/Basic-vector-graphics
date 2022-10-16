using System;

class Rectangle{

    private int x { get; set; }
    private int y { get; set; }
    private int width { get; set; }
    private int height { get; set; }
    private string fill { get; set; }
    private int strokeWidth { get; set; }
    private string strokeColour { get; set; }

    private string[] colours = {"black", "silver", "gray", "white", "white", "maroon", "red", "purple", "fuchsia", "green", "lime", "olive", "yellow", "navy", "blue", "teal", "aqua"};

    //Default rectangle
    public Rectangle(){
        x = 500;
        y = 500;
        width = 100;
        height = 100;
        fill = "gray";
        strokeWidth = 1;
        strokeColour = "black";
    }
    public Rectangle(int x, int y, int width, int height, string fill, int strokeWidth, string strokeColour){
        this.x = x;
        this.y = y;
        this.width = width;
        this.height= height;
        this.fill = fill;
        this.strokeWidth = strokeWidth;
        this.strokeColour = strokeColour;
    }

    public string draw(){
        return "<rect x=\"" + x + "\"" + " y=\"" + y + "\"" + " width=\"" + width + "\"" + " height=\"" + height + "\"" + " style=\"fill:" + fill + ";stroke-width:" + strokeWidth + ";stroke:"+ strokeColour + "\"" +  "/>";
    }
}