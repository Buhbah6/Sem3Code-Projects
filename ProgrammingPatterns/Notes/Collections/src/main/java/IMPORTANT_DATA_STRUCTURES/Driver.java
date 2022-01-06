package IMPORTANT_DATA_STRUCTURES;

import java.util.*;

/**
 * @author Anthony
 */
public class Driver {

    public static void main(String[] args) {
        
        /*
        When using structures/interfaces like stack or queue, model your code 
        based on the form you hve chosen, if you need other functions try a 
        different structure and/or interface.
        */
        
        // STACK -> Think pile - can do stuff with the top but you can't access the others till the top is gone
        
        // Can only make an empty stack. Not from an array or a list.
        // Cannot Downcast either
        Stack<Integer> oneStack = new Stack<>();

        oneStack.push(5);
        oneStack.push(8);
        oneStack.push(100);

        // Since we cannot access the middle or bottom of the stack, we just pop it
        while(!oneStack.isEmpty()) 
            System.out.println(oneStack.pop());
        System.out.println();
        
        
        // QUEUE -> Think lines - works like a line in any store, FIFO/LILO
        
        // Queue is an interface, not a data stucture, so it must be initialized with a Linked List
        Queue<String> myQueue = new LinkedList<>(); 
        
        // offer adds elemets into the queue
        myQueue.offer("Oklahoma"); 
        myQueue.offer("Indiana"); 
        myQueue.offer("Georgia"); 
        myQueue.offer("Texas"); 
        
        
        
        // Since we can only see the element at the head, we loop through and remove it.
        while (myQueue .size() > 0) 
            System.out.println(myQueue.remove() + " ");  
        System.out.println();


        // Java LinkedList is doubly linked, which means your deque can go forwards or backwards.
        // Deque = double ended queue
        
        
        // PRIORITY QUEUE -> Think hospital - It functions as a normal queue but there may be priority cases
        
        // EXAMPLE ONE
        // Priority Queue is a data structure, so you can initialize it normally
        PriorityQueue<String> queue1 = new PriorityQueue<>();
        
        queue1.offer("Montreal");
        queue1.offer("Ottawa");
        queue1.offer("Toronto");
        queue1.offer("Quebec");
        queue1.offer("Florida");
        
        System.out.println("Priority queue using Comparable:");
        
        // Don't do foreach - it eliminates the purpose of a PRIORITY queue
        while (queue1.size() > 0) {
            System.out.println(queue1.remove() + "");
        }
        
        // EXAMPLE TWO
        PriorityQueue<String> queue2 = new PriorityQueue<>(Collections.reverseOrder());
        
        queue2.offer("Montreal");
        queue2.offer("Ottawa");
        queue2.offer("Toronto");
        queue2.offer("Quebec");
        queue2.offer("quebec");
        queue2.offer("Florida");
        
        System.out.println("\nPriority queue using Comparator:");
        while (queue2.size() > 0) {
            System.out.println(queue2.remove() + "");
        }
        
        // EXAMPLE THREE
        PriorityQueue<String> queue3 = new PriorityQueue<>((s1, s2) -> s1.length() - s2.length());
        
        queue3.offer("Montreal");
        queue3.offer("Ottawa");
        queue3.offer("Toronto");
        queue3.offer("Quebec");
        queue3.offer("quebec");
        queue3.offer("Florida");
        queue3.offer("Flo");
        
        System.out.println("\nPriority queue using Lambda exp (priority = shortest):");
        while (queue3.size() > 0) {
            System.out.println(queue3.remove() + "");
        }
    }
}
