using System;

class PathShape{

    string path;

    public PathShape(){
        path = "M150 0 L75 200 L225 200 Z";
    }

    public PathShape(string path){
        this.path = path;
    }

    public string draw(){
        return "<path d=\"" + path + "\"" + "/>";
    }
}