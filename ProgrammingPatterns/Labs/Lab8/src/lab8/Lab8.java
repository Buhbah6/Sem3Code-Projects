/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab8;

/**
 *
 * @author Anthony
 */
public class Lab8 {
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws Exception{
        long startTime = System.currentTimeMillis();
        Thread[] allThreads = new Thread[4];
//        for(int i=0; i<=3;i++)allThreads[i] = new Thread(new Process(2000000*(i+1), 2000000*(i+1)+1000000));
        allThreads[0] = new Thread(new Process(2000000, 3000000));
        allThreads[1] = new Thread(new Process(3000001, 4000000));
        allThreads[2] = new Thread(new Process(4000001, 5000000));
        allThreads[3] = new Thread(new Process(5000001, 6000000));

        for(int i=0; i<=3;i++) allThreads[i].start();
        
         for(int i=0; i<=3;i++) { 
         while(allThreads[i].isAlive()) allThreads[i].join();
         }
         
         long elapsedTime = System.currentTimeMillis() - startTime;
        System.out.println();
        System.out.println("Elapsed Time: " + elapsedTime);
    }
    
}   

class Process implements Runnable {
    int min;
    int max;

    public Process(int min, int max) {
        this.min = min;
        this.max = max;
    }
    
    public static boolean isPrime(int x) {
        int top = (int) Math.sqrt(x);
        for (int i = 2; i <= top; i++) {
            if (x % i == 0) {
                return false;
            }
        }
        return true;
    }

    @Override
    public void run() {
        int count = 0;
        for (int i = min; i <= max; i++) {
            if (isPrime(i)) {
               count++; 
            }
        }
        System.out.println("Count: " + count);
    }
}
 