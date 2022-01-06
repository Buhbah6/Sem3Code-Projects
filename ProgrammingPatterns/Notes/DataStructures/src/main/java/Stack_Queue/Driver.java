package Stack_Queue;

/**
 * @author Anthony
 */
public class Driver {
   
    public static void main(String[] args) {
        MyStack<Integer> stack1 = new MyStack<>();
        
        stack1.push(1);
        stack1.push(2);
        stack1.push(3);
        stack1.push(4);
        
        System.out.println(stack1);
        System.out.println(stack1.peek());
        System.out.println("After Peek :" + stack1);
        System.out.println("The element removed: " + stack1.pop());
        System.out.println("After pop: " + stack1);
        
        System.out.println();
        
        MyQueue<String> queue1 = new MyQueue<>();

        queue1.enqueue("first");
        queue1.enqueue("second");
        queue1.enqueue("third");
        queue1.enqueue("last");

        System.out.println(queue1);
        System.out.println(queue1.first());
        System.out.println("After dequeue :");
        queue1.dequeue();
        queue1.dequeue();
        System.out.println(queue1);
    
    }
}
