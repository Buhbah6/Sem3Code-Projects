package Q1;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class Client {
    // Instance Variables
    private Key key;
    private Data data;

    /**
     * Constructor with both instance variables
     * @param key key object (isolated key for HashMap)
     * @param data data object (data separated from key for HashMap)
     */
    public Client(Key key, Data data) {
        this.key = key;
        this.data = data;
    }

    // GETTERS
    public Key getKey() {
        return key;
    }

    public Data getData() {
        return data;
    }

    /**
     * Overridden toString 
     * @return this client as a string
     */
    @Override
    public String toString() {
        return "Client{" + "key=" + key + ", data=" + data + '}';
    }
}
