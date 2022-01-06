package Q1;

import java.util.Objects;

/**
 * @author Anthony Nadeau && Konstantinos Nikopoulos
 */
public class Key implements Comparable<Key>{
    // Instance Variables
    private String phoneNum;
    private String email;

    /**
     * Constructor with all instance variables
     * @param phoneNum client phone number
     * @param email client email
     */
    public Key(String phoneNum, String email) {
        this.phoneNum = phoneNum;
        this.email = email;
    }

    // GETTERS
    public String getPhoneNum() {
        return phoneNum;
    }

    public String getEmail() {
        return email;
    }
    
    /**
     * Overridden toString
     * @return this key as a string
     */
    @Override
    public String toString() {
        return String.format("Phone Number: %s\nEmail: %s\n", phoneNum, email);
    }
    
    /**
     * Overridden compareTo - to compare the phone numbers of 2 keys
     * @param key key being this is being compared to
     * @return an int based on the result of the String.compareTo() method
     */
    @Override
    public int compareTo(Key key) {
        return phoneNum.compareTo(key.phoneNum);
    }
}
