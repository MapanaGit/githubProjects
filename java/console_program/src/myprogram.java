
import java.util.*;
import java.util.Scanner;

public class myprogram {
    //main method
    public static void main(String[] args){
        //variable declaration
        String name,surname;
        int age;
        double amount;
        
        //start the process
        System.out.println("********Check Account Balance*********");
        System.out.println();
        Scanner input = new Scanner(System.in);
        System.out.println("Enter your name");
        name=input.nextLine();
        System.out.println("Please enter your surname");
        surname=input.nextLine();
        System.out.println("Enter your age");
        age=input.nextInt();
        System.out.println("Enter account balance");
        amount=input.nextDouble();
        System.out.println("***********************************");
        System.out.println("Your name is: "+ name);
         System.out.println("Your surname is: "+ surname);
          System.out.println("Your age is: "+ age);
           System.out.println("Your account balance is: "+ amount);
        
    }
}
