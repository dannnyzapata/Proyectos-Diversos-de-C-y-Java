/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factory;

/**
 *
 * @author Mac17
 */
public class Contacto implements Operaciones {
    
    public String Saludar(){
        return "Hola Mundo";
    }
    
    
    @Override
    public String EnviarOperaciones(){
        
        return "Resultado enviado desde la clase Contacto";
    }

    @Override
    public float calcular() {
        return 5.8f;
    }
    
}
