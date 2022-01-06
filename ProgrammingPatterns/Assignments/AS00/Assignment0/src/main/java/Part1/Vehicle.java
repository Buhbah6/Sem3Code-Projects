package Part1;

/**
 * @author Anthony Nadeau
 */
public class Vehicle {
    private int registrationNum;
    private double maxVelocity;
    protected double value;
    
    /**
     * Constructor with all 3 instance variables
     * @param regNum the registration number of the vehicle
     * @param maxVelo the max velocity of the vehicle
     * @param val the value of the vehicle
     */
    public Vehicle(int regNum, double maxVelo, double val) {
        this.registrationNum = regNum;
        this.maxVelocity = maxVelo;
        this.value = val;
    }
    
    //GETTERS

    public int getRegistrationNum() {
        return registrationNum;
    }
}
