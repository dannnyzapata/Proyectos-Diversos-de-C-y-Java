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
public class Fabrica  {
    
    //Fabricador de Objeto
    public static Operaciones fabricarObjeto(int op){
        
        switch(op){
            case 0:
                return new Contacto();
            case 1:
                return new Producto();
            case 2:
                return new Mensaje();
            
                
            
        }
        return null;
    }
    
}
