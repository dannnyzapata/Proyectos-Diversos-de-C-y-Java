/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proxy;

/**
 *
 * @author Daniel 2
 */
public class Cuenta {
    
    private int idcuenta;
    private String usuario;
    private double saldo;

    public Cuenta(int idcuenta, String usuario, double saldo) {
        this.idcuenta = idcuenta;
        this.usuario = usuario;
        this.saldo = saldo;
    }
    

    public int getIdcuenta() {
        return idcuenta;
    }

    public void setIdcuenta(int idcuenta) {
        this.idcuenta = idcuenta;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
    
    
    
}
