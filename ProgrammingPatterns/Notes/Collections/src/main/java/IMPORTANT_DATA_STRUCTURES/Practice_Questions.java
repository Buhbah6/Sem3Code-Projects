package IMPORTANT_DATA_STRUCTURES;

/**
 * @author Anthony
 */
public class Practice_Questions {
    
    /* 1.
        List<String> nameList = new LinkedHashSet<>();
        
        The error above is the "List" cast because a set cannot be a list
    
        Set<String> nameSet = new LinkedHashSet<>();
    */
    
    /* 2.
        List<String> nameList = new ArrayList();
        ListIterator it = new ListIterator(nameList);
        
        The error is that ListIterator does not have the given constructor
    
        List<String> nameList = new ArrayList();
        ListIterator it = nameList.listIterator()
    */
    
    /* 3.
        Set<String> nameSet = new HashSet<>();
        nameSet.add("Kevin");
        nameSet.add("Ahmed");
        ListIterator it = nameSet.listIterator();
    
        The error is that a set does not use the listIterator as it isn't a list
    
        Set<String> nameSet = new HashSet<>();
        nameSet.add("Kevin");
        nameSet.add("Ahmed");
        Iterator it = nameSet.iterator();
    */
    
    /* 4.
        List<String> nameList = new ArrayList<>();
        ListIterator it = nameList.ListIterator();
        it.set("nameSet");
    
        The error is the capital "L" in the listIterator method
    
        List<String> nameList = new ArrayList<>();
        ListIterator it = nameList.listIterator();
        it.set("nameSet");
    */
    
    /* 5.
        Set<String> nameSet = new HashSet<>();
        nameSet.add("Kevin");
        nameSet.add("Ahmed");
        Collections.sort(nameSet)
    
        The error is that the HashSet cannot be sorted, as the Collections.sort() method
        requires a List and as stated in #1, sets are not lists
    
        Set<String> sortedSet = new TreeSet<>();
    */
    
    /* 6.
        Queue<String> list = new LinkedList();
        list.addFirst("George");
        list.addFirst("Alvin");
        list.addFirst("Veronique");
        ListIterator<String> it = list.listIterator();
        it.set("newStudent");
    
        The error is the addFirst method, as it does not exist in the Queue class
        and the ListIterator should be a normal iterator.
    
        Queue<String> list = new LinkedList();
        list.add("George");
        list.add("Alvin");
        list.add("Veronique");
        Iterator<String> it = list.iterator();
        it.set("newStudent");
    */
}
