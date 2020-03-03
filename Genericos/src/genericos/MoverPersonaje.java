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
public class MoverPersonaje implements Movimientos<Personaje>{

    @Override
    public void subir(Personaje o) {
        o.y+=1;
        System.out.println("Mono " + o.y);
    }

    @Override
    public void bajar(Personaje o) {
       o.y-=1;
        System.out.println("Mono " + o.y);
    }

    @Override
    public void izquierda(Personaje o) {
        o.x-=1;
        System.out.println("Mono " + o.x);
    }

    @Override
    public void derecha(Personaje o) {
        o.x+=1;
        System.out.println("Mono " + o.x);
    }
    
}
