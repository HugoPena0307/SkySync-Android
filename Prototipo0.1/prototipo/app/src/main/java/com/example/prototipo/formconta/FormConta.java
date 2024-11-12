package com.example.prototipo.formconta;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;

import java.sql.SQLException;

public class FormConta extends AppCompatActivity {

    EditText nome, email, fone;
    Acessa objA = new Acessa();
    String nomeAntigo, emailAntigo, foneAntigo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_conta);
        nome=findViewById(R.id.txtVnomeUsuario);
        email=findViewById(R.id.txtVemail);
        fone=findViewById(R.id.txtVtelefone);
        objA.entBanco(this);
        consultar();
    }
    public void consultar(){
        try {
            objA.RS = objA.stmt.executeQuery("Select * from CadCliente");
            objA.RS.next();
        } catch (SQLException ex) {
        }
    }
    public void preencher(){
        try{
            nome.setText(objA.RS.getString("NomeCli"));
            email.setText(objA.RS.getString("EmailCli"));
            fone.setText(objA.RS.getString("FoneCli"));
            nomeAntigo= objA.RS.getString("NomeCli");
            emailAntigo= objA.RS.getString("EmailCli");
            foneAntigo = objA.RS.getString("FoneCli");
        }catch (SQLException ex){

        }

    }

    public int getIdAcesso() {
        int id = 0 ;
        String emailAnterior = objA.getEmailAcesso();
        try {
            objA.RS = objA.stmt.executeQuery("select IdCli from CadCliente where EmailCli='" +emailAnterior+ "'");
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
            int result = objA.stmt.executeUpdate("update CadCliente set NomeCli='"+nomeNovo+"', EmailCli='"+emailNovo+"', FoneCli='"+foneNovo+"' where IdCli=" + id + "");
            int result2 = objA.stmt.executeUpdate("update Id_Login set Email='"+ emailNovo+"' where Email='"+ emailAnterior+"'");
            if (result>0 && result2>0){
                Toast.makeText(getApplicationContext(),"Dados alterados com sucesso",Toast.LENGTH_SHORT).show();
                consultar();
            }else{

            }

        }catch (SQLException ex){

        }
    }

}