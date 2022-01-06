package ImplementingLists;

/**
 * @author Anthony
 */
public class Driver {
    
    public static void main(String[] args) {
        MyLinkedList<String> list1 = new MyLinkedList();
        
        list1.addFirst("Vanier");
        list1.addFirst("College");
        
        list1.addLast("Vanier");
        list1.addLast("College");
        
        for (int i = 0; i < list1.size(); i++) {
            System.out.println(list1.get(i));
        }
        System.out.println("The size is: "+ list1.size());
    }
}
