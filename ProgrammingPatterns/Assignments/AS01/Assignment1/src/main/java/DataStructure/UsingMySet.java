package DataStructure;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class UsingMySet {
    
    public static void main(String[] args) {
        
    // Creating Array and List for constructor
        Integer[] array = {1, 3, 5, 7, 9};
        Integer[] listSet = {1, 2, 6, 14, 300};
        List<Integer> list = Arrays.asList(listSet);
    
    // Creating 3 MySet objects using each constructor
        MySet<Integer> set1 = new MySet();
        MySet<Integer> set2 = new MySet(array);
        MySet<Integer> set3 = new MySet(list);
    
    // Populating the empty set
        set1.add(1);
        set1.add(2);
        set1.add(3);
        set1.add(4);
        set1.add(5);
        
    // Printing each sets content
        System.out.println("Displaying the initial contents of each set");
        display(set1);
        display(set2);
        display(set3);
        System.out.println();
       
    // Testing every Method to show all the methods work.    
        
        // add method -> add(E element)
        System.out.println("Printing the results of the add method in set 1 by "
                + "adding a non-distinct and distinct value.");
        System.out.println("Trying to add '1': ");
        System.out.println(set1.add(1));
        System.out.println("Trying to add '6': ");
        System.out.println(set1.add(6));
        display(set1);
        System.out.println();
        
        // removeElem method -> removeElem(E element)
        System.out.println("Printing the results of the remove method in set 1 by "
                + "removing one value in the set and one not in the set");
        System.out.println("Trying to remove '6': ");
        System.out.println(set1.removeElem(6));
        System.out.println("Trying to remove '20': ");
        System.out.println(set1.removeElem(20));
        display(set1);
        System.out.println();
        
        // union method -> union(MySet<E> otherSet)
        System.out.println("Displaying the sets post-union");
        set1.union(set2);
        System.out.println("Set 1: ");
        display(set1);       //display(set1);
        System.out.println("Set 2: ");
        display(set2);
        System.out.println();

        // intersection method -> intersection(MySet<E> otherSet)
        System.out.println("Displaying the sets pre-intersection");
        System.out.println("Set 1: ");
        display(set1);
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Displaying the sets post-intersection");
        set1.intersection(set3);
        System.out.println("Set 1: ");
        display(set1);
        System.out.println("Set 3: ");
        display(set3);
        System.out.println();
            
        // difference method -> difference(MySet<E> otherSet)
        System.out.println("Displaying the sets pre-difference");
        System.out.println("Set 2: ");
        display(set2);
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Displaying the sets post-difference");
        set2.difference(set3);
        System.out.println("Set 2: ");
        display(set2);
        System.out.println("Set 3: ");
        display(set3);
        System.out.println();
        
        // clear method
        System.out.println("Showing the clear method");
        System.out.println("Set 3 before clear: ");
        display(set3);
        set3.clear(); 
        System.out.println("Set 3 after clear: ");
        display(set3);
        System.out.println();
        
        // isEmpty method
        System.out.println("Showing the isEmpty method");
        System.out.println("Set 3 isEmpty when empty: ");
        System.out.println(set3.isEmpty());
        System.out.println("Set 3 isEmpty when populated: ");
        set3.add(1);
        System.out.println(set3.isEmpty());
        System.out.println();
        
        // contains method
        System.out.println("Showing the contains method");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Set 3 contains '1': ");
        System.out.println(set3.contains(1));
        System.out.println("Set 3 contains '300': ");
        System.out.println(set3.contains(300));
        System.out.println();
        
        // indexOf method
        System.out.println("Showing the indexOf method");
        set3.add(2); set3.add(3); set3.add(4); set3.add(5);
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Index of '3' in set 3: ");
        System.out.println(set3.indexOf(3));
        System.out.println("Index of '72' in set 3: ");
        System.out.println(set3.indexOf(72));
        System.out.println();
    
        // get method
        System.out.println("Showing the get method");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Getting the value at index 1 in set 3: ");
        System.out.println(set3.get(1));
        System.out.println("Getting the value at index 3 in set 3: ");
        System.out.println(set3.get(3));
        System.out.println();
        // anything outside the range of 0 -> size - 1 will throw an exception
        
        // set method
        System.out.println("Showing the set method");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Setting the value at index 4 to 37: ");
        set3.set(37, 4);
        display(set3);
        System.out.println();
        
        // size method
        System.out.println("Showing the size method");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Size of set 3 is: ");
        System.out.println(set3.size());
        System.out.println();
        
        // add method -> add(int index, E object)
        System.out.println("Showing the add method using the index");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Adding 8 at index 4: ");
        set3.add(4, 8);
        display(set3);
        System.out.println("Adding 1 at index 1: ");
        set3.add(2, 1);
        display(set3);
        System.out.println();
        
        // remove method -> remove(int index)
        System.out.println("Showing the remove method using the index");
        System.out.println("Set 3: ");
        display(set3);
        System.out.println("Removing the value at index 2: ");
        System.out.println("Value: " + set3.remove(2));
        display(set3);
        System.out.println();
    }
    
    public static void display(MySet set) {
        for (int i = 0; i < set.size(); i++) {
            System.out.print(set.get(i) + " ");
        }
        System.out.println();
   }
}
