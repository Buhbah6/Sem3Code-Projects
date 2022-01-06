package DataStructure;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class MySet<E> implements MyList<E> {
    
    // Instance Variables
    private Node<E> head;
    private Node<E> tail;
    private int size;
    
    // Constructor to make an empty set
    public MySet() {
        head = null;
        tail = null;
        size = 0;
    }
    
    // Constructor to make a set using an array
    public MySet(E[] arr) {
        for (E element : arr) 
            add(element);   
    }
    
    // Constructor to make a set using a list
    public MySet(List<E> list) {
        for (E element : list) 
            add(element); 
    }
    
    /**
     * Adds an element to the set as long as it isn't already in the set
     * @param element the element to be added
     * @return true or false; the element was added
     */
    public boolean add(E element) {       
        if (contains(element))
            return false;
        else {
            if (tail == null) {
                head = tail = new Node<>(element);
            }
            else {
                tail.next = new Node<>(element);
                tail = tail.next;
            }
            size++;
        }
        return true;
    }
    
    /**
     * Removes the given element from the set - renamed to clear confusion
     * @param element the element to be removed
     * @return true or false; the element was removed
     */
    public boolean removeElem(E element) {
        if (!contains(element))
            return false;
        else {
            remove(indexOf(element));
            return true;
        }
    }
    
    /**
     * Adds all distinct elements of otherSet and adds them to this set
     * @param otherSet the otherSet to pull distinct values from
     * @return this set containing the original + new elements
     */
    public MySet<E> union(MySet<E> otherSet) {
        for (int i = 0; i < otherSet.size(); i ++) {
            add(otherSet.get(i));
        }
        return this;
    }
    
    /**
     * Populates this set with all elements that are shared between
     * this set and the given set.
     * @param otherSet the otherSet to compare elements with
     * @return this set containing only elements contained in both sets
     */
    public MySet<E> intersection(MySet<E> otherSet) {
        MySet<E> newSet = new MySet();
        Node<E> current = otherSet.head;
        for (int i = 0; i < otherSet.size(); i++) {
            if (contains(current.element))
                newSet.add(current.element);
            current = current.next;
        }
        this.clear();
        for (int i = 0; i < newSet.size(); i++)
            this.add(newSet.get(i));
        return this;
    }
    
    /**
     * Populates this set with ONLY distinct elements from the otherSet
     * @param otherSet the set to pull distinct elements from
     * @return this set containing only the distinct elements from the otherSet
     */
    public MySet<E> difference(MySet<E> otherSet) {
        MySet<E> newSet = new MySet();
        Node<E> current = head;
        for (int i = 0; i < size(); i++) {
            if (!otherSet.contains(current.element))
                newSet.add(current.element);
            current = current.next;
        }
        this.clear();
        for (int i = 0; i < newSet.size(); i++)
            this.add(newSet.get(i));
        return this;
    }
    
    /**
     * Clears the set
     */
    @Override
    public void clear() {
        head = null;
        tail = null;
        size = 0;
    }
    
    /**
     * Checks if the set is empty
     * @return true or false; the set is empty
     */
    @Override
    public boolean isEmpty() {
        return size == 0;
    }
    
    @Override
    public boolean contains(E object) {
        return indexOf(object) != -1;
    }
    
    /**
     * retrieves the index of the given object
     * @param object the object to retrieve the index of
     * @return the index of the passed object or -1 if the object isn't in the set
     */
    @Override
    public int indexOf(E object) {
        Node<E> current = head;
        for (int i = 0; i < size; i++) {
            if (current.element.equals(object))
                    return i;
            else 
                current = current.next;     
        }
        return -1;
    }
    
    /**
     * Gets the element at the given index
     * @param index index of the element to be retrieved
     * @return the element at the given index
     */
    @Override
    public E get (int index) {
        if (!isEmpty() && (index < size) && (index >= 0)) {
            int idx=0;
            Node<E> current=head;   
            while(idx < index) { 
                current = current.next;
                idx++;
            }
            return current.element;
          }
        else throw new IndexOutOfBoundsException();
    }
    
    /**
     * Sets the element at the given index to the given element
     * @param object the element to replace the previous one with
     * @param index the index of the element to be replaced
     */
    @Override
    public void set (E object, int index) {
        if (!isEmpty() && (index < size) && (index >= 0 && (!contains(object)))) {
            int idx=0;
            Node<E> current=head;   
            while(idx < index) { 
                current = current.next;  
                idx++; 
            }
            current.element = object;
        }
        else throw new IndexOutOfBoundsException();
    } 
    
    /**
     * Gets the size of the set
     * @return the size of the set
     */
    @Override
    public int size() {
        return size;
    }
    
    /**
     * Adds the given object at the given index
     * @param index index to add the object at
     * @param object the object to be added
     */
    @Override
    public void add(int index, E object) {
        if (index < 0 || index > size)
            throw new IndexOutOfBoundsException();
        else if (isEmpty()){
            add(object);
        }
        else if (!contains(object)) {
            Node<E> current = head;
            for (int i = 0; i < index - 1; i++) 
                current = current.next;
            Node<E> temp = current.next;
            current.next = new Node<E>(object);
            (current.next).next = temp;
            size++;
        }
    }
    
    /**
     * Removes the object at the given index
     * @param index index of the object to be removed
     * @return the removed object
     */
    @Override
    public E remove(int index) {
        E element = head.element;
        Node<E> current = head;
        Node<E> temp = null;
        if (index < 0 || index >= size)
            throw new IndexOutOfBoundsException();
        else if (index == 0) {
            if (size >= 1) {
                head = head.next;
                size--;
                if (head == null) tail = null;
                return element;
            }
            else {
                throw new IndexOutOfBoundsException();
            }
        }
        else if (index == size - 1) {
            if (size >= 1) {
                for (int i = 0; i < size - 2; i++) {
                    current = current.next;
                }       
                temp = tail;
                tail = current;
                tail.next = null;
            }
            else {
                throw new IndexOutOfBoundsException();
            }
            size--;
            return temp.element;
        }
        for (int i = 0; i < index -1; i++) 
            current = current.next;
        temp = current.next;
        current.next = current.next.next;
        size--;
        return temp.element;
    }
}
