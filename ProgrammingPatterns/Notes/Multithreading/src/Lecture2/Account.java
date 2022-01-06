package Lecture2;

import java.util.concurrent.locks.*;

/**
 * @author Anthony Nadeau
 */
public class Account {
    private static Lock lock = new ReentrantLock();
    private int balance = 0;

    public int getBalance() {
      return balance;    }

    public void deposit(int amount) {
        lock.lock();
        int newBalance = balance + amount;
        try {Thread.sleep(5);}
        catch (InterruptedException ex) {}
        finally {
            lock.unlock();
        }
        balance = newBalance;
    }
}
