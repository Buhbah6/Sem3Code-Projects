package Q1;

/**
 * @author Anthony Nadeau
 */
public class InternationalDivision extends Division {
    private String country;
    private String language;
    
    public InternationalDivision(String name, int accNum, String country, String language) {
        super(name, accNum);
        this.country = country;
        this.language = language;
    }
    
    @Override
    public void display() {
        System.out.println("Company Name: " + name);
        System.out.println("Account Number: " + accNum);
        System.out.println("Country: " + country);
        System.out.println("Language: " + language);
    } 
}
