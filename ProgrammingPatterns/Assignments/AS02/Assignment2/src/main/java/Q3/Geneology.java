package Q3;

import java.util.*;
import java.io.*;

/**
 * @author Anthony Nadeau && Konstantinos Nikopolous
 */
public class Geneology {
    // Instance Variable - HashMap to store Ancestor as key, with all Descendants as data
    private HashMap<String, ArrayList<String>> peopleDetails;
  
    /**
     * Default Constructor - reads from file and stores data in the hashMap
     * @throws FileNotFoundException Required Exception handling with File IO
     */
    public Geneology() throws FileNotFoundException {
        peopleDetails = new HashMap<>();
        retrieveDataFromFile("src/test/resources/AS03.txt");
    }
    
    /**
     * Retrieves all the data in the file and stores the necessary information inside the hashMap
     * @param fileName name of the file to be read.
     * @throws FileNotFoundException Required Exception handling with File IO
     */
    private void retrieveDataFromFile(String fileName) throws FileNotFoundException
    {
        int noOfPeople;
        int noOfDescendants;
        int count = 0;  
        String pName;
        String cName;
        Scanner fileReader = new Scanner(new File(fileName));
      
        noOfPeople = fileReader.nextInt();
        System.out.println("All people in the file: ");
        while(count < noOfPeople && fileReader.hasNextLine()) {
            pName = fileReader.next();  
            System.out.print(pName + " ");
            noOfDescendants = fileReader.nextInt();
           
            for(int i = 0; i < noOfDescendants; i++) {
                cName = fileReader.next();
                assignDescendants(pName, cName);
            }
            count++;
        }
        System.out.println();
    }
    
    /**
     * Arranges Data inside the HashMap so that all descendants are recorded
     * with their respective ancestors
     * @param parent ancestor name
     * @param child descendant name
     */
    public void assignDescendants(String parent, String child) {
        ArrayList<String> data = new ArrayList<>();   
        if (peopleDetails.containsKey(parent)) {
            data = peopleDetails.get(parent);
            data.add(child);
        }
        else {
            data.add(child);
            peopleDetails.put(parent, data);
        }
    }    
    
    /**
     * Retrieves the descendants of a given ancestor from the hashmap
     * @param parent name of ancestor
     * @return all descendants of "parent"
     */
    public ArrayList<String> getDescendants(String parent)
    {
        if (peopleDetails.containsKey(parent)) {
            ArrayList<String> data = peopleDetails.get(parent);
            if (data == null)
                System.out.println("No descendants found");
            return data;
        }
        else {
            return null;
        }
    }
    
    /**
     * Checks if a person is a type of descendant of another
     * @param parent ancestor
     * @param child potential descendant
     * @return true or false; if the "child" is a descendant of the "parent"
     */
    public boolean isDescendant(String parent, String child) {
        // ArrayList to store the direct children of the given parent
        ArrayList<String> data = getDescendants(parent);
        
        // ArrayList to store the family tree
        ArrayList<String> familyTree = new ArrayList<>();
        boolean condition = true; // basic condition for the later while loop
        familyTree.add(parent);
        int itr = 0;
        int itr2 = 0;
        
        // verifies if the parent has any descendants at all
        if (data == null) {
            System.out.println(parent + " has no descendants");
            return false;
        }
        // verifies if the child is a DIRECT descendant of the parent
        else if (data.contains(child)) {
            System.out.println(parent + " -> " + child);
            return true;
        }
        else {
            // verifies if the child is the descendant of a descendant of the parent
            while (condition) {
                String descendant = data.get(itr);
                if (getDescendants(descendant).contains(child)) {
                    familyTree.add(descendant);
                    familyTree.add(child);
                    displayFamilyTree(familyTree);
                    return true;
                }
                else if (itr < data.size()){
                    itr++; // used to iterate the "if" statement above
                }
                else if (itr2 < data.size()) {
                    //recursive call if the child is potentially more than 2 generations in
                    if (isDescendant(data.get(itr2), child)) {
                        familyTree.add(data.get(itr2));
                        familyTree.add(child);
                        displayFamilyTree(familyTree);
                        return true;
                    }
                    else
                        itr2++; // used to iterate the "if" statement above
                }
                else
                    condition = false; //ends while Loop
            }
            System.out.println(child + " is not a descendant of " + parent);
            return false;
        }
    }
    
    /**
     * Formats output to show the order of the family tree
     * @param famTree list of family members
     */
    public void displayFamilyTree(ArrayList<String> famTree) {
        String str = "";
        int count = 1;
        for (String person : famTree) {
            if (count == famTree.size()) {
                str += person;
            }
            else {
                str += person + " -> ";
                count++;
            }
        }
        System.out.println(str);
    }
}
