package Q1;

/**
 * @author Anthony Nadeau
 */
public class FactoryDivision {
    
    public static Division create(int choice, String name, int accnum, 
            String country, String language, String state) throws Exception {
        switch (choice) {
            case 1:
                return new InternationalDivision(name, accnum, country, language);
            case 2:
                return new DomesticDivision(name, accnum, state);
            default:
                throw new Exception("Unknown Division Type");
        }
    }
}
