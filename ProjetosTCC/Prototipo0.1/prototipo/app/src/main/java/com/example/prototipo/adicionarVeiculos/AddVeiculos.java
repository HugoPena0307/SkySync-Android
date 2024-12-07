package com.example.prototipo.adicionarVeiculos;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Spinner;
import android.widget.TextView;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;

import java.util.ArrayList;
import java.util.List;

public class AddVeiculos extends AppCompatActivity {

    Spinner spnMarca;
    AutoCompleteTextView txtModelo;
    TextView txtResposta;
    int RowsCount = 0;
    Acessa objA = new Acessa();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_veiculos);

        spnMarca = findViewById(R.id.spnMarca);
        txtModelo = findViewById(R.id.txtCModelo);
        txtResposta = findViewById(R.id.resposta);

        carregarDadosNoSpinner();
    }

    public void carregarDadosNoSpinner() {
        new Thread(() -> {
            List<String> dados = buscarDados(); // Busca os dados do banco

            // Configura o adaptador no Spinner
            runOnUiThread(() -> {
                ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, dados);
                adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                spnMarca.setAdapter(adapter);
            });
        }).start();
    }

    public List<String> buscarDados() {
        List<String> listaDados = new ArrayList<>();
        listaDados.add("Citroën");
        listaDados.add("GM");
        listaDados.add("Fiat");
        listaDados.add("Ford");
        listaDados.add("Honda");
        listaDados.add("Peugeot");
        listaDados.add("Renault");
        listaDados.add("Toyota");
        listaDados.add("Volkswagen");
        return listaDados;
    }
}