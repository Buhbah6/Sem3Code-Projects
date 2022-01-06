package Lecture;

import static java.lang.Thread.sleep;
import java.util.Comparator;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

/**
 * @author Anthony Nadeau
 */
public class MTAndParallelProg {

// -----Using Threads-----    
    
//    public static void main(String[] args) {
//        Thread thNum = new Thread(new PrintInts());
//        thNum.setPriority(Thread.MAX_PRIORITY);
//        thNum.start();
//        new Thread(new PrintA()).start();
//        new Thread(new PrintB()).start();
//        new Thread(new PrintInts()).start();
//        new Thread(new PrintChar('c', 100)).start();
//        new Thread(new PrintChar('d', 100)).start();
//        new Thread(new PrintChar('e', 100)).start();
//        new Thread(new PrintChar('f', 100)).start();
//        new Thread(new PrintOneChar()).start();
//
//        new Thread(() -> {
//            try {
//                for (int i = 1; i <= 100; i++) {
//                    System.out.println(Thread.currentThread().getName() + ": " + "X");
//                    if (i == 50) sleep(1000);
//                }
//            }
//            catch(Exception ex) {}
//        }).start();
//    }
    
    
// -----Using Executors-----    
  
    public static void main(String[] args) {
        ExecutorService executor = Executors.newCachedThreadPool();  
        executor.execute(new PrintA()); 
        executor.execute(new PrintB()); 
        executor.execute(new PrintInts());
        executor.shutdown();
        
        while (!executor.isTerminated()) {}
        System.out.println("--All tasks have been completed--");
    }
}

// The following 2 classes can be replaced by the class at the bottom
class PrintA implements Runnable {

    @Override
    public void run() {
        for (int i = 1; i <= 100; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + "a");
            Thread.yield();
        }
    }
}

class PrintB implements Runnable {

    @Override
    public void run() {
        for (int i = 1; i <= 100; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + "b");
        }
    }
}

class PrintInts implements Runnable {

    @Override
    public void run() {
        Thread th4 = new Thread(new PrintA());
        for (int i = 1; i <= 100; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + i);
            if (i == 50) { 
                try {
                    th4.join();
                } 
                catch (InterruptedException ex) {}
            }
        }
    }
}

class PrintChar implements Runnable {

    private char c;
    private int iterations;

    public PrintChar(char c, int iterations) {
        this.c = c;
        this.iterations = iterations;
    }

    @Override
    public void run() {
        for (int i = 0; i < iterations; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + c);
        }
    }
}

class PrintOneChar implements Runnable {

    @Override
    public void run() {
        System.out.println(Thread.currentThread().getName() + ": X");
    }
}

class CompareName implements Comparator<String> {

    @Override
    public int compare(String o1, String o2) {
        return o1.compareTo(o2);
    }

}
