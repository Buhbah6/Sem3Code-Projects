package Iterator;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        List <Student> listOne = new ArrayList<>();

        listOne.add(new Student("12678","Harry",3.6));
        listOne.add(new Student("13679","Eric",2.9));
        listOne.add(new Student("14666","Jean",3.5));

        for (Student e:listOne) 
            System.out.println("GPA is " + e.getGpa());

        System.out.println("Using Iterator "); 

        Iterator<Student> it = listOne.iterator(); 
        while(it.hasNext()) {
            Student item = it.next();
            System.out.println(item.getGpa());
        }
        
        it = listOne.iterator();
        System.out.println("Printing again ");
        while(it.hasNext()) {
            Student item = it.next();
            System.out.println(item.getGpa());
        }
        
        while (it.hasNext()) {
            Student item = it.next();
            if (item.getGpa() == 2.9)
                it.remove();
            else
                System.out.println(item.getGpa());
        }
    }
}
