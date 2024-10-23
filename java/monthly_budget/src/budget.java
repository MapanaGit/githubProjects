import java.util.Scanner;
public class budget {
    public static void main(String[] args){
        //declare variables
        
        //monthly budget
        double fuel,rental,clothing,food,maintenance;
        
        //prompt the user to enter some data
        System.out.println("*************Monthly Budget***"
                + "***************");
        System.out.println();//return an empty string / line break
        //call the Scanner library
        Scanner input = new Scanner(System.in);
        System.out.println("Fuel cost");
        fuel=input.nextDouble();
        System.out.println("Rental Fee");
        rental=input.nextDouble();
        System.out.println("Clothing cost");
        clothing=input.nextDouble();
        System.out.println("Food allowance");
        food=input.nextDouble();
        System.out.println("Maintenance cost");
        maintenance=input.nextDouble();
        //calculte cost
        System.out.println("********Budget Cost********");
        System.out.println();
        System.out.println("Fuel cost: R" +fuel);
        System.out.println("Rental fee: R" +rental);
        System.out.println("Clothing cost: R" +clothing);
        System.out.println("Food allowance: R" +food);
        System.out.println("Maintenance cost: R-" +maintenance);
        System.out.println("********Done**********");
    }
}
