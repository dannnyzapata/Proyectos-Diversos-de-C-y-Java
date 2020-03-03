/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatedb;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Daniel 2
 */
public class Controlador implements ActionListener{
    
    private Vista view;
    private Modelo model;

    public Controlador(Vista view, Modelo model) {
        this.view = view;
        this.model = model;
        this.view.getBtMulti().addActionListener(this);
    }
    
    public void inciar(){
        view.setTitle("Multiplicar Template");
        view.setLocationRelativeTo(null);
    }
    

    @Override
    public void actionPerformed(ActionEvent ae) {
        
        model.setNumeroUno(Integer.parseInt(view.txtNumero1.getText()));
        model.setNumeroDos(Integer.parseInt(view.txtNumero2.getText()));
        model.multiplicar();
        view.txtResultado.setText(String.valueOf(model.getResultado()));
        
        Conexion conn = new Conexion();
        Connection cn =  conn.Conectar();
       
        try {
            PreparedStatement pps = cn.prepareStatement("INSERT INTO multiplicar(resu) VALUES (?)");
            pps.setInt(1, model.getResultado());
            pps.executeUpdate();
        } catch (SQLException ex) {
            Logger.getLogger(Controlador.class.getName()).log(Level.SEVERE, null, ex);
        }
        conn.desconectar();
        
        
        
        
    }


    
}
