/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatedb;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;


/**
 *
 * @author Daniel 2
 */
public class Vista extends javax.swing.JFrame {
    public static final String URL = "jdbc:mysql://localhost:3306/resultadosdb?serverTimezone=UTC";
    public static final String USERNAME = "root";
    public static final String PASSWORD = "root";
    /**
     * Creates new form Vista
     */
    public Vista() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtNumero1 = new javax.swing.JTextField();
        txtResultado = new javax.swing.JTextField();
        btMulti = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        txtNumero2 = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        btMulti.setText("Multiplicar y Enviar");
        btMulti.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btMultiActionPerformed(evt);
            }
        });

        jLabel1.setText("x");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(36, 36, 36)
                        .addComponent(txtNumero2, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel1)
                        .addGap(12, 12, 12)
                        .addComponent(txtNumero1, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btMulti))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(68, 68, 68)
                        .addComponent(txtResultado, javax.swing.GroupLayout.PREFERRED_SIZE, 129, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(39, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(68, 68, 68)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtNumero1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btMulti)
                    .addComponent(jLabel1)
                    .addComponent(txtNumero2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(txtResultado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(171, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btMultiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btMultiActionPerformed
        txtNumero1.setText(null);
        txtNumero2.setText(null);
    }//GEN-LAST:event_btMultiActionPerformed


   public static Connection getConection(){
        Connection con = null;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = (Connection) DriverManager.getConnection(URL,USERNAME,PASSWORD);
            JOptionPane.showMessageDialog(null, "Conexion Exitosa");
            
        }catch(Exception e){
            System.out.println(e);
            
        }
     return con;
        
    }
    /**
     * @param args the command line arguments
     */

    public JButton getBtMulti() {
        return btMulti;
    }

    public void setBtMulti(JButton btMulti) {
        this.btMulti = btMulti;
    }

    public JLabel getjLabel1() {
        return jLabel1;
    }

    public void setjLabel1(JLabel jLabel1) {
        this.jLabel1 = jLabel1;
    }

    public JTextField getTxtNumero1() {
        return txtNumero1;
    }

    public void setTxtNumero1(JTextField txtNumero1) {
        this.txtNumero1 = txtNumero1;
    }

    public JTextField getTxtNumero2() {
        return txtNumero2;
    }

    public void setTxtNumero2(JTextField txtNumero2) {
        this.txtNumero2 = txtNumero2;
    }

    public JTextField getTxtResultado() {
        return txtResultado;
    }

    /**
     * @param args the command line arguments
     */
    public void setTxtResultado(JTextField txtResultado) {
        this.txtResultado = txtResultado;
    }


    // Variables declaration - do not modify//GEN-BEGIN:variables
    public javax.swing.JButton btMulti;
    private javax.swing.JLabel jLabel1;
    public javax.swing.JTextField txtNumero1;
    public javax.swing.JTextField txtNumero2;
    public javax.swing.JTextField txtResultado;
    // End of variables declaration//GEN-END:variables
}
