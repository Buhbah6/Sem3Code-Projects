package Q3;

import java.util.*;
import java.io.*;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class TestGeneology { // DRIVER CLASS
    
    public static void main(String[] args) throws FileNotFoundException {
        
        Geneology data = new Geneology(); // Creates Geneology object
        String parent;
        String child;
        // Creating a Scanner for user input
        Scanner console = new Scanner(System.in);
        
        // Taking user input for the required fields
        System.out.println("Please enter the name of the ancestor");
        parent = console.next();
        System.out.println("Please enter the name of the descendant");
        child = console.next();
        // Verifying if the given child is a descendant of the given parent.
        data.isDescendant(parent, child);
    }
}
