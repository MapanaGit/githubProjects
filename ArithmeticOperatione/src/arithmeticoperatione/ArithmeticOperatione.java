import java.util.Scanner;

public class ArithmeticOperatione {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Input first number
        System.out.print("Input first number: ");
        int num1 = scanner.nextInt();

        // Input second number
        System.out.print("Input second number: ");
        int num2 = scanner.nextInt();

        // Perform arithmetic operations
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        int division = num1 / num2;
        int remainder = num1 % num2;

        // Print the results
        System.out.println(num1 + " + " + num2 + " = " + sum);
        System.out.println(num1 + " - " + num2 + " = " + difference);
        System.out.println(num1 + " x " + num2 + " = " + product);
        System.out.println(num1 + " / " + num2 + " = " + division);
        System.out.println(num1 + " mod " + num2 + " = " + remainder);

        scanner.close();
    }
}

