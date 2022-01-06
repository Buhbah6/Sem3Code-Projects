package Q4_2;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
       List<Student> list = new ArrayList();
       
       list.add(new Student(1, "CS100"));
       list.add(new Student(3, "CS100"));
       list.add(new Student(1, "CS200"));
       list.add(new Student(2, "MATH101"));
       list.add(new Student(2, "CS100"));
       list.add(new Student(2, "ELA203"));
       list.add(new Student(1, "MATH202"));
       list.add(new Student(1, "PE104"));
       list.add(new Student(2, "CS300"));                    
       list.add(new Student(4, "CS100"));        
       list.add(new Student(3, "CS200"));        
       list.add(new Student(4, "CS500"));        
       list.add(new Student(3, "CS300"));        
       list.add(new Student(4, "CS400"));        
       list.add(new Student(3, "CS400"));        
       list.add(new Student(4, "MATH101"));        
       
       HashMap<Integer, ArrayList<String>> stuMap = new HashMap();
       for (Student stu : list) {
            if (stuMap.containsKey(stu.getStudentID())) {
                stuMap.get(stu.getStudentID()).add(stu.getCourse());
                Collections.sort(stuMap.get(stu.getStudentID()));
            }
            else {
                ArrayList arrList = new ArrayList();
                arrList.add(stu.getCourse());
                stuMap.put(stu.getStudentID(), arrList);
            }
       }
       TreeMap<Integer, ArrayList<String>> stuMap2 = new TreeMap(stuMap);
       System.out.println(stuMap);
       System.out.println(stuMap2);
    }
}
