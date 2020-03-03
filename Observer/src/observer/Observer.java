/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.ArrayList;

/**
 *
 * @author Mac18
 */
public class Observer {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Subject subject = new CommentaryObject(new ArrayList<IObserver>(), "Grupo Nice");
                
        IObserver observer = new SMSUsers(subject, "Gorgonio");
        observer.subscribe();
        System.out.println("");
        IObserver observer2 = new SMSUsers(subject, "Democrito");
        observer2.subscribe();
        
        Commentary comentario = ((Commentary)subject);
        comentario.setDesc("Bienvenido al Grupo Nice");
        observer2.unSubscribe();
    }
    
}
