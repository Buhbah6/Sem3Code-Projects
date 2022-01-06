package Q3;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        Bird bird = new Sparrow();
        AdaptedBird b1 = new AdaptedBird(bird);
        
        b1.squeak();
    }
}
