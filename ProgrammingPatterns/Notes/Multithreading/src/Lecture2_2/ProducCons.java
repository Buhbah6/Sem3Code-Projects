package Lecture2_2;

import java.util.*;
import java.util.concurrent.*;

/**
 * @author Anthony
 */
public class ProducCons {
    
    private static ArrayBlockingQueue<Integer> buffer
                          = new ArrayBlockingQueue<>(2);

    public static void main(String[] args) {
        // Create a thread pool with two threads
        ExecutorService executor = Executors.newFixedThreadPool(2);
        executor.execute(new ProducerTask());
        executor.execute(new ConsumerTask());
        executor.shutdown();
    }
    
    private static class ConsumerTask implements Runnable {
        public void run() {
            try {
                while (true) {
                    System.out.println("\t\t\tConsumer reads " + buffer.take());
                    Thread.sleep((int) (Math.random() * 10000));  }
            } 
            catch (InterruptedException ex) {
                ex.printStackTrace(); 
            }
        }
    }
    
    private static class ProducerTask implements Runnable {
        public void run() {
            try {
                int i = 1;
                while (true) {
                    System.out.println("Producer writes " + i);
                    buffer.put(i++);
                    Thread.sleep((int) (Math.random() * 10000));
                }
            } 
            catch (InterruptedException ex) {
                      ex.printStackTrace();   
            }
        }
    }
}
