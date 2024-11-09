import java.sql.*;

public class Login {
    public static boolean validate(String name, String email, String password){
        boolean status=false;
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con=DriverManager.getConnection(
            "jdbc:mysql://localhost/employees","root","");
            
            PreparedStatement ps=con.prepareStatement(
            "select * from student where name=? and email=? and password=?");
            ps.setString(1, name);
            ps.setString(2, email);
            ps.setString(3, password);
            
            ResultSet rs=ps.executeQuery();
            status=rs.next();
            
        }
        catch(Exception e){
            System.out.println(e);
            return status;
        }
        return false;
    }
}
