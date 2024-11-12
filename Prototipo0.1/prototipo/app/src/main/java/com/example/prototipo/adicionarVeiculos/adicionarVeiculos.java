package com.example.prototipo.adicionarVeiculos;

import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.acessobd.Acessa;

import java.sql.SQLException;


public class adicionarVeiculos extends AppCompatActivity {

    Spinner spnMarca, spnModelo;
    TextView txtResposta;
    String marcaEscolhida;
    int RowsCount = 0;
    Acessa objA = new Acessa();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_adicionar_veiculos);

        spnMarca = findViewById(R.id.spnMarca);
        spnModelo = findViewById(R.id.spnModelo);
        txtResposta = findViewById(R.id.resposta);

        veiculoAdaptado = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, veiculos);
        spnMarca.setAdapter(veiculoAdaptado);
        modeloAdaptado = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, modelos);
        spnModelo.setAdapter(modeloAdaptado);

        spnMarca.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int ItemPosicao, long l) {
                auxMarca = ItemPosicao;
                posicao();
                preencherModelo(marcaEscolhida);
                txtResposta.setText(RowsCount + "");
                if (auxMarca != 0) {
                    auxMarca = 0;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });

        spnModelo.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int ItemPosicao, long l) {
                auxModelo = ItemPosicao;
                if (auxModelo != 0) {
                    auxModelo = 0;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });
    }

    private static final String [] veiculos =
            {"Citroën", "Fiat", "Ford", "Chevrolet", "Honda", "Peugeot", "Renault", "Toyota", "Volkswagen"};
    ArrayAdapter<String> veiculoAdaptado;
    int auxMarca = 0;

    private static final String [] modelos = {};
    ArrayAdapter<String> modeloAdaptado;
    int auxModelo = 0;

    public void posicao() {
        switch (auxMarca) {
            case 0:
                marcaEscolhida = "Citroën";
                break;

            case 1:
                marcaEscolhida = "Fiat";
                break;

            case 2:
                marcaEscolhida = "Ford";
                break;

            case 3:
                marcaEscolhida = "Chevrolet";
                break;

            case 4:
                marcaEscolhida = "Honda";
                break;

            case 5:
                marcaEscolhida = "Peugeot";
                break;

            case 6:
                marcaEscolhida = "Renault";
                break;

            case 7:
                marcaEscolhida = "Toyota";
                break;

            case 8:
                marcaEscolhida = "Volkswagen";
                break;
        }
    }

    public void alerta (String texto) {
        AlertDialog.Builder dialogo = new AlertDialog.Builder(adicionarVeiculos.this);
        dialogo.setMessage("O aumento foi de " + texto);
        dialogo.setNeutralButton("OK", null);
        dialogo.show();
    }

    public void preencherModelo(String marca) {
        try{
            objA.RS = objA.stmt.executeQuery("select ModeloVeiculo from CadVeiculo where MarcaVeiculo = '" + marca + "'");
            while (objA.RS.next()) {
                RowsCount++;
            }
//            if(objA.RS.next()) {
//                objA.RS.first();
//                for (int i = 0; i < RowsCount; i++) {
//                    modelos[i] = "" + objA.RS.getString("ModeloVeiculo");
//                }
//                ArrayAdapter<String> modeloAdaptado;
//                txtResposta.setText("a");
//            }
        } catch(SQLException ex){
            Toast.makeText(this, "erro ao achar modelos", Toast.LENGTH_SHORT).show();
        }
    }
}
