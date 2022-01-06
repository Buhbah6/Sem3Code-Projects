package UsingMaps_1;

import java.util.*;

/**
 * @author Anthony
 */
public class YouDoIt1 {
    
    public static void main(String[] args) {
        Map<Integer, Data> clientMap = new HashMap();
        Map<Integer, String> clientMap2 = new HashMap();
        
        // Client map 1
        Client c1 = new Client(1, new Data(new Name("Johnson", "Leonard"), "1914 rue Mandeville"));
        Client c2 = new Client(1, new Data(new Name("Perry", "James"), "11 yessir pow"));
        clientMap.put(c1.getIdNum(), c1.getData());
        clientMap.put(c2.getIdNum(), c2.getData());
        System.out.println(clientMap);
        
        // Client map 2
        OtherClient c3 = new OtherClient(10, "Johnson", "Leonard", "1914 rue Mandeville");
        OtherClient c4 = new OtherClient(20, "Perry", "James", "11 yessir pow");
        clientMap2.put(c3.getIdNum(), c3.getLastName() + c3.getFirstName() + c3.getAddress());
        clientMap2.put(c4.getIdNum(), c4.getLastName() + c4.getFirstName() + c4.getAddress());
    }
    
}

class Client {
    private int idNum;
    private Data data;

    public Client(int idNum, Data data) {
        this.idNum = idNum;
        this.data = data;
    }

    @Override
    public String toString() {
        return "Client{" + "idNum=" + idNum + ", data=" + data + '}';
    }

    public int getIdNum() {
        return idNum;
    }

    public Data getData() {
        return data;
    }
}

class Data {
    private Name name;
    private String address;
    
    public Data(Name name, String address) {
        this.name = name;
        this.address = address;
    }

    @Override
    public String toString() {
        return "Data{" + "name=" + name + ", address=" + address + '}';
    }
}

class Name {
    private String lastName;
    private String firstName;

    public Name(String lastName, String firstName) {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    @Override
    public String toString() {
        return "Name{" + "lastName=" + lastName + ", firstName=" + firstName + '}';
    }
}

class OtherClient {
    private int idNum;
    private String lastName;
    private String firstName;
    private String address;

    public OtherClient(int idNum, String lastName, String firstName, String address) {
        this.idNum = idNum;
        this.lastName = lastName;
        this.firstName = firstName;
        this.address = address;
    }

    @Override
    public String toString() {
        return "OtherClient{" + "idNum=" + idNum + ", lastName=" + lastName + ", firstName=" + firstName + ", address=" + address + '}';
    }

    public int getIdNum() {
        return idNum;
    }

    public String getLastName() {
        return lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getAddress() {
        return address;
    }
    
    
}