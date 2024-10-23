/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication5;

import java.util.Scanner;

/**
 *
 * @author GNSE
 */
public class JavaApplication5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic 
         Scanner input = new Scanner(System.in);
    
    //declare varables
    String name, surname;
    int age;
    //begin the process
    System.out.println("**********JOB APPLICATION SYSTEM***********");
    System.out.println();
    System.out.println("Please enter your name");
    name=input.nextLine();
    System.out.println("Please enter your surname");
    surname=input.nextLine();
    System.out.println("Please enter your age");
    age=input.nextInt();
    System.out.println("Results:");
    System.out.println(name);
     System.out.println(surname);
      System.out.println(age);
      
      //arrays
      String[] cars={"VW","BMW","TOYOTA","NISSAN"};
      System.out.println("Array length:"+ cars.length);
   }
    
}
