package Lab1_2_2;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class CompareByY implements Comparator<Point>{
    
    @Override
    public int compare(Point p1, Point p2) {
        if(p1.getY() == p2.getY())
            return p1.getX() - p2.getX();
        else
            return p1.getY() - p2.getY();
    }
}
