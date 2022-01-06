package Lab1_2_1;

import java.util.*;

/**
 * @author Anthony
 */
public class Driver {
    
    public static void main(String[] args) {
        Horse h1 = new Horse("Jerry", "Brown", 1990);
        Horse h2 = new Horse("Harry", "Black", 2010);
        RaceHorse rh1 = new RaceHorse("Randy", "Red", 1980, 80);
        RaceHorse rh2 = new RaceHorse("Gander", "Green", 1981, 81);
        RaceHorse rh3 = new RaceHorse("Bertholdt", "Blue", 1982, 82);
        Horse[] horses = {h1, h2, rh1, rh2, rh3};
        Arrays.sort(horses, new CompareByName());
        for (Horse h : horses) {
            h.display();
        }
        
        List horsesList = Arrays.asList(horses);
        Collections.sort(horsesList);
        Collections.reverse(horsesList);
        Collections.reverse(horsesList);
        
    }
}
