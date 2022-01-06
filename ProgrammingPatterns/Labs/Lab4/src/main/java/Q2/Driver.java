package Q2;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) throws Exception {
        GeometricFigure f1 = GeometricFigFactory.createFigure(1, 7, 13);
        GeometricFigure f2 = GeometricFigFactory.createFigure(2, 4, 8);
        GeometricFigure f3 = GeometricFigFactory.createFigure(3, 8, 12);
        
        display(f1);
        display(f2);
        display(f3);
    }
    
    public static void display(GeometricFigure fig) {
        System.out.println(fig);
    }
}
