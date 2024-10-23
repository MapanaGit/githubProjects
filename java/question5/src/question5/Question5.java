
package question5;

import java.util.*;
import java.util.Scanner;

public class Question5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String defaults="Hello";
        String name;
        Scanner input=new Scanner(System.in);
         
        
        System.out.println("Please enter your name");
       name=input.nextLine();
      
       System.out.println(defaults);
        System.out.println(name);
    }
    
}
