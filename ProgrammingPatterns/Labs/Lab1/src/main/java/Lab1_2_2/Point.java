package Lab1_2_2;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Point implements Comparable<Point>{
    private int x;
    private int y;
    
    public Point() {
        this.x = 0;
        this.y = 0;
    }
    
    public Point(int x1, int y1) {
        this.x = x1;
        this.y = y1;
    }
    
    @Override
    public String toString() {
        return String.format("X = %d - Y = %d", x, y);
    }
    
    @Override
    public int compareTo(Point p) {
        if (this.x == p.x) 
            return this.y - p.y;
        else 
            return this.x - p.x;
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }  
}