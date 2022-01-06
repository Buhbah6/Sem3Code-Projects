/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ImplementingLists;

/**
 *
 * @author Anthony
 */
public class ConstructedLinkedList {
    public static void main (String[] args) {
//        Node<String> head=null;
//        Node<String> tail=null;
//        head= new Node<>("Chicago");
//           tail=head;
//        tail.next=new Node<>("Denver");
//            tail=tail.next;
//        tail.next=new Node<>("Dallas");
//            tail=tail.next;
//
//        tail.next = head;
//        head = head.next;
//        tail = tail.next;
//        tail.next = null;
//
//
//        Node<String> current = head;
//        while (current != null) {
//            System.out.println(current.element);
//            current = current.next;   
//        }
        String[] str = {"Alex", "Eric", "Sofia", "Jack", "Lina", "Bob"};
        MyLinkedList testList = new MyLinkedList(str);
        testList.method1();
        display(testList);
        
        Integer[] ints = {1, 2, 4, 8, 10, 12};
        MyLinkedList testList2 = new MyLinkedList(ints);
        testList2.method2();
        display(testList2);
        
    }
    
    public static void display(MyLinkedList list) {
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i));
        }
    }
}

