package Part1;

/**
 * @author Anthony Nadeau
 */
public class House extends FixedProperty {
    private double area;
    
    /**
     * Constructor with the 3 inherited instance variables and the new instance variable
     * @param loc location string
     * @param inCity if the house is in the city or not
     * @param estVal the estimated value of the house
     * @param area the area occupied by the house
     */
    public House(String loc, boolean inCity, double estVal, double area) {
        super(loc, inCity, estVal);
        this.area = area;
    }
    
    // Getters

    public double getArea() {
        return area;
    }
}
