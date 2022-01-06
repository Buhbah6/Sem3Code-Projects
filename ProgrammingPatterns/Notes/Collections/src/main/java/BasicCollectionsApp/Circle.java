package BasicCollectionsApp;

/**
 * @author Anthony
 */
public class Circle {
    private int x;
    private int y;
    private double radius;
    
    public Circle(int x, int y, double radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    
    @Override
    public String toString() {
        return String.format("X = %d\nY = %d\nRadius = %f", x, y, radius);
    }
}
