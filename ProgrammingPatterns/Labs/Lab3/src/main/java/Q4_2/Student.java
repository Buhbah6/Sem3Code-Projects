package Q4_2;

/**
 * @author Anthony Nadeau
 */
public class Student {
    private final int studentID;
    private final String course;

    public Student(int studentID, String course) {
        this.studentID = studentID;
        this.course = course;  
    }

    public int getStudentID() {
        return studentID;
    }

    public String getCourse() {
        return course;
    }

    @Override
    public String toString() {
        return String.format("StudentID: %d\nCourse: %s", studentID, course);
    }  
}
