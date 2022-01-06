/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataStructure;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author Anthony
 */
public class MySetIT {
    
    public MySetIT() {
    }
    
    @BeforeAll
    public static void setUpClass() {
    }
    
    @AfterAll
    public static void tearDownClass() {
    }
    
    @BeforeEach
    public void setUp() {
    }
    
    @AfterEach
    public void tearDown() {
    }

    /**
     * Test of add method, of class MySet.
     */
    @Test
    public void testAdd_GenericType() {
        Object element = 1;
        MySet instance = new MySet();
        boolean expResult = true;
        boolean result = instance.add(element);
        assertEquals(expResult, result);
    }

    /**
     * Test of remove method, of class MySet.
     */
    @Test
    public void testRemoveElem_GenericType() {
        Object element = null;
        MySet instance = new MySet();
        boolean expResult = false;
        boolean result = instance.removeElem(element);
        assertEquals(expResult, result);
    }

    /**
     * Test of union method, of class MySet.
     */
    @Test
    public void testUnion() {
        Integer[] arr1 = {1, 2, 3, 4, 5};
        Integer[] arr2 = {1, 3, 5, 7, 9};
        MySet instance = new MySet(arr1);
        MySet otherSet = new MySet(arr2);
        Integer expResult = 9;
        MySet result = instance.union(otherSet);
        assertEquals(expResult, result.get(6));
    }

    /**
     * Test of intersection method, of class MySet.
     */
    @Test
    public void testIntersection() {
        Integer[] arr1 = {1, 2, 3};
        Integer[] arr2 = {2, 3, 4};
        MySet set1 = new MySet(arr1);
        MySet set2 = new MySet(arr2);
        Integer expResult = 3;
        MySet result = set1.intersection(set2);
        assertEquals(expResult, result.get(1));
    }

    /**
     * Test of difference method, of class MySet.
     */
    @Test
    public void testDifference() {
        Integer[] arr1 = {1, 2, 3};
        Integer[] arr2 = {2, 3, 4};
        MySet set1 = new MySet(arr1);
        MySet set2 = new MySet(arr2);
        Integer expResult = 1;
        MySet result = set1.difference(set2);
        assertEquals(expResult, result.get(0));
    }

    /**
     * Test of clear method, of class MySet.
     */
    @Test
    public void testClear() {
        MySet instance = new MySet();
        instance.clear();
        assertEquals(instance.size(), 0);
    }

    /**
     * Test of isEmpty method, of class MySet.
     */
    @Test
    public void testIsEmpty() {
        MySet instance = new MySet();
        boolean expResult = true;
        boolean result = instance.isEmpty();
        assertEquals(expResult, result);
    }

    /**
     * Test of contains method, of class MySet.
     */
    @Test
    public void testContains() {
        Object object = null;
        MySet instance = new MySet();
        boolean expResult = false;
        boolean result = instance.contains(object);
        assertEquals(expResult, result);
    }

    /**
     * Test of indexOf method, of class MySet.
     */
    @Test
    public void testIndexOf() {
        Object object = 1;
        MySet instance = new MySet();
        instance.add(1);
        int expResult = 0;
        int result = instance.indexOf(object);
        assertEquals(expResult, result);
    }

    /**
     * Test of get method, of class MySet.
     */
    @Test
    public void testGet() {
        int index = 0;
        MySet instance = new MySet();
        instance.add(326);
        Object expResult = 326;
        Object result = instance.get(index);
        assertEquals(expResult, result);
    }

    /**
     * Test of set method, of class MySet.
     */
    @Test
    public void testSet() {
        Object object = 3;
        int index = 0;
        MySet instance = new MySet();
        instance.add(1);
        instance.set(object, index);
        Integer expResult = 3;
        assertEquals(expResult, instance.get(0));
        
    }

    /**
     * Test of size method, of class MySet.
     */
    @Test
    public void testSize() {
        MySet instance = new MySet();
        int expResult = 0;
        int result = instance.size();
        assertEquals(expResult, result);
    }

    /**
     * Test of add method, of class MySet.
     */
    @Test
    public void testAdd_int_GenericType() {
        int index = 0;
        Object object = 1;
        MySet instance = new MySet();
        instance.add(index, object);
        Integer expResult = 1;
        assertEquals(expResult, instance.get(0));
    }

    /**
     * Test of remove method, of class MySet.
     */
    @Test
    public void testRemove_int() {
        int index = 0;
        MySet instance = new MySet();
        instance.add(10);
        Object expResult = 10;
        Object result = instance.remove(index);
        assertEquals(expResult, result);
    }
    
}
