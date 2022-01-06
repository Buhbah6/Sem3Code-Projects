package Q1;

import java.util.concurrent.locks.*;

/**
 * @author Anthony Nadeau
 */
public class AddOne implements Runnable{
    static Integer sum = 0;
    //private static Lock lock = new ReentrantLock();
    
    @Override
    public void run() {
        //lock.lock();
        addUnit();
        //lock.unlock();
    }
    
    public static synchronized void addUnit() {
        sum += 1;
    }   
}
