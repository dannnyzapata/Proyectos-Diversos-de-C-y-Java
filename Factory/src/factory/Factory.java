/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factory;

/**
 *
 * @author Mac17
 */
public class Factory {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Polimorfismo
        //Operaciones o1 = new Contacto();
        //System.out.println(o1.EnviarOperaciones());
        //Operaciones o1 = Fabrica.fabricarObjeto(2);
        //System.out.println(o1.calcular());
        
        Operaciones[] arr = new Operaciones[3];
        arr[0]=Fabrica.fabricarObjeto(0);
        arr[1]=Fabrica.fabricarObjeto(1);
        arr[2]=Fabrica.fabricarObjeto(2);
        
        for (Operaciones output : arr){
            System.out.println(output.EnviarOperaciones());
        }
        
    }
    
}
