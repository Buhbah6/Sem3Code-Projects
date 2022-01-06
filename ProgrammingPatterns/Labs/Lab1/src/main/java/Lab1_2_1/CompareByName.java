package Lab1_2_1;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class CompareByName implements Comparator<Horse> {
    
    public int compare(Horse h1, Horse h2) {
        return h1.getName().compareTo(h2.getName());
    }
}