package Lab1_2_1;

/**
 * @author Anthony Nadeau
 */
public class Horse implements Comparable<Horse>{
    private String name;
    private String color;
    private int birthYear;
    
    public Horse() {
        this.name = null;
        this.color = null;
        this.birthYear = 0;
    }
    
    public Horse(String n, String c, int by) {
        this.name = n;
        this.color = c;
        this.birthYear = by;
    }
    
    @Override
    public int compareTo(Horse h) {
        return this.birthYear - h.birthYear;
    }
    
    public void display() {
        String attributes = String.format("Name: %s\nColor: %s\nBirthYear: %d",
                name, color, birthYear);
        System.out.println(attributes);
    }
    
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public int getBirthYear() {
        return birthYear;
    }

    public void setBirthYear(int birthYear) {
        this.birthYear = birthYear;
    }  
}