package Part1;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        
        // Creating the objects
        TaxableHouse h1 = new TaxableHouse("Sorel-Tracy", false, 240000.0, 88);
        TaxableHouse h2 = new TaxableHouse("Montreal", true, 737000.0, 110);
        TaxableHouse h3 = new TaxableHouse("Laval", true, 400000.0, 88);
        TaxableBus b1 = new TaxableBus(10021, 180, 40000, 24);
        TaxableBus b2 = new TaxableBus(40022, 220, 55500, 28);
        TaxableBus b3 = new TaxableBus(61034, 110, 25000, 18);
        
        // Storing the objects in an array
        Itaxable[] array = {h1, h2, h3, b1, b2, b3};
        
        // Printing the tax for each object
        System.out.println("Tax for each object before sorting: ");
        for (Itaxable obj: array) {
            System.out.println(obj.valueTax());
        }
        System.out.println();
        
        // Converting the array into an ArrayList and using a Lambda Expression
        // sort the ArrayList in increasing order
        ArrayList<Itaxable> arrList = new ArrayList(Arrays.asList(array));
        Collections.sort(arrList, (Itaxable obj, Itaxable obj2) -> Double.compare(obj.valueTax(), obj2.valueTax()));
        
        // Printing the tax for each object (sorted)
        System.out.println("Tax for each object after sorting: ");
        arrList.forEach(obj -> System.out.println(obj.valueTax()));
    }
}