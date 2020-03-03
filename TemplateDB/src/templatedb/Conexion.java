/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatedb;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

/**
 *
 * @author Daniel 2
 */
public class Conexion {
    public static Connection conn;
    public static final String URL = "jdbc:mysql://localhost:3306/resultadosdb?serverTimezone=UTC";
    public static final String USERNAME = "root";
    public static final String PASSWORD = "root";
     public static final String DRIVER = "com.mysql.cj.jdbc.Driver";
    
   public Conexion(){
        conn = null;
        try{
            Class.forName(DRIVER);
            conn = (Connection) DriverManager.getConnection(URL,USERNAME,PASSWORD);
            JOptionPane.showMessageDialog(null, "Conexion Exitosa");
            
        }catch(Exception e){
            System.out.println(e);
            
        }
     
        
    }
   public Connection Conectar(){
       return conn;
   }
   public void desconectar(){
       conn = null;
       
   }
 
}
