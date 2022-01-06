package lab7;

import java.sql.*;
import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Lab7 {

    public static void main(String[] args) throws Exception {
        
        ArrayList<Student> model = retrieveData();
        TableController tc = new TableController(model, new ViewTable());
        
        tc.createStudentsTable();
        tc.addAllStudents(model);
        
        System.out.println("----First View----");
        tc.updateView();
        System.out.println();
        
        System.out.println("----View After Adding Student----");
        tc.addStudent(new Student(37, "Djohara", "Vanier College"));
        tc.updateView();
        System.out.println();
        
        System.out.println("----View After Deleting Student----");
        tc.deleteStudent(3);
        tc.updateView();
        System.out.println();
        
        System.out.println("----Result of getStudent method----");
        System.out.println(tc.getStudent(1));
        System.out.println();
    }

    private static ArrayList<Student> retrieveData() {
        Student[] stuArr = {new Student(1, "Anthony", "123 prog st"), new Student(3, "Kosta", "321 appdev st"), 
            new Student(4, "Leonard", "9 fuckIfIKnow st"), new Student(2, "Yeet", "17 bonk ave"),
            new Student(7, "Michael", "OfflineTV house"), new Student(6, "objects", "345 toooo many objects st"), 
            new Student(5, "Test", "test blvd"), new Student(8, "Model", "View Controller"), new Student(9, "Jade", "Ontario")};
        return new ArrayList(Arrays.asList(stuArr));
    }
}

class Student {
    private int studentId;
    private String name;
    private String address;

    public Student(int studentId, String name, String address) {
        this.studentId = studentId;
        this.name = name;
        this.address = address;
    }

    @Override
    public String toString() {
        return String.format("StudentID: %d\nName: %s\nAddress: %s", studentId, 
                name, address);
    }

    public int getStudentId() {
        return studentId;
    }

    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }
}

class ViewTable {

    public void displayData(Map map) {
        System.out.println(map);
    }
    
}

class TableController {
    private ArrayList<Student> model;
    private ViewTable view;
    private final Connection con;

    public TableController(ArrayList model, ViewTable view) throws Exception {
        this.model = model;
        this.view = view;
        con = ConnectDB.getSingleConnection();
    }
    
    public Student getStudent(int id) throws Exception {
        Statement stmt = con.createStatement();
        String retrieveStudent = "select * from Students where STUDENTID = " + id + ";";
        ResultSet rs = stmt.executeQuery(retrieveStudent);
        return new Student(rs.getInt("STUDENTID"), rs.getString("NAME"), rs.getString("ADDRESS"));
    }
    
    public Map dbToMap() throws Exception {
        Map<Integer, String> map = new TreeMap();
        Statement stmt = con.createStatement();
        String retrieveStudent = "select * from Students";
        ResultSet rs = stmt.executeQuery(retrieveStudent);
        while (rs.next()) {
            map.put(rs.getInt("STUDENTID"), " Name: " + rs.getString("NAME") + 
                    " Address: " + rs.getString("ADDRESS") + "\n");
        }
        return map;
    }
    
    public void createStudentsTable() throws Exception {
        Statement stmt = con.createStatement();
        String tableCreation = "CREATE TABLE Students" +
                    "(STUDENTID INT PRIMARY KEY NOT NULL, " +
                    "NAME TEXT NOT NULL, " +
                    "ADDRESS CHAR(50))";
        stmt.executeUpdate("DROP table if exists Students;");
        stmt.executeUpdate(tableCreation);
    }
    
    public void addStudent(Student stu) throws Exception {
        String insertInTable = "INSERT INTO Students(STUDENTID,NAME,ADDRESS) " +
               String.format("VALUES (%d, '%s', '%s');", stu.getStudentId(), stu.getName(), stu.getAddress());
        Statement stmt = con.createStatement();
        stmt.executeUpdate(insertInTable);
    }
    
    public void addAllStudents(List<Student> list) throws Exception {
        for (Student stu : list) {
            addStudent(stu);
        }
    }
    
    public void deleteStudent(int id) throws Exception {
        String removeFromTable = "DELETE FROM Students WHERE STUDENTID = " + id + ";";
        Statement stmt = con.createStatement();
        stmt.executeUpdate(removeFromTable);
    }
    
    public void updateView() throws Exception {
        view.displayData(dbToMap());
    }
    
}

class ConnectDB {
    private static Connection con;
    
    public static Connection getSingleConnection() throws Exception {
        Class.forName("org.sqlite.JDBC");
        if (con == null) 
           con = DriverManager.getConnection("jdbc:sqlite:C:\\SQLite\\databases\\college.db");
        return con;
    }
}