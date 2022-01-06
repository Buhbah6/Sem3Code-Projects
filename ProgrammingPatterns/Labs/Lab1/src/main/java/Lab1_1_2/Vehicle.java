package Lab1_1_2;

/**
 * @author Anthony Nadeau
 */
public class Vehicle {
    private int noOfWheels;
    private int avgMilesPerGallon;
    
    public Vehicle(int wheels, int AvgMpg) {
        this.noOfWheels = wheels;
        this.avgMilesPerGallon = AvgMpg;
    }
    
    @Override
    public String toString() {
        return String.format("Vehicle has : %d Wheels\n It can travel an average"
                + "of %d miles per gallon.", noOfWheels, avgMilesPerGallon);
    }

    public int getNoOfWheels() {
        return noOfWheels;
    }

    public int getAvgMilesPerGallon() {
        return avgMilesPerGallon;
    }
}