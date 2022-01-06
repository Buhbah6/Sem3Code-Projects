package Lab1_1_2;

/**
 * @author Anthony Nadeau
 */
public class TrackTrailer extends Vehicle {
     private static TrackTrailer t;
    
    private TrackTrailer(int mpg) {
        super(18, mpg);
    }
    public static TrackTrailer getInstance(int mpg) {
        if(t == null) 
            t = new TrackTrailer(mpg);
        return t;
    }
}
