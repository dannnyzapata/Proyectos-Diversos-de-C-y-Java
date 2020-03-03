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
public class Circulo  implements Figura{
    private double radio;
    public Circulo(){

    }

    public Circulo(double radio) {
        this.radio = radio;
    }

    @Override
    public double CalcularArea() {
       return Math.PI*Math.pow(radio, 2);
    }
    

}
