package Q1;

/**
 * @author Anthony Nadeau
 */
public class UseDivision {

    public static void main(String[] args) throws Exception {
        Division d1 = FactoryDivision.create(1, "Google", 1, "USA", 
                "English", "California");
        Division d2 = FactoryDivision.create(2, "Apple", 2, "Canada", 
                "English", "Quebec");
        
        d1.display();
        d2.display();
    }
}
