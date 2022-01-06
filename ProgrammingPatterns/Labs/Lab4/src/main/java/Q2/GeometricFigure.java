package Q2;

/**
 * @author Anthony Nadeau
 */
public abstract class GeometricFigure {
    protected int height;
    protected int width;
    protected int area;
    
    public abstract int calcArea();

    @Override
    public String toString() {
        return "GeometricFigure{" + "height=" + height + ", width=" + width + ", area=" + area + '}';
    }
   
}
