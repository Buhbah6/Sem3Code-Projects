/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Q3;

/**
 *
 * @author Anthony
 */
public class Class {
    
}

interface Bird 
{ 
    // birds implement Bird interface that allows 
    // them to fly and make sounds adaptee interface 
    public void fly(); 
    public void makeSound(); 
} 
  
class Sparrow implements Bird 
{ 
    // a concrete implementation of bird 
    public void fly() 
    { 
        System.out.println("Flying"); 
    } 
    public void makeSound() 
    { 
        System.out.println("Chirp Chirp"); 
    } 
} 
  
interface ToyDuck 
{ 
    // target interface 
    // toyducks dont fly they just make 
    // squeaking sound 
    public void squeak(); 
} 
  
class PlasticToyDuck implements ToyDuck 
{ 
    public void squeak() 
    { 
        System.out.println("Squeak"); 
    } 
}

class AdaptedBird implements ToyDuck {
    private Bird bd;
    
    public AdaptedBird(Bird bird) {
        bd = bird;
    }
    
    @Override
    public void squeak() 
    { 
        bd.makeSound(); 
    }
}


