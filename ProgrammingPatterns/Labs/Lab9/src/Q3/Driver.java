package Q3;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        Set hs = Collections.synchronizedSet(new HashSet());
        synchronized(hs) {
            Iterator it = hs.iterator();
        }
    }
}
