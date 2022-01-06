package Lab1_1_2;

/**
 * @author Anthony Nadeau
 */
public class Car extends Vehicle {
    
    public Car(int AvgMpG) {
        super(4, AvgMpG);
    }
    
    @Override
    public String toString() {
        return String.format("This Car has : %d Wheels\n It can travel an average"
                + "of %d miles per gallon.", getNoOfWheels(), getAvgMilesPerGallon());
    }
}
