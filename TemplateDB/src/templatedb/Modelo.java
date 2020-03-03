/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatedb;

/**
 *
 * @author Daniel 2
 */
public class Modelo extends Template{
    private int numeroUno;
    private int numeroDos;
    private int Resultado;

    

    public int getNumeroUno() {
        return numeroUno;
    }

    public void setNumeroUno(int numeroUno) {
        this.numeroUno = numeroUno;
    }

    public int getNumeroDos() {
        return numeroDos;
    }

    public void setNumeroDos(int numeroDos) {
        this.numeroDos = numeroDos;
    }

    public int getResultado() {
        return Resultado;
    }

    public void setResultado(int Resultado) {
        this.Resultado = Resultado;
    }

     @Override
    protected int muliticars() {
  
         
        return getResu();
        
    }
   
        public int multiplicar(){
        setNumero1(this.numeroUno);
        setNumero2(this.numeroDos);
        Resultado = getNumero1()*getNumero2();
        
         return Resultado;
    }



    
}
