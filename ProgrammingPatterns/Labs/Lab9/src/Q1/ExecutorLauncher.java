package Q1;

import java.util.concurrent.*;

/**
 * @author Anthony Nadeau
 */
public class ExecutorLauncher {
    
    public static void main(String[] args) {
        ExecutorService executor = Executors.newFixedThreadPool(1000);
        
        for (int i = 0; i < 1000; i++) {
            executor.execute(new AddOne());
        }
        executor.shutdown();
        
        while(!executor.isTerminated());
        
        System.out.println("All threads done...Sum is " + AddOne.sum);
    }
}
