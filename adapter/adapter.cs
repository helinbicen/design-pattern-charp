using System;

public interface Target {
    string GetRequest();
}

class Adaptee {
    public string GetSpecificRequest(){
        return "Specific request";
    }
}

class Adapter : Target {
    private readonly Adaptee _adaptee;
    public Adapter(Adaptee adaptee){
        this._adaptee = adaptee;
    }

    public string GetRequest(){
        return $"Request: '{this._adaptee.GetSpecificRequest()}'";
    }
}