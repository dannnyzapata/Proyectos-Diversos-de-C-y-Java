/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package figuras;

/**
 *
 * @author Mac17
 */
public class Cuadro implements Figura{

    
   public double lado;

    public Cuadro() {
    }

    public Cuadro(double lado) {
        this.lado = lado;
    }
   
   
    @Override
    public double CalcularArea() {
        return lado*lado;
    }
    
    
}
