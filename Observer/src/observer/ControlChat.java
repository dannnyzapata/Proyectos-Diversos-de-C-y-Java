/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 *
 * @author Mac18
 */
public class ControlChat implements ActionListener{
    private VistaChat vista;
    private ModeloChat modelo; 
    private VistaMensaje mess;

    public ControlChat(VistaChat vista, ModeloChat modelo, VistaMensaje mess) {
        this.vista = vista;
        this.modelo = modelo;
        this.mess = mess; 
        this.vista.getBtEnviar().addActionListener(this);
    }
    
    public void inciar(){
        vista.setTitle("Mensaje para Trabajadores");
        vista.setLocationRelativeTo(null);
    }
    
    
    @Override
    public void actionPerformed(ActionEvent ae) {
        modelo.setNombre(vista.txtNombre.getText());
        modelo.setMensaje(vista.rtMensaje.getText());
        modelo.EnviarMensaje();
        mess.setVisible(true);
        mess.setLocationRelativeTo(null);
        mess.txtNombreMost.setText(modelo.getNombre());
        mess.rtxMostrarMen.setText(modelo.getMensaje());
        
    }
    
    
}
