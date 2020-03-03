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
public class Figuras {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      Figura[] f = new Figura[10];
      double total = 0;
      f[0]= new Circulo(2.3);
      f[1]= new Triangulo(2.3,10);
      f[2]= new Cuadro(23);
      f[3]= new Circulo(5);
      f[4]= new Circulo(7.6);
      f[5]= new Cuadro(10.5);
      f[6]= new Triangulo(6,2.3);
      f[7]= new Circulo(10.5);
      f[8]= new Triangulo(15,7.6);
      f[9]= new Cuadro(5.6);
      
      for (Figura fig: f){
          total+= fig.CalcularArea();
      }
      System.out.println("Area Total: " + total);
    }
   
}
