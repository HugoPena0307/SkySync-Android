package com.example.prototipo.acessobd;

import android.content.Context;
import android.os.StrictMode;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Acessa {

    public ResultSet RS;
    public java.sql.Statement stmt;
    Connection con;
    static String emailAcesso;
    static String nomeAcesso;

    public Connection entBanco(Context ctx){

        try{
            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);
            Class.forName("net.sourceforge.jtds.jdbc.Driver").newInstance();
            Toast.makeText(ctx.getApplicationContext(), "Drive correto", Toast.LENGTH_SHORT).show();
        }
        catch(Exception ex){
            Toast.makeText(ctx.getApplicationContext(), "Drive não correto", Toast.LENGTH_SHORT).show();
        }

        try{
            String url = "jdbc:jtds:sqlserver://192.168.0.23:1433;databaseName=Skysync";
            con = DriverManager.getConnection(url, "sa", "etesp");
            stmt = con.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
            Toast.makeText(ctx.getApplicationContext(), "conectado ao Banco de Dados", Toast.LENGTH_SHORT).show();
        }
        catch(SQLException ex){
            Toast.makeText(ctx.getApplicationContext(), "Erro de conexão ao Banco de Dados", Toast.LENGTH_SHORT).show();
        }
        return con;
    }

    public String getEmailAcesso() {
        return emailAcesso;
    }

    public void setEmailAcesso(String email) {
        emailAcesso = email;
    }

    public String getnomeAcesso() {
        return nomeAcesso;
    }

    public void setnomeAcesso(String a) {
        nomeAcesso = a;
    }

    //Fim do método que vai conectar o banco

}
