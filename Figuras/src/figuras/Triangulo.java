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
public class Triangulo implements Figura{
    
    public double base, altura;

    public Triangulo() {
    }

    public Triangulo(double base, double altura) {
        this.base = base;
        this.altura = altura;
    }
    

    @Override
    public double CalcularArea() {
        return (altura*base)/2;
    }
    
}
