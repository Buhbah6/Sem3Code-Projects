package IMPORTANT_DATA_STRUCTURES;

import java.util.*;

/**
 * @author Anthony
 */
public class Driver2 {
    
    public static void main(String[] args) {
        
        // Every object has an ID in the form of a hashCode
        
        // SET -> Think diversity - Every object in a set must be UNIQUE
        
        // Since set is an interface, we must create it as a HashSet or TreeSet
        // HashSet is for a basic set
        // TreeSet is for sort-able sets
        Set<String> hashSet = new HashSet<>();
        Set<String> treeSet = new TreeSet<>(hashSet);
        
        hashSet.add("Mont");
        hashSet.add("Montreal");
        hashSet.add("Ottawa");
        hashSet.add("Ottawa");
        hashSet.add("Toronto");
        hashSet.add("Quebec");
        hashSet.add("Quebec");
        hashSet.add("quebec");
        hashSet.add("Florida");
        hashSet.add("Flor");
    
        System.out.println(hashSet);
        
        for (String city : hashSet) {
            System.out.println(city.toUpperCase() + "");
        }
    }
}
