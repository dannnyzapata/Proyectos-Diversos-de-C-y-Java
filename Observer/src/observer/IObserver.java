/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

/**
 *
 * @author Mac18
 */
public interface IObserver {
    public void update (String desc);
    public void subscribe();
    public void unSubscribe();
    
}
