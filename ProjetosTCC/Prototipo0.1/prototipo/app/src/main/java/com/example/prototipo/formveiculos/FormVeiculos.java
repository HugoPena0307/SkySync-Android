package com.example.prototipo.formveiculos;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.prototipo.R;
import com.example.prototipo.adicionarVeiculos.AddVeiculos;

public class FormVeiculos extends AppCompatActivity {

    Button adicionarVeiculo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_veiculos);

        adicionarVeiculo = findViewById(R.id.btnAdicionar);

        adicionarVeiculo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent agendar = new Intent(FormVeiculos.this, AddVeiculos.class);
                startActivity(agendar);
            }
        });
    }
}