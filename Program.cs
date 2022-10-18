using System;
using System.IO;

namespace Assignment2{
    class Program{
        static void Main(string[] args){

            Console.Clear();

            //Canvas object used to store given shapes
            Canvas canvas = new Canvas(1000,1000);

            //Loop to add shapes until option to terminate is chosen (Similar to a game loop).
            bool choosing = true;

            while(choosing){

                //User input 
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Add a shape");
                Console.WriteLine("2. Remove a shape");
                Console.WriteLine("3. Update shape");
                Console.WriteLine("4. Change z-index");
                Console.WriteLine("5. Clear canvas");
                Console.WriteLine("6. Finish drawing");

                int option = Int32.Parse(Console.ReadLine());

                if(option == 1){

                    //If option 1 is chosen then allow user to choose shape
                    Console.WriteLine("Choose a shape:");
                    Console.WriteLine("1. Rectangle");
                    Console.WriteLine("2. Circle");
                    Console.WriteLine("3. Ellipse");
                    Console.WriteLine("4. Polyline");
                    Console.WriteLine("5. Polygon");
                    Console.WriteLine("6. Line");
                    Console.WriteLine("7. Path");
                    Console.WriteLine("8. All shapes");
                    int shape = Int32.Parse(Console.ReadLine());

                    switch(shape){
                        //RECTANGLE
                        case 1:
                        //Choose default rectangle or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Rectangle");
                        Console.WriteLine("2. Custom Rectangle");
                        int rectOption = Int32.Parse(Console.ReadLine());

                        if(rectOption == 1){
                            Rectangle rect = new Rectangle();
                            canvas.addShape(rect.draw()); 
                        }else{
                            Console.Write("Enter x: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter y: ");
                            int y = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter width: ");
                            int width = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter height: ");
                            int height = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter colour: ");
                            string fill = Console.ReadLine();
                            Console.Write("Enter stroke width: ");
                            int strokeWidth = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter stroke colour: ");
                            string strokeColour = Console.ReadLine();
                            Console.WriteLine("");
                            Rectangle rect = new Rectangle(x, y, width, height, fill, strokeWidth, strokeColour);
                            canvas.addShape(rect.draw()); 
                        }           
                            break;      

                        //CIRCLE
                        case 2:
                        //Choose default circle or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Circle");
                        Console.WriteLine("2. Custom Circle");
                        int circOption = Int32.Parse(Console.ReadLine());

                        if(circOption == 1){
                            Circle circle = new Circle();
                            canvas.addShape(circle.draw()); 
                        }else{
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
                            canvas.addShape(circle.draw()); 
                        }           
                            break;      

                        //ELLIPSE
                        case 3:
                        //Choose default ellipse or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Ellipse");
                        Console.WriteLine("2. Custom Ellipse");
                        int eliOption = Int32.Parse(Console.ReadLine());

                        if(eliOption == 1){
                            Ellipse eli = new Ellipse();
                            canvas.addShape(eli.draw()); 
                        }else{
                            Console.Write("Enter x: ");
                            int cx = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter y: ");
                            int cy = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter width: ");
                            int rx = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter height: ");
                            int ry = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter colour: ");
                            string fill = Console.ReadLine();
                            Console.Write("Enter stroke width: ");
                            int strokeWidth = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter stroke colour: ");
                            string strokeColour = Console.ReadLine();
                            Console.WriteLine("");
                            Ellipse eli = new Ellipse(cx, cy, rx, ry, fill, strokeWidth, strokeColour);
                            canvas.addShape(eli.draw()); 
                        }           
                            break;      

                        //POLYLINE
                        case 4:
                        //Choose default polyline or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Polyline");
                        Console.WriteLine("2. Custom Polyline");
                        int PolylineOption = Int32.Parse(Console.ReadLine());

                        if(PolylineOption == 1){
                            Polyline polyline = new Polyline();
                            canvas.addShape(polyline.draw()); 
                        }else{
                            Console.WriteLine("Enter starting point x:");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter ending point y:");
                            int y = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter colour:");
                            string fill = Console.ReadLine();
                            Console.WriteLine("Enter stroke colour:");
                            string strokeColour = Console.ReadLine();
                            Console.WriteLine("Enter stroke width");
                            int strokeWidth = Int32.Parse(Console.ReadLine());

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
                            
                            Polyline polyline = new Polyline(x, y, fill, strokeColour, strokeWidth, coordinates);
                            canvas.addShape(polyline.draw());
                        }           
                            break;     
                        
                         //POLYGON
                        case 5:
                        //Choose default polygon or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Polygon");
                        Console.WriteLine("2. Custom Polygon");
                        int PolygonOption = Int32.Parse(Console.ReadLine());

                        if(PolygonOption == 1){
                            Polygon polygon = new Polygon();
                            canvas.addShape(polygon.draw()); 
                        }else{
                            Console.WriteLine("Enter starting point x:");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter ending point y:");
                            int y = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter colour:");
                            string fill = Console.ReadLine();
                            Console.WriteLine("Enter stroke colour:");
                            string strokeColour = Console.ReadLine();
                            Console.WriteLine("Enter stroke width");
                            int strokeWidth = Int32.Parse(Console.ReadLine());

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
                            
                            Polygon polygon = new Polygon(x, y, fill, strokeColour, strokeWidth, coordinates);
                            canvas.addShape(polygon.draw());
                        }           
                            break;     

                        //LINE
                        case 6:
                        //Choose default circle or custom
                        Console.WriteLine("Choose Type:");
                        Console.WriteLine("1. Default Line");
                        Console.WriteLine("2. Custom Line");
                        int lineOption = Int32.Parse(Console.ReadLine());

                        if(lineOption == 1){
                            Line line = new Line();
                            canvas.addShape(line.draw()); 
                        }else{
                            Console.Write("Enter x1: ");
                            int x1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter y1: ");
                            int y1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter x2: ");
                            int x2 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter y2: ");
                            int y2 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter colour: ");
                            string strokeColour = Console.ReadLine();
                            Console.Write("Enter stroke width: ");
                            int strokeWidth = Int32.Parse(Console.ReadLine());
                            Line line = new Line(x1, y1, x2, y2, strokeColour, strokeWidth);
                            canvas.addShape(line.draw()); 
                        }           
                            break;   

                        case 7:
                            //PATH
                            Console.WriteLine("Choose Type:");
                            Console.WriteLine("1. Default Path");
                            Console.WriteLine("2. Custom Path");
                            int pathOption = Int32.Parse(Console.ReadLine());

                            if(pathOption == 1){
                                PathShape path = new PathShape();
                                canvas.addShape(path.draw()); 
                            }else{
                                Console.WriteLine("Enter custom Path:");
                                string path = Console.ReadLine();
                                PathShape pathShape = new PathShape(path);
                                canvas.addShape(pathShape.draw());
                            }
                            break;

                        case 8:
                            //Print all default shapes
                            Circle defaultCircle = new Circle();
                            Ellipse defaultEllipse = new Ellipse();
                            Line defaultLine = new Line();
                            Polygon defaultPolygon = new Polygon();
                            Polyline defaultPolyline = new Polyline();
                            Rectangle defaultRectangle = new Rectangle();

                            canvas.addShape(defaultCircle.draw());
                            canvas.addShape(defaultEllipse.draw());
                            canvas.addShape(defaultLine.draw());
                            canvas.addShape(defaultPolygon.draw());
                            canvas.addShape(defaultPolyline.draw());
                            canvas.addShape(defaultRectangle.draw());
                            break;

                    }
                }else if(option == 2){
                    Console.WriteLine("Are you sure?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int answer = Int32.Parse(Console.ReadLine());

                    if(answer == 1){
                        canvas.removeShape();
                    }
                    
                }else if(option == 3){
                    Console.WriteLine("Are you sure?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int answer = Int32.Parse(Console.ReadLine());

                    if(answer == 1){
                        canvas.updateShape();
                    }
                }else if(option == 4){
                    canvas.changeIndex();
                }else if(option == 5){

                    Console.WriteLine("Are you sure?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int answer = Int32.Parse(Console.ReadLine());

                    if(answer == 1){
                        canvas.clearCanvas();
                    }
                }else if(option == 6){
                    choosing = false;
                }else{
                    Console.WriteLine("Not a valid option!");
                }
            }
            writeToFile(canvas.drawCanvas());
        }

        static void writeToFile(string text){

            string path = "C:\\Documents\\CS264\\Assignment_2";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "SVG.svg"))){
                outputFile.WriteLine(text);
            }
        }

        static int[] getCord(string point){
            int[] coords = new int[2];

            string[] points = point.Split(","); 
            coords[0] = Int32.Parse(points[0]);
            coords[1] = Int32.Parse(points[1]);

            return coords;
        }
    }
}