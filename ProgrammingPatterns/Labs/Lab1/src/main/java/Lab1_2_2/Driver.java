package Lab1_2_2;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        // Creation of the points, the array, and the arraylist
        Point p1 = new Point(5, 1);
        Point p2 = new Point(4, 2);
        Point p3 = new Point(3, 3);
        Point p4 = new Point(2, 4);
        Point p5 = new Point(1, 5);
        Point[] points = {p1, p2, p3, p4, p5};
        List pointsList = Arrays.asList(points);
        
        //Sorting list using Comparable (Ascending X values)
        Collections.sort(pointsList);
        System.out.println(pointsList);
        System.out.println();
        
        //Sorting list using Comparator (Ascending Y values)
        Collections.sort(pointsList, new CompareByY());
        System.out.println(pointsList);
        System.out.println();
        
        //Sorting Array using Comparable (Ascending X values)
        Arrays.sort(points);
        for (Point p : points) {
            System.out.println(p);
        }
        System.out.println();
        
        //Sorting Array using Comparator (Ascending Y values)
        Arrays.sort(points, new CompareByY());
        for (Point p : points) {
            System.out.println(p);
        }
        System.out.println();
        
        //Sorting list using Comparable (Ascending X values)
        Collections.sort(pointsList);
        pointsList.forEach( (n) -> { System.out.println(n); } );
        System.out.println();
        
        //Sorting list using Comparator (Ascending Y values)
        Collections.sort(pointsList, 
            (Point po1, Point po2) -> ((po1.getY() == po2.getY())) ? po1.getX() - po2.getX() : po1.getY() - po2.getY());
        pointsList.forEach( (n) -> { System.out.println(n); } );
        System.out.println();
    }
}
