package Part2;

import java.util.stream.DoubleStream;
import java.util.stream.IntStream;

/**
 * @author Anthony Nadeau
 */
public class Program1And2 {
    
    public static void main(String[] args) {
       
        // Program 1
        double[] dArr = {70, 65, 82, 79, 91, 100, 20, 43, 61, 60};
        System.out.println("Using summary statistics to print the count, sum, "
                + "average, min, max, for the values of the array that are above 60: ");
        System.out.println(DoubleStream.of(dArr).filter(value -> value > 60).summaryStatistics());
        System.out.println();
        
        // Program 2
        int[] scores = {22, 45, 63, 90, 52, 14, 99, 36, 70, 70};
        System.out.println("Number of scores above or equal to the Average: ");
        System.out.println(IntStream.of(scores).filter(score -> score >= IntStream.of(scores).average().getAsDouble()).count());
        System.out.println();
        System.out.println("Number of scores below the Average: ");
        System.out.println(IntStream.of(scores).filter(score -> score < IntStream.of(scores).average().getAsDouble()).count());
    }
}
