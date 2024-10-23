/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oracle_practice;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Dev
 */
public class Oracle_practice {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Oracle DB connection details
        String url = "jdbc:oracle:thin:@127.0.0.1:1521:xe"; // Format: jdbc:oracle:thin:@<host>:<port>:<SID>
        String username = "SYSTEM";  // Replace with your username
        String password = "12345"; // Replace with your password

        Connection connection = null;

        try {
            // Load the Oracle JDBC driver
            Class.forName("oracle.jdbc.driver.OracleDriver");
            
            // Establish the connection
            connection = DriverManager.getConnection(url, username, password);
            System.out.println("Connected to Oracle Database!");

        } catch (ClassNotFoundException e) {
            System.out.println("Oracle JDBC Driver not found.");
            e.printStackTrace();
        } catch (SQLException e) {
            System.out.println("Connection failed!");
            e.printStackTrace();
        } finally {
            // Close the connection
            if (connection != null) {
                try {
                    connection.close();
                    System.out.println("Connection closed.");
                } catch (SQLException e) {
                    e.printStackTrace();
                }
            }
        }
    
}
    
}
