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
public class MoverCarro implements Movimientos<Vehiculo>{

    @Override
    public void subir(Vehiculo o) {
        o.y=+10;
        System.out.println("Vocho " + o.y);
    }

    @Override
    public void bajar(Vehiculo o) {
        o.y=-10;
        System.out.println("Vocho " + o.y);
    }

    @Override
    public void izquierda(Vehiculo o) {
        o.x=-10;
        System.out.println("Vocho " + o.x);
    }

    @Override
    public void derecha(Vehiculo o) {
        o.x=+10;
        System.out.println("Vocho " + o.x);
    }
    
}
