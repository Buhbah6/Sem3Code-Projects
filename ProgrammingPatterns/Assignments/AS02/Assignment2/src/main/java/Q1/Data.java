package Q1;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class Data {
    // Instance Variables
    private String name;
    private String address;

    /**
     * Constructor with all instance variables
     * @param name client name
     * @param address client address
     */
    public Data(String name, String address) {
        this.name = name;
        this.address = address;
    }

    // GETTERS
    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    /**
     * Overridden toString
     * @return this data as a string
     */
    @Override
    public String toString() {
        return String.format("Name: %s\nAddress: %s\n\n", name, address);
    }
}
