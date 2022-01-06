package Lecture1;

import java.util.Objects;

/**
 * @author Anthony Nadeau
 */

class Login{
    private static Login  L;
    private Login (){}
    
    public static Login getInstance() { 
        if (L==null) 
            L=new Login();
        return L; 
    }                          
}

class Dean {
    private String name;
    private String address;
    private static Dean instance;

    private Dean(String name, String address) {
        this.name = name;
        this.address = address;
    }
    
    public static Dean getInstance(String name, String address) {
        if (instance==null) 
            instance=new Dean(name, address);
        return instance;
    }

    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    public static Dean getInstance() {
        return instance;
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 67 * hash + Objects.hashCode(this.name);
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Dean other = (Dean) obj;
        if (!Objects.equals(this.name, other.name)) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Dean{" + "name=" + name + ", address=" + address + '}';
    }
}


public class UsingDesignPatterns {
    
    public static void main(String[] args) {
//        Login obj1 = Login.getInstance();
//        Login obj2 = Login.getInstance();
//        
//        System.out.println("Object 1: " + obj1.hashCode());
//        System.out.println("Object 2: " + obj2.hashCode());

        Dean dean1 = Dean.getInstance("Andrew", "blablabla");
        Dean dean2 = Dean.getInstance("Andrew", "blablabla");
        
        System.out.println("Dean 1: " + dean1.hashCode());
        System.out.println("Dean 2: " + dean2.hashCode());
    }
}
