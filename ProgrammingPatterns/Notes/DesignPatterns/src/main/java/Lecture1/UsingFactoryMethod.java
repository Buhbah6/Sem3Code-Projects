 package Lecture1;

import java.util.Objects;

/**
 * @author Anthony
 */
 
class Student {
    private int id;
    private String name;
    protected int fees;

    public Student(int id, String name) {
        this.id = id;
        this.name = name;
        this.fees = 0;
    }

    @Override
    public String toString() {
        return "Student{" + "id=" + id + ", name=" + name + ", fees=" + fees + '}';
    }
}
 
class PartTime extends Student {

    public PartTime(int id, String name) {
        super(id, name);
        fees = 2000;
    } 
}

class FullTime extends Student {

    public FullTime(int id, String name) {
        super(id, name);
        fees = 5000;
    }
    
}
 
class FactoryStudents {
    public static Student createStudents(int choice, int id, String name) throws Exception {
        switch (choice) {
            case 1:
                return new PartTime(id, name);
            case 2:
                return new FullTime(id, name);
            default:
                throw new Exception("Unknown Student Type");
        }
    }
}
 
public class UsingFactoryMethod {
    public static void main(String[] args) throws Exception {
        Student st1 = FactoryStudents.createStudents(1, 150, "Anderson");
        Student st2 = FactoryStudents.createStudents(1, 260, "Nicholas");
        
        System.out.println("ST1: " + st1);
        System.out.println("ST2: " + st2);
    }
}
