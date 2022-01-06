package Lab1_1_1;

/**
 * @author Anthony Nadeau
 */
public class Suite extends HotelRoom {
    
    public Suite(int roomNum) {
        super(roomNum);
        this.rentalRate += 40;
    }
  
}

class SuiteSingle extends HotelRoom {
    private static SuiteSingle s;
    
    private SuiteSingle(int room) {
        super(room);
        rentalRate += 40;
    }
    public static SuiteSingle getInstance(int room) {
        if(s == null) 
            s = new SuiteSingle(room);
        return s;
    }
}
