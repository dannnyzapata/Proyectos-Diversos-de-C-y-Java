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
public interface Movimientos<T> {
    void subir (T o);
    void bajar (T o);
    void izquierda (T o);
    void derecha (T o);
}
