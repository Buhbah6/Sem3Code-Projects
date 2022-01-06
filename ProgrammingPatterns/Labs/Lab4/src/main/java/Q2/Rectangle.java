package Q2;

/**
 * @author Anthony Nadeau
 */
public class Rectangle extends GeometricFigure {
    
    public Rectangle(int h, int w) {
        height = h;
        width = w;
        area = calcArea();
    }
    
    @Override
    public int calcArea() {
        return height * width;
    }

    @Override
    public String toString() {
        return "Rectangle{" + super.toString();
    }

    public int getHeight() {
        return height;
    }

    public int getWidth() {
        return width;
    }

    public int getArea() {
        return area;
    }
}
