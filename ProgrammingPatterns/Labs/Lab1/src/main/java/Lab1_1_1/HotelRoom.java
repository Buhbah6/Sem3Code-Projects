package Lab1_1_1;

/**
 * @author Anthony Nadeau
 */
public class HotelRoom {
    private int roomNum;
    protected double rentalRate;
    
    public HotelRoom(int roomNum) {
        this.roomNum = roomNum;
        this.rentalRate = 69.95;
        if (this.roomNum > 299) rentalRate = 89.95;
    }
    
    @Override
    public String toString() {
        return String.format("Room number = %d\nNightly Rental Rate = %.2f",
                roomNum, rentalRate);
    }
    
    public int getRoomNum() {
        return this.roomNum;
    }
    
    public double getRentalRate() {
        return this.rentalRate;
    }  
}