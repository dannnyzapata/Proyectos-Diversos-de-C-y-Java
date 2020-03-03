/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proxy;

import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Daniel 2
 */
public class EnviaraBase implements InterfaceCuenta{
     

    @Override
    public Cuenta Depositar(Cuenta cuenta, int id, String usuario, double monto) {
        
        Conexion cn = new Conexion();
        Statement st; 
       
        cuenta.setUsuario(usuario);
        cuenta.setIdcuenta(id);
        cuenta.setSaldo(monto);
        String sql = "INSERT INTO cuenta2 (id, usuario, dinero) VALUES (?,?,?)";
        
        try {
            PreparedStatement sn = cn.con.prepareStatement(sql);
            //sn.setInt(1, cuenta.getIdcuenta());
           // sn.setString(2, cuenta.getUsuario());
            //sn.setDouble(3, cuenta.getSaldo());
            sn.setInt(1, 1);
           sn.setString(2, "aaaaah");
            sn.setDouble(3, 125.3);
        } catch (SQLException ex) {
            Logger.getLogger(EnviaraBase.class.getName()).log(Level.SEVERE, null, ex);
        }
       
        
        
        
        return cuenta;
        
        
    }


   
    
}
