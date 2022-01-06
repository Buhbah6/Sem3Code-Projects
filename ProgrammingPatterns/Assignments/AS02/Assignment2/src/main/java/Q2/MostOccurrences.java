package Q2;

import java.util.*;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class MostOccurrences {
   
    public static void main(String[] args) {
        // Creating a Scanner for user input and an arrayList to store inputted integers
        Scanner console = new Scanner(System.in);
        ArrayList<Integer> ints = new ArrayList<>();
        
        // Creating hashMaps to store data, and occurrences of that data in the arrayList
        HashMap<Integer, Integer> intMap = new HashMap();
        HashMap<Integer, Integer> intMap2 = new HashMap();
        
        // Temp is used for looping structures to control iterations
        int temp = 1;
        
        // Taking User input
        System.out.println("Please enter a series of numbers, with each one on a new line.");
        System.out.println("Enter 0 to mark the end of the list.");
        while (temp != 0) {
            // try-catch block in while loop to ensure all user-inputted values are valid
            try {
                temp = console.nextInt();
                ints.add(temp);
            }
            catch(InputMismatchException e) {
                System.out.println("Invalid Value. Was not included in the list.");
            }
        }
        
        // Loop that adds all the data from the arrayList to the 1st map and calculates occurrences
        for (Integer it : ints) {
            if (intMap.containsKey(it)) {
                intMap.put(it, intMap.get(it) + 1);
            }
            else {
                intMap.put(it, 1);
            }
        }
        
        // Loop that finds the data with the most occurrences and stores it in the 2nd map
        for (Integer it : ints) {
            int mostOccurrences = Collections.max(intMap.values());
            if (intMap.get(it) == mostOccurrences)
                intMap2.put(it, mostOccurrences);
        }
             
        // Set created from map (used to display the value with most occurrences)
        Set set = intMap2.entrySet();
        System.out.println("Most Occuring Values (Value=Occurrences): ");
        for  (Object it2 : set) {
                System.out.println(it2);
        }
    }
}
