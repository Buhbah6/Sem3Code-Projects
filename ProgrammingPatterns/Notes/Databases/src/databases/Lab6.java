package databases;

import java.sql.*;
import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Lab6 {
    
    public static void main(String[] args) throws Exception {
        
        Class.forName("org.sqlite.JDBC");

        Connection con = DriverManager.getConnection("jdbc:sqlite:C:\\SQLite\\databases\\chinook.db");

        Statement st = con.createStatement();

        // Display Name and address of all employees

        String query = "select * from employees;";
        ResultSet rs = st.executeQuery(query);
        retrieveEmployees(rs);

        // Display Name of of all artists

        query = "select * from artists;";
        rs = st.executeQuery(query);
        retrieveArtists(rs);

        // Display all Customers living in New York

        query = "select * from customers where City = 'New York';";
        rs = st.executeQuery(query);
        retrieveCustomers(rs);
        
        // Close everything
        con.close();
        st.close();
            
    }
        
    public static void retrieveEmployees(ResultSet rs) throws Exception {
        System.out.println("---Display Name and address of all employees---");
            while (rs.next()) {
                System.out.println("Employee Name: " + rs.getString("FirstName") + rs.getString("LastName"));
                System.out.println("Employee address: " + rs.getString("Address"));
            }
    }
    
    public static void retrieveArtists(ResultSet rs) throws Exception {
        System.out.println("---Display Name of of all artists---");
        while (rs.next()) {
            System.out.println("Artist Name: " + rs.getString("Name"));
        }
    }
    
    public static void retrieveCustomers(ResultSet rs) throws Exception {
        System.out.println("---Display all Customers living in New York---");
        while (rs.next()) {
            System.out.println("Customer Name: " + rs.getString("FirstName") + rs.getString("LastName"));
        }
    }
}
