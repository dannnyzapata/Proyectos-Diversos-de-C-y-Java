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
public abstract class Template {
    
    private int numero1;
    private int numero2;
    private int resu;

    public int getResu() {
        return resu;
    }

    public void setResu(int resu) {
        this.resu = resu;
    }
    
    protected abstract int muliticars();

    public int getNumero1() {
        return numero1;
    }

    public void setNumero1(int numero1) {
        this.numero1 = numero1;
    }

    public int getNumero2() {
        return numero2;
    }

    public void setNumero2(int numero2) {
        this.numero2 = numero2;
    }
}
