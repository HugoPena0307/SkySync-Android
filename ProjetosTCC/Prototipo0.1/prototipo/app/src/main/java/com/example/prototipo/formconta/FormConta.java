package com.example.prototipo.formconta;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;

import java.sql.SQLException;

public class FormConta extends AppCompatActivity {

    EditText nome, email, fone;
    TextView txtNumero;
    Acessa objA = new Acessa();
    String senhaAntiga, emailAntigo, foneAntigo, nomeAntigo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_conta);
        nome=findViewById(R.id.txtVnomeUsuario);
        email=findViewById(R.id.txtVemail);
        fone=findViewById(R.id.txtVtelefone);
        txtNumero = findViewById(R.id.textNumero);
        objA.entBanco(this);
        consultar();
        preencher();
    }
    public void consultar(){
        try {
            objA.RS = objA.stmt.executeQuery("Select * from Cliente");
            objA.RS.next();
        } catch (SQLException ex) {
            ex.getErrorCode();
        }
    }
    public void preencher(){
        try{
            objA.RS = objA.stmt.executeQuery("select Senha from Cliente where IdCli=" + getIdAcesso() + "");
            if (objA.RS.next()) {
                senhaAntiga = objA.RS.getString("Senha");
                nome.setText(senhaAntiga);
            }

            objA.RS = objA.stmt.executeQuery("select Email from Cliente where IdCli=" + getIdAcesso() + "");
            if (objA.RS.next()) {
                emailAntigo = objA.RS.getString("Email");
                email.setText(emailAntigo);
            }

            objA.RS = objA.stmt.executeQuery("select Fone from Cliente where IdCli=" + getIdAcesso() + "");
            if (objA.RS.next()) {
                foneAntigo = objA.RS.getString("Fone");
                fone.setText(foneAntigo);
            }

            objA.RS = objA.stmt.executeQuery("select Nome from Cliente where IdCli=" + getIdAcesso() + "");
            if (objA.RS.next()) {
                nomeAntigo = objA.RS.getString("Nome");
                txtNumero.setText(nomeAntigo);
            }
        }catch (SQLException ex){
            ex.getErrorCode();
        }

    }

    public int getIdAcesso() {
        int id = 0 ;
        String emailAnterior = objA.getEmailAcesso();
        try {
            objA.RS = objA.stmt.executeQuery("select IdCli from Cliente where Email='" +emailAnterior+ "'");
            if (objA.RS.next()){
                id = objA.RS.getInt("IdCli");
            }
        } catch(SQLException e) {

        }
        Toast.makeText(this, ""+id+"", Toast.LENGTH_SHORT).show();
        return id;
    }

    public void atualizar(View v){
        String idCli, nomeNovo, emailNovo, foneNovo;
        nomeNovo = nome.getText().toString();
        emailNovo = email.getText().toString();
        foneNovo = fone.getText().toString();
        int id = getIdAcesso();
        String emailAnterior = objA.getEmailAcesso();
        try{
            //idCli = objA.RS.getString("IdCli");
            int result = objA.stmt.executeUpdate("update Cliente set Nome='"+nomeNovo+"', Email='"+emailNovo+"', Fone='"+foneNovo+"' where IdCli=" + id + "");
            int result2 = objA.stmt.executeUpdate("update Id_LoginCliente set Email='"+ emailNovo+"' where Email='"+ emailAnterior+"'");
            if (result>0 && result2>0){
                Toast.makeText(getApplicationContext(),"Dados alterados com sucesso",Toast.LENGTH_SHORT).show();
                consultar();
            }else{

            }

        }catch (SQLException ex){

        }
    }

}