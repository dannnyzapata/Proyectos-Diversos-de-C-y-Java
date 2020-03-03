package proxy;

import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;


public class Conexion {
    Connection con;
    public Conexion(){
        
        try {
            Class.forName("com.mysql.jdbc.Driver");
            con = (Connection) DriverManager.getConnection("jdbc:mysql:\\localhost:3306/proxydb","root","root");
        } catch (Exception e) {
            System.out.print(e);
        }
    }
    public static void conectar(){
        Conexion cn = new Conexion();
        
        
    }
    public static void desconectar(){
        Conexion cn = new Conexion();
        try {
            cn.con.close();
        } catch (SQLException ex) {
            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
