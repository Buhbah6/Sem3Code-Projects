package Lecture2_2;

import java.util.*;

/**
 * @author Anthony
 */
public class UsingSynchronizedWrappers {
    
    public static void main(String[] args) {
        String[] arr = {"end", "of", "semester", "is", "soon"};
        Set set1 = new HashSet(Arrays.asList(arr));
        Set set2 = Collections.synchronizedSet(set1);
        
        Thread th = new Thread(new Task(set2));
        th.start();
        
        Iterator it = set2.iterator();
        while (it.hasNext()) {
            System.out.println(it.next());
        }
    }
}

class Task implements Runnable {
    Set set;

    public Task(Set set) {
        this.set = set;
    }
    
    @Override
    public void run() {
        Iterator it = set.iterator();
        while (it.hasNext()) {
            System.out.println(it.next());
        }
    }
}
