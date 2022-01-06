
package Q4;

import java.util.*;

/**
 *
 * @author Anthony
 */
class Lab9Q3n4{
Set hashSet = Collections.synchronizedSet(new HashSet());

//  class Task1 implements Runnable {
//    public void run(){
//      for (int i = 0; i < 10000; i++) {
//        System.out.println("Thread 1");
//        hashSet.add(new Integer(i));
//        try { Thread.sleep(1000); } catch (Exception ex) {
//          ex.printStackTrace();
//        }
//      }
//    }
//  }

  class Task2 implements Runnable {
    @Override
    public void run() {
      while (true) {
        System.out.println("Thread 2");
        try { Thread.sleep(1000); } catch (Exception ex) {
          ex.printStackTrace();
        }

         Iterator iterator = hashSet.iterator();

          while (iterator.hasNext()) {
            System.out.println(iterator.next());
          }
        
      }
    }
  }

    public static void main(String[] tt){
        Set hashSet = Collections.synchronizedSet(new HashSet());
        new Thread(()->{
        for (int i = 0; i < 10000; i++) {
            System.out.println("Thread 1");
            hashSet.add(i);
            try { Thread.sleep(1000); } catch (Exception ex) {
                ex.printStackTrace();
        }
      }
    }).start();
    
        new Thread(()->{
        while (true) {
            System.out.println("Thread 2");
            try { Thread.sleep(1000); } catch (Exception ex) {
                ex.printStackTrace();
            }
            synchronized (hashSet) { // Must synchronize it
                Iterator iterator = hashSet.iterator();

                while (iterator.hasNext()) {
                    System.out.println(iterator.next());
                }
            }
         }
    }).start();
    }
}
