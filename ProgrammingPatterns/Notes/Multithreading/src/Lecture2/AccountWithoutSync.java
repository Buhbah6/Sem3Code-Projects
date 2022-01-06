package Lecture2;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

/**
 *
 * @author Anthony
 */
public class AccountWithoutSync {
    private static Account account = new Account();

    public static void main(String[] args) {
        ExecutorService executor =  
        Executors.newCachedThreadPool();

        for (int i = 0; i < 100; i++) {
        executor.execute(new AddAPennyTask(account));
        }
        executor.shutdown();
        while (!executor.isTerminated()) {       }
            
        System.out.println("What is balance? " + account.getBalance());
    }
}

