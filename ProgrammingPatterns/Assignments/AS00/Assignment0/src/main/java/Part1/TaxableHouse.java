package Part1;

/**
 * @author Anthony Nadeau
 */
public class TaxableHouse extends House implements Itaxable{
    
    /**
     * Constructor with all 4 inherited instance variables
     * @param loc location string
     * @param inCity if the house is in a city or not
     * @param estVal the estimated value of the house
     * @param area the area of the land occupied by the house
     */
    public TaxableHouse(String loc, boolean inCity, double estVal, double area) {
        super(loc, inCity, estVal, area);
    }
    
    /**
     * Method inherited from the Interface to calculate the Tax
     * @return the tax needed for the house based on the value
     */
    @Override
    public double valueTax() {
        if (inCity)
            return (this.getEstimatedValue() / 1000) * 5 + 5 * this.getArea();
        else
            return (this.getEstimatedValue() / 1000) * 3;
    }
}
