using System;

class Polygon{
    private int x;
    private int y;
    private string fill;
    private string strokeColour;
    private int strokeWidth;

    private List<int[]> coordinates = new List<int[]>();

    public Polygon(){
        x = 100;
        y = 198;
        fill = "yellow";
        strokeColour = "red";
        strokeWidth = 1;

        coordinates.Add(new int[] {10,40});
        coordinates.Add(new int[] {198,190});
        coordinates.Add(new int[] {78,10});
        coordinates.Add(new int[] {78,160});
    }

    public Polygon(int x, int y, string fill, string strokeColour, int strokeWidth, List<int[]> coordinates){
        this.x = x;
        this.y = y;
        this.fill = fill;
        this.strokeColour = strokeColour;
        this.strokeWidth = strokeWidth;
        this.coordinates = coordinates;
    }

    public string draw(){
        string str = "<polygon points=\"" + x + ",";
        foreach(int[] point in coordinates){
            str += point[0] + " " + point[1] + ",";
        }
        str += y + "\"" + "style=\"fill:" + fill + ";stroke:" + strokeColour + ";stroke-width:" + strokeWidth + "\"" + "/>";
        return str;
    }
}