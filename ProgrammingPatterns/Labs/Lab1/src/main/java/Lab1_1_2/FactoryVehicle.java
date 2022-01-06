/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lab1_1_2;

/**
 *
 * @author Anthony
 */
public class FactoryVehicle {
    
    public static Vehicle createVehicle(int choice, int mpg) throws Exception {
        switch (choice) {
            case 1:
                return new Car(mpg);
            case 2:
                return new Motorcycle(mpg);
            case 3:
                return TrackTrailer.getInstance(mpg);
            default:
                throw new Exception("Unknown Vehicle Type");
        }
    }
}
