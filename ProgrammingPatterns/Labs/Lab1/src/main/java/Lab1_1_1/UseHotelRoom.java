package Lab1_1_1;

import java.util.ArrayList;

/**
 * @author Anthony Nadeau
 */
public class UseHotelRoom {
    
    public static void main(String[] args) {
        
        // Object Instantiation
        HotelRoom alpha = new HotelRoom(298);
        Suite alpha2 = new Suite(298);
        HotelRoom beta = new HotelRoom(300);
        Suite beta2 = new Suite(300);
        Suite gamma = new Suite(5);
        
        // Printing the objects
        System.out.println("Printing the Objects Individually\n");
        System.out.println(alpha);
        System.out.println(alpha2);
        System.out.println(beta);
        System.out.println(beta2);
        System.out.println("\nPrinting the array\n");
       
        // Creating the array and Arraylist, and printing them.
        HotelRoom[] hotelArr = {alpha, beta, alpha2, beta2, gamma};
        ArrayList hotelList = new ArrayList();
        
        for (HotelRoom hotelArr1 : hotelArr) {
            System.out.println(hotelArr1);
            hotelList.add(hotelArr1);
        }
        System.out.println("\nPrinting the arrayList\n");
        System.out.println(hotelList);
        
        System.out.println("Suite instance" + new Suite(300));
        
        SuiteSingle s1 = SuiteSingle.getInstance(200);
        SuiteSingle s2 = SuiteSingle.getInstance(200);
        
        System.out.println("S1 hashcode: " + s1.hashCode());
        System.out.println("S2 hashcode: " + s2.hashCode());
    }
}
