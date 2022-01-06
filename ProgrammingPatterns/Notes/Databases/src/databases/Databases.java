package databases;

import java.sql.*;

/**
 * @author Anthony
 */
public class Databases {
    
    public static void main(String[] args) {
       
        try {
            // Load Vendor
            Class.forName("org.sqlite.JDBC");
            
            // Establish Connection with Connection object
            Connection con = DriverManager.getConnection("jdbc:sqlite:C:\\SQLite\\databases\\example.db");
            
            // Create a Statement object to send SQL statements to the DB
            Statement stmt = con.createStatement();
            
            // Use Statement object to do SQL statements as Strings
            String createTable = "CREATE TABLE COMPANY" +
                    "(ID INT PRIMARY KEY NOT NULL, " +
                    "NAME TEXT NOT NULL, " +
                    "AGE INT NOT NULL, " +
                    "ADDRESS CHAR(50), " +
                    "SALARY REAL)";
            
            // Drop the table if it exists
            stmt.executeUpdate("DROP table if exists COMPANY");
            
            // Execute Statement
            stmt.executeUpdate(createTable);
            
            // Reset Statement object
            stmt = con.createStatement();
            
            // Insert data
            String insertInTable = "INSERT INTO COMPANY(ID,NAME,AGE,ADDRESS,SALARY) " +
               "VALUES (1, 'Djo', 32, 'California', 20000.00 );";   
            stmt.executeUpdate(insertInTable);
            
            stmt = con.createStatement();
            insertInTable = "INSERT INTO COMPANY(ID,NAME,AGE,ADDRESS,SALARY) " +
               "VALUES (2, 'Ben', 19, 'Quebec', 33330.00 );";   
            stmt.executeUpdate(insertInTable);
            
            
            // Retrieve data
            System.out.println("----Retrieving Company table data");
            
            String queryTable = "select * from COMPANY ";
            ResultSet rs = stmt.executeQuery(queryTable);
            while (rs.next()) {	
                System.out.println( "ID = " + rs.getInt("ID") );
                System.out.println( "NAME = " + rs.getString("NAME"));
                System.out.println( "AGE = " + rs.getInt("age"));
                System.out.println( "ADDRESS = " + rs.getString("address"));
                System.out.println( "SALARY = " + rs.getFloat("salary"));
                System.out.println();
            }
            stmt.close();
            con.close();


            
            // Handle all Exceptions
        } catch (Exception e) {
            System.err.println( e.getClass().getName() + ": " + e.getMessage() );
            System.exit(0);
        }
    }
    
}
