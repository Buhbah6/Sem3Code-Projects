package Lab1_2_1;

/**
 * @author Anthony Nadeau
 */
public class RaceHorse extends Horse {
    private int noOfRaces;
    
    public RaceHorse() {
        super();
        this.noOfRaces = 0;
    }
    
    public RaceHorse(String name, String color, int birthYear, int nor) {
        super(name, color, birthYear);
        this.noOfRaces = nor;
    }
    
    public void display() {
        String attributes = String.format("Name: %s\nColor: %s\nBirthYear: %d\n Races Won: %d",
                this.getName(), this.getColor(), this.getBirthYear(), this.getNoOfRaces());
        System.out.println(attributes);
    }

    public int getNoOfRaces() {
        return noOfRaces;
    }

    public void setNoOfRaces(int noOfRaces) {
        this.noOfRaces = noOfRaces;
    } 
}