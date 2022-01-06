package Lecture1;

import java.util.*;
import java.util.stream.Stream;
import java.util.stream.IntStream;

/**
 * @author Anthony Nadeau
 */
public class YouDoIt {
    
    public static void main(String[] args) {
        int[] arrlist = {10, 33, 27, 78, 5, 19, 104, 50, 88, 60};
        System.out.println("Number of distinct numbers: " + 
                IntStream.of(arrlist).distinct().count());
        
        IntStream.of(arrlist).distinct().sorted().forEach(e -> System.out.print(e + " "));
    }
}
