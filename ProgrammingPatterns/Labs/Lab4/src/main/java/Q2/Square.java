package Q2;

/**
 * @author Anthony Nadeau
 */
public class Square extends Rectangle {
    
    public Square(int height, int weight) {
        super(height, height);
    }
    
    public Square(int side) {
        super(side, side);
    }

    @Override
    public String toString() {
        return "Square{" + super.toString();
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
