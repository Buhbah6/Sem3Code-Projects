package Stack_Queue;

import java.util.*;

/*
 * @author Anthony
 */
public class MyQueue<E> {
    private LinkedList<E> queue;
    
    public MyQueue() { 
       queue=  new LinkedList<E>(); 
    }
    
    public E first()  { 
        return queue.getFirst();
    }

    public void enqueue(E e) { 
        queue.addLast(e); 
    } 
    
    public E dequeue() { 
        return queue.removeFirst(); 
    } 
    
    public int getSize() { 
        return queue.size(); 
    } 
    
    @Override 
    public String toString() { 
        return "Queue: " + queue.toString(); 
    } 
} 