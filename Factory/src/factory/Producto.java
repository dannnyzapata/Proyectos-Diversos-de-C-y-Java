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
public class Producto implements Operaciones{
    
    @Override
    public String EnviarOperaciones(){
        
        return "Codigo de Producto: 123564897-msafds";
    }

    @Override
    public float calcular() {
        return 152.36f;
    }
}
