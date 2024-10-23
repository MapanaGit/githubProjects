import java.util.*;
import java.util.Scanner;
package recruitment_system;

/**
 *
 * @author GNSE
 */
public class Recruitment_system {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner input = new Scanner(System.in);
       String id,name,surname,dob,gender,address,email_address,phone,age,occupation_group,marital_status,job_applying_for,
               previous_job,qualification,experience,expected_salary,notice_period;
       String qualification1;
       String qualification2;
       String qualification3;
       
       qualification1="matric";
       qualification2="diploma";
       qualification3="degree";
       
       System.out.println("*****************Recruitment System****************");
       System.out.println("Please enter your SA ID / Passport");
       id=input.nextLine();
       System.out.println("Please enter your name");
       name=input.nextLine();
       System.out.println("Please enter your surname");
       surname=input.nextLine();
       System.out.println("Please enter your date of birth");
       dob=input.nextLine();
       System.out.println("Please enter your gender");
       gender=input.nextLine();
        System.out.println("Please enter your qualification");
       
      if(qualification1=="matric"){
      System.out.println("Sorry you don't qualify.");
      }else if(qualification2=="diploma"){
      System.out.println("Your stipened will be R5500.00");
      }else if(qualification3=="degree"){
      System.out.println("Your stipened is R6000. Come on Monday the 11th of September to sign a contract");
      }
       
       
       System.out.println("********************************************");
       System.out.println("Id" + id);
       System.out.println("Name" + name
       );
       System.out.println("Surname" + surname);
       System.out.println("date of birth" + dob);
       System.out.println("gender" + gender);
       
       System.out.println("***************Thank you for your job application**************");
      
    }
    
}
