package Part1;

/**
 * @author Anthony Nadeau
 */
public class Bus extends Vehicle {
   private int numOfSeats;
   
    /**
     * Constructor with the 3 inherited instance variables and the new instance variable
     * @param regNum registration number of the bus
     * @param maxVelo max velocity of the bus
     * @param val value of the bus
     * @param numOfSeats number of seats on the bus
     */
    public Bus(int regNum, double maxVelo, double val, int numOfSeats) {
       super(regNum, maxVelo, val);
       this.numOfSeats = numOfSeats;
    }

    //GETTERS
    
    public int getNumOfSeats() {
        return numOfSeats;
    }
}
