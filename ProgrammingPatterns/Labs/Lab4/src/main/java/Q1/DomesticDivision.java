package Q1;

/**
 * @author Anthony Nadeau
 */
public class DomesticDivision extends Division {
    private String state;

    public DomesticDivision(String name, int accNum, String state) {
        super(name, accNum);
        this.state = state;
    }
    
    @Override
    public void display() {
        System.out.println("Company Name: " + name);
        System.out.println("Account Number: " + accNum);
        System.out.println("State: " + state);
    }   
}
