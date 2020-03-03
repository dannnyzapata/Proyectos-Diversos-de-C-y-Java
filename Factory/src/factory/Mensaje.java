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
public class Mensaje implements Operaciones{
    
    public double devolverPi(){
        return Math.PI;
    }
    
    @Override
    public String EnviarOperaciones(){
        
        return "Resultado enviado desde la clase Mensaje";
    }

    @Override
    public float calcular() {
        return (float)Math.PI;
    }
}
