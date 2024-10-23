import java.util.Scanner;

public class Distance{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Input distance in meters
        System.out.print("Input distance in meters: ");
        double distanceMeters = scanner.nextDouble();

        // Input time taken
        System.out.print("Input hour: ");
        int hours = scanner.nextInt();
        System.out.print("Input minutes: ");
        int minutes = scanner.nextInt();
        System.out.print("Input seconds: ");
        int seconds = scanner.nextInt();

        // Calculate total time in seconds
        int totalTimeSeconds = (hours * 3600) + (minutes * 60) + seconds;

        // Calculate speed in meters per second
        double speedMetersPerSecond = distanceMeters / totalTimeSeconds;

        // Convert meters per second to kilometers per hour
        double speedKilometersPerHour = (distanceMeters / 1000) / (totalTimeSeconds / 3600.0);

        // Convert meters per second to miles per hour
        double speedMilesPerHour = (distanceMeters / 1609.0) / (totalTimeSeconds / 3600.0);

        // Display the results
        System.out.println("Your speed in meters/second is " + speedMetersPerSecond);
        System.out.println("Your speed in km/h is " + speedKilometersPerHour);
        System.out.println("Your speed in miles/h is " + speedMilesPerHour);

        scanner.close();
    }
}
