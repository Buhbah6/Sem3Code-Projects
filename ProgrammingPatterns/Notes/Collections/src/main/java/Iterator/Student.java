package Iterator;

/**
 * @author Anthony Nadeau
 */
public class Student {
private String idNumber;
private String name;
private double gpa;

    public Student(String i, String n, double g) {
        idNumber=i;
        name=n;
        gpa=g;
    }
    public double getGpa() { 
        return gpa;
    }
}

