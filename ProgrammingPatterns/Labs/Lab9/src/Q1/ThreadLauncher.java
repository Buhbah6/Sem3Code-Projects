package Q1;

/**
 * @author Anthony Nadeau
 */
public class ThreadLauncher {
    
    public static void main(String[] args) throws Exception {
        //a. a.	Write a program that launches 1,000 threads. Each thread adds 1 
        //to a variable sum that initially is 0.
        
        Thread[] threads = new Thread[1000];
        
        for (int i = 0; i < 1000; i++) {
            threads[i] = new Thread(new AddOne());
            threads[i].start();
        }
        
        for (int i = 0; i < 1000; i++) {
            while(threads[i].isAlive()) {
                threads[i].join();
            }
        }
        System.out.println("All threads done...Sum is " + AddOne.sum);
   }
}
