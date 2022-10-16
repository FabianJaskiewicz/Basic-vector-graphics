using System;

class Polyline{

    private int x;
    private int y;
    private string fill;
    private string strokeColour;
    private int strokeWidth;

    private List<int[]> coordinates = new List<int[]>();

    public Polyline(){
        x = 20;
        y = 180;
        fill = "none";
        strokeColour = "black";
        strokeWidth = 3;

        coordinates.Add(new int[] {20,40});
        coordinates.Add(new int[] {25,60});
        coordinates.Add(new int[] {40,80});
        coordinates.Add(new int[] {120,120});
        coordinates.Add(new int[] {140,200});
    }

    public Polyline(int x, int y, string fill, string strokeColour, int strokeWidth, List<int[]> coordinates){
        this.x = x;
        this.y = y;
        this.fill = fill;
        this.strokeColour = strokeColour;
        this.strokeWidth = strokeWidth;
        this.coordinates = coordinates;
    }

    public string draw(){
        string str = "<polyline points=\"" + x + ",";
        foreach(int[] point in coordinates){
            str += point[0] + " " + point[1] + ",";
        }
        str += y + "\"" + "style=\"fill:" + fill + ";stroke:" + strokeColour + ";stroke-width:" + strokeWidth + "\"" + "/>";
        return str;
    }
}