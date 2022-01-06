package Q2;

/**
 * @author Anthony Nadeau
 */
public class GeometricFigFactory {
    
    public static GeometricFigure createFigure(int choice, int height, int width) throws Exception {
        switch (choice) {
            case 1:
                return new Rectangle(height, width);
            case 2:
                return new Square(height);
            case 3:
                return new Triangle(height, width);
            default:
                throw new Exception("Unknown Figure Type");
        }
    }
}
