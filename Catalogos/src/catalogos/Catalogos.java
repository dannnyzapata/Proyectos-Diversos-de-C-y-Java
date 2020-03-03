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
public class Catalogos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Operaciones o = Fabrica.fabricarObjeto(1);
       o.insertar();
       o.actualizar();
       o.eliminar();
    }
    
}
