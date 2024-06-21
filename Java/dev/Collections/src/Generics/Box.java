package Generics;

public class Box<T> {
    private T t;

    public Box(T msg)
    {
        this.t = msg;
    }

    public T getT() {
        return t;
    }

    public void setT(T t) {
        this.t = t;
    }
    
}
