package Part2;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        
        // Creating the objects
        Student s1 = new Student("George", 87);
        Student s2 = new Student("Jonathan", 96);
        Student s3 = new Student("Candice", 54);
        Student s4 = new Student("Lisa", 70);
        Student s5 = new Student("Kevin", 77);
        
        // Storing them in an array and making the array into and ArrayList
        Student[] sArr = {s1, s2, s3, s4, s5};
        ArrayList<Student> sArrList = new ArrayList(Arrays.asList(sArr));
       
        //  Q1 - Part 1 - stream to sort the ArrayList in increasing order by score
        System.out.println("Students ordered by score (increasing order): ");
        sArrList.stream()
                .sorted((stu1, stu2) -> stu1.getScore() - stu2.getScore())
                .forEach(student -> System.out.println(student.getName()));
        
        System.out.println();
        
        //  Q1 - Part 2 - stream to get the 3 highest scores
        System.out.println("Students with the top 3 scores: ");
        sArrList.stream()
                .sorted((stu1, stu2) -> stu2.getScore() - stu1.getScore())
                .limit(3)
                .forEach(student -> System.out.println(student.getName()));
        
        System.out.println();
    
        //  Q1 - Part 3 - stream to sort the ArrayList in increasing order by name length
        System.out.println("Students ordered by length of their name (increasing order): ");
        sArrList.stream()
                .sorted((stu1, stu2) -> stu1.getName().length() - stu2.getName().length())
                .forEach(student -> System.out.println(student.getName()));
        
        System.out.println();
        
        //  Q1 - Part 4 - filters out all the student names that don't start with "Jo"
        System.out.println("Students whose name starts with \"Jo\": ");
        sArrList.stream()
                .filter(student -> student.getName().startsWith("Jo"))
                .forEach(student -> System.out.println(student.getName()));
        
        System.out.println();
    }
}
