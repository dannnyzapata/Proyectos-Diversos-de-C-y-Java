/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.ArrayList;

/**
 *
 * @author Mac18
 */
public class ModeloChat {
    
    private String Nombre;
    private String Mensaje; 

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getMensaje() {
        return Mensaje;
    }

    public void setMensaje(String Mensaje) {
        this.Mensaje = Mensaje;
    }
    
    public void EnviarMensaje(){
        Subject subject = new CommentaryObject(new ArrayList<IObserver>(), "Grupo Trabajo");
        IObserver observer = new SMSUsers(subject, this.Nombre);
        Commentary comentario = ((Commentary)subject);
        comentario.setDesc(this.Mensaje);
        
    }
    
}
