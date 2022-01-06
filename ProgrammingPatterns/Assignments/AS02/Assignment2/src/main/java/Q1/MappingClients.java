package Q1;

import java.util.*;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class MappingClients { // DRIVER CLASS
    
    public static void main(String[] args) {
        
        // Creating clients with Keys and Data
        Client c1 = new Client(new Key("5146789065", "Anderson@gmail.com"),
                new Data("Karl Anderson", "1999 Netherland"));
        Client c2 = new Client(new Key("1234567890", "jsmith@outlook.com"),
                new Data("John Smith", "123 America St"));
        Client c3 = new Client(new Key("0987654321", "ginetteetjean@yahoo.com"),
                new Data("Ginette Lafontaine", "14 rue Marie-Victorin"));
        Client c4 = new Client(new Key("4505172737", "tonynadeau03@gmail.com"),
                new Data("Anthony Nadeau", "1914 boul Saint-Louis"));
        
        // Storing these clients in a hashMap
        HashMap<Key, Data> map1 = new HashMap();
        map1.put(c1.getKey(), c1.getData());
        map1.put(c2.getKey(), c2.getData());
        map1.put(c3.getKey(), c3.getData());
        map1.put(c4.getKey(), c4.getData());
        
        // Printing out the hashMap
        System.out.println(map1);
        
        // Converting hashMap into a treeMap
        TreeMap<Key, Data> map2 = new TreeMap(map1);
        
        // Printing out the treeMap
        System.out.println("Treemap:");
        System.out.println(map2);
    }
    
}
