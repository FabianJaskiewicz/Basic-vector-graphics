using System;

class Canvas{

    //The canvas is just a plane used for setting the size of the svg box. Only width and heigh is required.
    private int width { get; set; }
    private int height { get; set; }
    private string canvas { get; set; }
    private string canvasEnding = "</svg>\n" + "</body>\n" + "</html>";
    private List<string> shapes = new List<string>(); //This stores all the shape elements so they can be easily pulled from the svg tag

    public Canvas(int width,int height){
        this.width = width;
        this.height = height;
        this.canvas = "<!DOCTYPE html>\n" + "<html>\n" + "<body>\n"  + "<h1> </h1>\n" + "<svg width=\"" + width + "\"" + "" + " height=\"" + height + "\"" + "> ";
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
            canvas += shape + "\n";
        }
        canvas += canvasEnding;
        return canvas;
    }

    public void clearCanvas(){
        shapes.Clear();
        Console.WriteLine("Canvas Cleared!");
    }

    public void changeIndex(){
        if(shapes.Any()){
            int option = 1;

            Console.WriteLine("Choose shape to update:");
            foreach(string shape in shapes){
                Console.WriteLine(option + ".");
                Console.WriteLine(shape);
                option++;
            }

            int from = Int32.Parse(Console.ReadLine());
            if(from > shapes.Count() || from < 1){
                Console.WriteLine("Invalid index, value too small or big!");
            }
            Console.WriteLine("Enter z-index");
            int to = Int32.Parse(Console.ReadLine());
            if(to > shapes.Count()){
                to = shapes.Count();
            }
            if(to < 0){
                to = 0;
            }
            string temp = shapes[from-1];
            shapes.RemoveAt(from-1);
            shapes.Insert(to-1, temp);
        }
    }

    public void updateShape(){
        if(shapes.Any()){
            int option = 1;

            Console.WriteLine("Choose shape to update:");
            foreach(string shape in shapes){
                Console.WriteLine(option + ".");
                Console.WriteLine(shape);
                option++;
            }
            int index = Int32.Parse(Console.ReadLine());
            string shapeName = shapes[index-1].Substring(0,7);

            switch(shapeName){
                    case "<circle":
                        Console.Write("Enter x: ");
                        int cx = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter y: ");
                        int cy = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter width: ");
                        int width = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter radius: ");
                        int r = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter colour: ");
                        string stroke = Console.ReadLine();
                        Console.Write("Enter stroke width: ");
                        int strokeWidth = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter stroke colour: ");
                        string fill = Console.ReadLine();
                        Console.WriteLine("");
                        Circle circle = new Circle(cx, cy, r, stroke, strokeWidth, fill);
                        shapes.RemoveAt(index-1);
                        shapes.Insert(index-1, circle.draw()); 
                        break;
                        
                    case "<rect x":
                        Console.Write("Enter x: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter y: ");
                        int y = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter width: ");
                        int recWidth = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        int recHeight = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter colour: ");
                        string recFill = Console.ReadLine();
                        Console.Write("Enter stroke width: ");
                        int recStrokeWidth = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter stroke colour: ");
                        string recStrokeColour = Console.ReadLine();
                        Console.WriteLine("");
                        Rectangle rect = new Rectangle(x, y, recWidth, recHeight, recFill, recStrokeWidth, recStrokeColour);
                        shapes.RemoveAt(index-1);
                        shapes.Insert(index-1, rect.draw());
                        break;

                    case "<ellip":
                        Console.Write("Enter x: ");
                        int elliCx = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter y: ");
                        int elliCy = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter width: ");
                        int elliRx = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        int elliRy = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter colour: ");
                        string elliFill = Console.ReadLine();
                        Console.Write("Enter stroke width: ");
                        int elliStrokeWidth = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter stroke colour: ");
                        string elliStrokeColour = Console.ReadLine();
                        Console.WriteLine("");
                        Ellipse eli = new Ellipse(elliCx, elliCy, elliRx, elliRy, elliFill, elliStrokeWidth, elliStrokeColour);
                        shapes.RemoveAt(index-1);
                        shapes.Insert(index-1, eli.draw());
                        break;

                    case "<line ":
                        Console.Write("Enter x1: ");
                        int lineX1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter y1: ");
                        int lineY1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter x2: ");
                        int lineX2 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter y2: ");
                        int lineY2 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter colour: ");
                        string lineStrokeColour = Console.ReadLine();
                        Console.Write("Enter stroke width: ");
                        int lineStrokeWidth = Int32.Parse(Console.ReadLine());
                        Line line = new Line(lineX1, lineY1, lineX2, lineY2, lineStrokeColour, lineStrokeWidth);
                        shapes.Add(line.draw());
                        break;

                    case "<path ":
                        Console.WriteLine("Enter custom Path:");
                        string path = Console.ReadLine();
                        PathShape pathShape = new PathShape(path);
                        shapes.Add(pathShape.draw());
                        break;

                    case "<polyg":
                         Console.WriteLine("Enter starting point x:");
                            int polygonX = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter ending point y:");
                            int polygonY = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter colour:");
                            string polygonFill = Console.ReadLine();
                            Console.WriteLine("Enter stroke colour:");
                            string polygonStrokeColour = Console.ReadLine();
                            Console.WriteLine("Enter stroke width");
                            int polygonStrokeWidth = Int32.Parse(Console.ReadLine());

                            //This part add coordinates into a list that can be passed into the object
                            List<int[]> coordinates = new List<int[]>();
                            bool choosingPoints = true;
                            while(choosingPoints){
                                Console.WriteLine("Enter a coordinate in the form (x, y) separated by a comman eg. 43,35");
                                string inputPoints = Console.ReadLine();
                                Console.WriteLine("Press 0 when done");
                                
                                if(inputPoints.Equals("0")){
                                    choosingPoints = false;
                                }else{
                                    coordinates.Add(getCord(inputPoints));
                                }
                            }
                            
                            Polygon polygon = new Polygon(polygonX, polygonY, polygonFill, polygonStrokeColour, polygonStrokeWidth, coordinates);
                            shapes.Add(polygon.draw());
                            break;

                        case "<polyl":
                            Console.WriteLine("Enter starting point x:");
                            int polylineX = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter ending point y:");
                            int polylineY = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter colour:");
                            string polylineFill = Console.ReadLine();
                            Console.WriteLine("Enter stroke colour:");
                            string polylineStrokeColour = Console.ReadLine();
                            Console.WriteLine("Enter stroke width");
                            int polylineStrokeWidth = Int32.Parse(Console.ReadLine());

                            //This part add coordinates into a list that can be passed into the object
                            List<int[]> polylineCoords = new List<int[]>();
                            bool choosing = true;
                            while(choosing){
                                Console.WriteLine("Enter a coordinate in the form (x, y) separated by a comman eg. 43,35");
                                string inputPoints = Console.ReadLine();
                                Console.WriteLine("Press 0 when done");
                                
                                if(inputPoints.Equals("0")){
                                    choosingPoints = false;
                                }else{
                                    polylineCoords.Add(getCord(inputPoints));
                                }
                            }
                            
                            Polyline polyline = new Polyline(polylineX, polylineY, polylineFill, polylineStrokeColour, polylineStrokeWidth, polylineCoords);
                            shapes.Add(polyline.draw());
                            break;
                }
            } 
        }

        public static int[] getCord(string point){
            int[] coords = new int[2];

            string[] points = point.Split(","); 
            coords[0] = Int32.Parse(points[0]);
            coords[1] = Int32.Parse(points[1]);

            return coords;
        }
}