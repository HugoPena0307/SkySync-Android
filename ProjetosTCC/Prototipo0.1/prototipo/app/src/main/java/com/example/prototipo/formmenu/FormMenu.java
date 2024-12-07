package com.example.prototipo.formmenu;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;
import com.example.prototipo.formagendar.FormAgendar;
import com.example.prototipo.formconsultar.FormConsultar;
import com.example.prototipo.formconta.FormConta;
import com.example.prototipo.formlogin.FormLogin;
import com.example.prototipo.formorcamentos.FormOrcamentos;
import com.example.prototipo.formservicos.FormServicos;
import com.example.prototipo.formveiculos.FormVeiculos;

import java.sql.SQLException;

public class FormMenu extends AppCompatActivity {

    private ImageButton btnAgendar, btnVeiculos, btnOrcamentos, btnConsultar, btnConta, btnServicos, btnLogout;
    private TextView txtViewNomeUsuario;
    Acessa objA = new Acessa();

    //Toda a confiiguração dos BOTÕES do MENU estão aqui
    //Verificar o botão de Sair, ele deve deslogar e voltar para a tela de login

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_menu);
        btnAgendar=findViewById(R.id.btnAgendar);
        btnVeiculos=findViewById(R.id.btnVeiculos);
        btnOrcamentos=findViewById(R.id.btnOrcamentos);
        btnConsultar=findViewById(R.id.btnConsultar);
        btnConta=findViewById(R.id.btnConta);
        btnServicos=findViewById(R.id.btnServicos);
        btnLogout=findViewById(R.id.btnLogout);
        txtViewNomeUsuario = findViewById(R.id.txtVNomeUsuario);

        txtViewNomeUsuario.setText(objA.getnomeAcesso());


        btnAgendar.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent agendar = new Intent(FormMenu.this, FormAgendar.class);
                startActivity(agendar);
            }

            public void FormAgendar(View view){
                Intent agendar = new Intent(FormMenu.this, FormAgendar.class);
                startActivity(agendar);
            }
        });
        btnVeiculos.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent veiculos = new Intent(FormMenu.this, FormVeiculos.class);
                startActivity(veiculos);
            }

            public void FormVeiculos(View view){
                Intent veiculos = new Intent(FormMenu.this, FormVeiculos.class);
                startActivity(veiculos);
            }
        });
        btnOrcamentos.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent orcamentos = new Intent(FormMenu.this, FormOrcamentos.class);
                startActivity(orcamentos);
            }

            public void FormOrcamentos(View view){
                Intent orcamentos = new Intent(FormMenu.this, FormOrcamentos.class);
                startActivity(orcamentos);
            }
        });
        btnConsultar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent consultar = new Intent(FormMenu.this, FormConsultar.class);
                startActivity(consultar);
            }

            public void FormConsultar(View view){
                Intent consultar = new Intent(FormMenu.this, FormConsultar.class);
                startActivity(consultar);
            }
        });
        btnConta.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent conta = new Intent(FormMenu.this, FormConta.class);
                startActivity(conta);
            }

            public void FormConta(View view){
                Intent conta = new Intent(FormMenu.this, FormConta.class);
                startActivity(conta);
            }
        });
        btnServicos.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent servicos = new Intent(FormMenu.this, FormServicos.class);
                startActivity(servicos);
            }

            public void FormServicos(View view){
                Intent servicos = new Intent(FormMenu.this, FormServicos.class);
                startActivity(servicos);
            }
        });
        btnLogout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Logout = new Intent(FormMenu.this, FormLogin.class);
                startActivity(Logout);
                finish();
                Toast.makeText(FormMenu.this, "Desconectado com sucesso", Toast.LENGTH_SHORT).show();
            }
        });
    }
}