using System;

class Canvas{

    //The canvas is just a plane used for setting the size of the svg box. Only width and heigh is required.
    private int width { get; set; }
    private int height { get; set; }
    
    private string baseCanvas; //This will be used to clear the canvas
    private string canvas { get; set; }
    private string canvasEnding = "</svg>\n" + "</body>\n" + "</html>";
    private List<string> shapes = new List<string>(); //This stores all the shape elements so they can be easily pulled from the svg tag

    public Canvas(int width,int height){
        this.width = width;
        this.height = height;
        this.canvas = "<!DOCTYPE html>\n" + "<html>\n" + "<body>\n"  + "<h1> </h1>\n" + "<svg width=\"" + width + "\"" + "" + " height=\"" + height + "\"" + "> ";
        this.baseCanvas = "<!DOCTYPE html>\n" + "<html>\n" + "<body>\n"  + "<h1> </h1>\n" + "<svg width=\"" + width + "\"" + "" + " height=\"" + height + "\"" + "> ";
    }

    public void addShape(string shape){
        shapes.Add(shape);
    }

    //This method gives each shape an index (displays it) and allows user to remove the shape assigned to that index 
    public void removeShape(){

        //The if statement checks if the canvas contains shapes
        if(shapes.Any()){
            int option = 1;

            Console.WriteLine("Choose shape to remove:");
            foreach(string shape in shapes){
            Console.WriteLine(option + ".");
            Console.WriteLine(shape);
            option++;
        }

            int index = Int32.Parse(Console.ReadLine());
            shapes.RemoveAt(index-1);
            Console.WriteLine("Shape " + index + " has been removed!");
        }else{
            Console.WriteLine("Canvas is empty!");
        }
    }

    public string drawCanvas(){
        foreach(string shape in shapes){
            canvas += shape;
        }
        canvas += canvasEnding;
        return canvas;
    }

    public void clearCanvas(){
        shapes.Clear();
        canvas = baseCanvas;
        Console.WriteLine("Canvas Cleared!");
    }
}