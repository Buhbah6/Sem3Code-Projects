package UsingMaps_1;

import java.util.*;

/**
 * @author Anthony
 */
public class ExploringMaps {
    
    public static void main(String[] args) {
        
        // THE MAP INTERFACE -> maps keys to elements, like mapping a phone number to a name.
        // keys can be any objects
        
        // There are 3 concrete data structures that implement the map interface
        
        // HASHMAP -> Basic map -> think Primary Key and Value in DB
        
        // in the example below, the key is the name - String
        // like in databases, the keys (PK) should be unique, and we ensure this with
        // the hash code and equals() 
        
        Map<String, Integer> hashMap1 = new HashMap();
        hashMap1.put("Smith", 30); // 30 is later overridden by the 32
        hashMap1.put("Anderson", 31);
        hashMap1.put("Lewis", 29);
        hashMap1.put("Cook", 29);
        hashMap1.put("Smith", 32); // Java prioritizes the latest element to map to the key.
        System.out.println("Entries in hashMap1");
        System.out.println(hashMap1 + "\n");
        
        // TREEMAP -> Sorted Map -> like the HashSet and TreeSet -> DICTIONARY
        
        // in the example below, it sorts the names alphabetically, and if the
        // key was a number, it would sort numerically.
        
        Map<String, Integer> treeMap = new TreeMap<>(hashMap1);
        treeMap.put("Bob", 25);
        System.out.println("Entries in treeMap");
        System.out.println(treeMap + "\n");
        
        // LINKEDHASHMAP -> like the HashMap but linked
        
        // Has 2 orders -> insertion order and access order
        // Insertion order -> order of which elements are added
        // Access order -> order of which objects have been accessed
        
        // Example of access order:
        // if a method accesses a key, it will be the most recent access and thus
        // will be at the end. It goes from older access to younger access.
        
        Map<String, Integer> linkedHashMap = new LinkedHashMap<>(16, 0.75f, true);
        linkedHashMap.put("Smith", 30);
        linkedHashMap.put("Anderson", 31);
        linkedHashMap.put("Lewis", 29);
        linkedHashMap.put("Cook", 29);
        System.out.println("The age for Lewis is " + linkedHashMap.get("Lewis"));
        System.out.println("Entries in linkedHashMap");
        System.out.println(linkedHashMap + "\n");


    }
}
