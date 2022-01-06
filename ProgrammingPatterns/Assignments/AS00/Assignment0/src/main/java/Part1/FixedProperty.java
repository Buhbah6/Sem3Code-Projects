package Part1;

/**
 * @author Anthony Nadeau
 */
public class FixedProperty {
    private String location;
    protected boolean inCity;
    private double estimatedValue;
    
    /**
     * Base Constructor
     * @param loc location string
     */
    public FixedProperty(String loc) {
        this.location = loc;
        this.inCity = true;
        this.estimatedValue = 1000000;
    }
    
    /**
     * Constructor with all instance variables
     * @param loc location string
     * @param inCity if the property is in a city or not
     * @param estVal the estimated value of the property
     */
    public FixedProperty(String loc, boolean inCity, double estVal) {
        this.location = loc;
        this.inCity = inCity;
        this.estimatedValue = estVal;
    }

    // GETTERS AND SETTERS
    
    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public boolean isInCity() {
        return inCity;
    }

    public void setInCity(boolean inCity) {
        this.inCity = inCity;
    }

    public double getEstimatedValue() {
        return estimatedValue;
    }

    public void setEstimatedValue(double estimatedValue) {
        this.estimatedValue = estimatedValue;
    }
    
    
}
