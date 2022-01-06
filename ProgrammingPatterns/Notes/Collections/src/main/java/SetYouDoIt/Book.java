package SetYouDoIt;

import java.util.Objects;

/**
 * @author Anthony
 */
public class Book implements Comparable<Book> {
    private String title;
    private int noOfPages;
    private String authorName;
    
    public Book(String t, int n, String a) {
        title = t;
        noOfPages = n;
        authorName = a;
    }
    
    @Override
    public String toString() {
        return String.format("Title: %s\nNumber of Pages: %d\nAuthor: %s\n", title, noOfPages, authorName);
    }
    
    // HashCode and equals should filter the same variables as compareTo to avoid conflict
    // If compareTo is implemented, hashCode and equals become unnessesary
    
    @Override
    public int hashCode() {
        int hash = 7;
        hash = 73 * hash + Objects.hashCode(this.title);
        hash = 73 * hash + Objects.hashCode(this.authorName);
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
        final Book other = (Book) obj;
        if (!Objects.equals(this.title, other.title)) {
            return false;
        }
        if (!Objects.equals(this.authorName, other.authorName)) {
            return false;
        }
        return true;
    }
    
    @Override
    public int compareTo(Book b) {
        return this.noOfPages - b.noOfPages;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public int getNoOfPages() {
        return noOfPages;
    }

    public void setNoOfPages(int noOfPages) {
        this.noOfPages = noOfPages;
    }

    public String getAuthorName() {
        return authorName;
    }

    public void setAuthorName(String authorName) {
        this.authorName = authorName;
    }
    
    
}