package Lab1_1_2;

/**
 * @author Anthony Nadeau
 */
public class UseVehicle {
    
    public static void main(String[] args) throws Exception {
        Car car = new Car(30);
        Motorcycle moto = new Motorcycle(70);
        
        System.out.println(car);
        System.out.println(moto);
        
        TrackTrailer t1 = TrackTrailer.getInstance(3000);
        TrackTrailer t2 = TrackTrailer.getInstance(3000);
        System.out.println(t1.hashCode());
        System.out.println(t2.hashCode());
        
        Vehicle v1 = FactoryVehicle.createVehicle(1, 30);
        Vehicle v2 = FactoryVehicle.createVehicle(2, 7000);
        Vehicle v3 = FactoryVehicle.createVehicle(3, 100000000);
        Vehicle v4 = FactoryVehicle.createVehicle(3, 100);
        
        System.out.println(v1);
        System.out.println(v2);
        System.out.println(v3);
        System.out.println(v4);
        
    }
}
