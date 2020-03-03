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
public class SMSUsers implements IObserver{

    //Atributos
    private final Subject subject;
    private String desc;
    private String userInfo;
    //Constructor

    public SMSUsers(Subject subject, String userInfo) {
        
        if(subject==null){
            throw new IllegalArgumentException("Falta un argumento");
        }
        this.subject = subject;
        this.userInfo = userInfo;
    }
    
    
    
    @Override
    public void update(String desc) {
        this.desc = desc;
        display();
    }

    private void display(){
        System.out.println("["+userInfo+"]: "+desc);
    }
    @Override
    public void subscribe() {
        System.out.println("Suscribiendo "
                +userInfo
                +" a "
                +subject.subjectDetails()
        );
        this.subject.subscribeObserver(this);
        System.out.println("Suscripcion exitosa...");
    }

    @Override
    public void unSubscribe() {
        System.out.println(userInfo
                +" Salio del grupo: "
                
        );
        this.subject.unSubscribeObserver(this);
        System.out.println("Saliendo del grupo...");
        
        
        
    }
    
    
}
