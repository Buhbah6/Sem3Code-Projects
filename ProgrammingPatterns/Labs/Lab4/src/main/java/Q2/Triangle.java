package Q2;

/**
 * @author Anthony Nadeau
 */
public class Triangle extends GeometricFigure {
    
    public Triangle(int h, int w) {
        height = h;
        width = w;
        area = calcArea();
    }
    
    @Override
    public int calcArea() {
        return width * (height / 2); 
    }

    @Override
    public String toString() {
        return "Triangle{" + super.toString();
    }
    
    public int getHeight() {
        return height;
    }

    public int getWidth() {
        return width;
    }

    public double getArea() {
        return area;
    }
}
