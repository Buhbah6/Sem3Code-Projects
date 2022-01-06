package Part2;

/**
 * @author Anthony Nadeau
 */
public class Student {
    private String name;
    private int score;
    
    /**
     * Constructor with both instance variables
     * @param name name of the student
     * @param score student's score
     */
    public Student(String name, int score) {
        this.name = name;
        this.score = score;
    }
    
    //GETTERS
    
    public String getName() {
        return name;
    }

    public int getScore() {
        return score;
    }
    
    /**
     * Overridden toString
     * @return the Student as a string
     */
    @Override
    public String toString() {
        return String.format("Student name: %s\nStudent score: %s\n\n");
    }
}
