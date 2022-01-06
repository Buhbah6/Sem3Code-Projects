package Lecture1;

import java.util.*;
import java.util.stream.Stream;

/**
 * @author Anthony Nadeau
 */
public class CollectionStream {
    
    public static void main(String[] args) {
        Double[] numbers = {2.4, 55.6, 90.12, 26.6};
        ArrayList<Double> list = new ArrayList<>(Arrays.asList(numbers));
        int count = 0;
        for (double e: list)
            if (e > 60) count++;
                System.out.println("Count is " + count);
            
        System.out.println("Count using Streams is " + list.stream().filter(e -> e> 60).count());
        
        list.stream().filter(e -> e > 60).count();
        
        //creating stream from an array
        Stream.of(numbers).filter(e -> e > 60).count();
        Stream.of(2.4, 55.6, 90.12, 26.6).filter(e -> e > 60).count();
        
        // ------------------------------------------Parameters are pulled from the list-------//
        // Printing result -------------------------------Parameters------Expression-----------//
        System.out.println("min is : " + list.stream().min((e1, e2) -> Double.compare(e1, e2)));
        
        
        //NoneMatch methods
        List<Integer> intList = Arrays.asList(2, 4, 5, 6, 8);
        boolean allEven = intList.stream().allMatch(i -> i % 2 == 0);
        boolean oneEven = intList.stream().anyMatch(i -> i % 2 == 0);
        boolean noneMultipleOfThree = intList.stream().noneMatch(i -> i %
            3 == 0);
        System.out.println("My Source: " + intList);
        System.out.println("All matching: " + allEven);
        System.out.println("One is matching: " + oneEven);
        System.out.println("None is matching: " + noneMultipleOfThree);
    }
}