package SetYouDoIt;

import java.util.*;

/**
 * @author Anthony
 */
public class Driver {
    
    public static void main(String[] args) {
        
        
        Book book1 = new Book("ProgPat", 10, "Djohara");
        Book book2 = new Book("PatProg", 10, "Djohara");
        Book book3 = new Book("AppDev", 44, "Syed");
        Book book4 = new Book("Unix", 111, "Tassia");
        Book book5 = new Book("IP", 50, "Hanif");
        
        Book[] bookArr = {book1, book2, book3, book4, book5};
        
        Set<Book> bookSet1 = new LinkedHashSet<>(Arrays.asList(bookArr));
        Set<Book> sortedSet = new TreeSet<>(bookSet1);
        Set<Book> sortedSet2 = new TreeSet<>((b1, b2) -> b1.getTitle().compareTo(b2.getTitle()));
        Set<Book> sortedSet3 = new TreeSet<>((b1, b2) -> b1.getNoOfPages() - b2.getNoOfPages());
        
        sortedSet2.add(book1);
        sortedSet2.add(book2);
        sortedSet2.add(book3);
        sortedSet2.add(book4);
        sortedSet2.add(book5);
        
        sortedSet3.add(book1);
        sortedSet3.add(book2);
        sortedSet3.add(book3);
        sortedSet3.add(book4);
        sortedSet3.add(book5);
        
        for (Book book : sortedSet) {
            System.out.println(book);
        }
        
        for (Book book : sortedSet2) {
            System.out.println(book);
        }
        
        for (Book book : sortedSet3) {
            System.out.println(book);
        }
        
        // TreeSet can take a comparator (or lambda exp) as a parameter.
    }
}
