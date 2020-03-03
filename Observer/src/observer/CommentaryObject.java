/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.List;

/**
 *
 * @author Mac18
 */
public class CommentaryObject implements Subject, Commentary{
    
    private final List<IObserver> Observers;
    private String desc;
    private final String subjectDetails;

    public CommentaryObject(List<IObserver> Observer, String subjectDetails) {
        this.Observers = Observer;
        this.subjectDetails = subjectDetails;
    }
    
    

    @Override
    public void subscribeObserver(IObserver iObserver) {
       Observers.add(iObserver);
    }

    @Override
    public void unSubscribeObserver(IObserver iObserver) {
        int indx = Observers.indexOf(iObserver);
        Observers.remove(indx);
    }

    @Override
    public void notifyObserver() {
         System.out.println("");
         for(IObserver observer: Observers){
             observer.update(desc);
         }
    }

    @Override
    public String subjectDetails() {
        return subjectDetails;
    }

    @Override
    public void setDesc(String desc) {
        
        this.desc = desc;
        notifyObserver();
        
    }
    
    
    
}
