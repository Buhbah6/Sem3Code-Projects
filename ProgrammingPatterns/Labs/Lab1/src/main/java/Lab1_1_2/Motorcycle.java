package Lab1_1_2;

/**
 * @author Anthony Nadeau
 */
public class Motorcycle extends Vehicle {
    
    public Motorcycle(int AvgMpg) {
        super(2, AvgMpg);
    }
    
    @Override
    public String toString() {
        return String.format("This Motorcycle has : %d Wheels\n It can travel an average"
                + "of %d miles per gallon.", getNoOfWheels(), getAvgMilesPerGallon());
    }
}
