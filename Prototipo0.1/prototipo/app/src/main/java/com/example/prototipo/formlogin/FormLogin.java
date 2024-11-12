package com.example.prototipo.formlogin;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;
import com.example.prototipo.formmenu.FormMenu;

import java.sql.SQLException;

public class FormLogin extends AppCompatActivity {

    Button btnLogin;
    EditText txtUsuario, txtSenha;
    Acessa objA = new Acessa();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_login);

        btnLogin = findViewById(R.id.btnLogin);
        txtUsuario = findViewById(R.id.txtUsuario);
        txtSenha = findViewById(R.id.txtSenha);

    }

    public void entrar(View v){
        objA.entBanco(this);
        String email = txtUsuario.getText().toString();
        String senha = txtSenha.getText().toString();
        try{
            objA.RS=objA.stmt.executeQuery("select*from Id_Login where Email='"+email+"' and Senha='"+senha+"'");
            if(objA.RS.next()){
                objA.setEmailAcesso(email);
                //Toast.makeText(getApplicationContext(),"Abram alas", 2).show();
                Intent intent= new Intent(FormLogin.this, FormMenu.class);
                intent.putExtra("Email", email);
                startActivity(intent);
                finish();
            }else{
                Toast.makeText(getApplicationContext(), "Entrada recusada", 2).show();

            }

        }catch (SQLException ex){
            Toast.makeText(getApplicationContext(), "Verifique se os dados estão corretos", 2).show();

        }
    }
}