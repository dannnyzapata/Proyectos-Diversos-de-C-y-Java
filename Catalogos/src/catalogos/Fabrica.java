/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package catalogos;

/**
 *
 * @author Mac17
 */
public class Fabrica {
    public static Operaciones fabricarObjeto(int op){
        
        if (op ==0){
            return new Cliente();
            
        }else if(op==1){
            return new Probedor();
        }
        return null;
    }
    
}
