package Part1;

/**
 * @author Anthony Nadeau
 */
public class TaxableBus extends Bus implements Itaxable{
    
    /**
     * Constructor with the 4 inherited instance variables
     * @param regNum registration number of the bus
     * @param maxVelo max velocity of the bus
     * @param val value of the bus
     * @param numOfSeats number of seats on the bus
     */
    public TaxableBus(int regNum, double maxVelo, double val, int numOfSeats) {
        super(regNum, maxVelo, val, numOfSeats);
    }
    
    /**
     * The implementation of the method inherited from the Interface
     * @return the tax based on the value of the bus
     */
    @Override
    public double valueTax() {
        return this.value / 10 + 100 * this.getNumOfSeats();
    }
}
