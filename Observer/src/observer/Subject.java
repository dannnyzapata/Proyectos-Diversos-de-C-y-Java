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
public interface Subject {
    
    public void subscribeObserver(IObserver iObserver);
    public void unSubscribeObserver(IObserver iObserver);
    public void notifyObserver();
    public String subjectDetails();
    
    
}
