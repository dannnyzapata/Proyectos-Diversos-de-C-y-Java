/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package genericos;

/**
 *
 * @author Mac18
 */
public class Genericos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        MoverCarro mc = new MoverCarro();
       mc.subir(new Vehiculo());
       
       MoverPersonaje mp = new MoverPersonaje();
       mp.izquierda(new Personaje(10, 2));
        
        
    }
    
}
