


package java.data.structures;

import java.util.*;
import java.util.Scanner;

public class arrayData {
    public static void main(String[] args){
    
    Scanner input = new Scanner(System.in);
    
    //declare varables
    String name, surname;
    int age;
    
    System.out.println("**********JOB APPLICATION SYSTEM***********");
    System.out.println();
    System.out.println("Please enter your name");
    name=input.nextLine();
    System.out.println("Please enter your surname");
    surname=input.nextLine();
    System.out.println("Please enter your age");
    age=input.nextInt();
    System.out.println(name+surname+age);
    }
    
}
