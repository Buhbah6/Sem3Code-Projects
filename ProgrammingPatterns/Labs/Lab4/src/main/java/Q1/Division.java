package Q1;

/**
 * @author Anthony Nadeau
 */
public class Division {
    protected String name;
    protected int accNum;

    public Division(String name, int accNum) {
        this.name = name;
        this.accNum = accNum;
    }
    
    public void display() {
        System.out.println("Company Name: " + name);
        System.out.println("Account Number: " + accNum);
        System.out.println();
    }
}
