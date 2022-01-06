package Lecture1;

/**
 * @author Anthony 
 */
class Car{
    private int yearModel;
    private String make;
    private int speed;

    public Car(int model, String make) {
        this.yearModel = yearModel;
        this.make = make;
        this.speed = 0;
    }

    public int getYearModel() {
        return yearModel;
    }

    public String getMake() {
        return make;
    }

    public int getSpeed() {
        return speed;
    }    
    
    public void accelerate(){
        speed += 5;
    }
    
    public void brake(){
        if(speed >= 5)
        speed -= 5;
    }

    @Override
    public String toString() {
        return "Car{" + "model="+ make +" speed=" + speed + '}';
    }
}

class ViewCar{
    public void printCarInformation(Car c1){
         System.out.println(c1);
        }
}

class CarController{
    private Car model;
    private ViewCar view;

    public CarController(Car model, ViewCar view) {
        this.model = model;
        this.view = view;
    }
    
    public int getYearModel(){
        return model.getYearModel();
    }
    
     public String getMake() {
        return model.getMake();
    }

    public int getSpeed() {
        return model.getSpeed();
    }
    
    public void speedUp(){
        model.accelerate();
    }
    public void slowDown(){
        model.brake();
    }
    
    public void updateView(){
        view.printCarInformation(model);
    }
}

public class UsingCar {
    public static void main(String[] tt){
        
        Car car1 = new Car(2021, "Toyota");
        System.out.println(car1);
        
        car1.accelerate();
        for(int i=1;i<=5;i++){
            car1.accelerate();
            System.out.println(car1);
        }
        
        for(int i=1;i<=5;i++){
            car1.brake();
            System.out.println(car1);
        }
    }
}

class UsingCarMVC {
    
    public static void main(String[] tt){
        
        Car model = retrieveCar();
        ViewCar view = new ViewCar();
        CarController controller = new CarController(model, view);
        controller.updateView();
        
        for(int i=1;i<=5;i++){
            controller.speedUp();
            controller.updateView();
        }
        
        for(int i=1;i<=5;i++){
            controller.slowDown();
            controller.updateView();
        }
    }
    
    private static Car retrieveCar() {
        return new Car(2021, "Toyota Prius");
    }
    
    private static Car retrieveCar2() {
        return new Car(2019, "Honda Civic");
    }
}


