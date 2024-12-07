package com.example.prototipo.formagendar;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CalendarView;
import android.widget.Toast;

import com.example.prototipo.R;
import com.example.prototipo.formmenu.FormMenu;

public class FormAgendar extends AppCompatActivity {

    private Button btnAgendar2, btnVoltar;
    CalendarView calendarioAgendar;
    int diaAgendamento = 0;
    int mesAgendamento = 0;
    int anoAgendamento = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_agendar);
        btnAgendar2=findViewById(R.id.btnAgendar2);
        calendarioAgendar = findViewById(R.id.calendario);
        btnVoltar=findViewById(R.id.btnVoltar);

        calendarioAgendar.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(CalendarView view, int year, int month,
                                            int dayOfMonth) {
                Toast.makeText(getApplicationContext(), ""+dayOfMonth, Toast.LENGTH_SHORT).show();
                diaAgendamento = dayOfMonth;
                mesAgendamento = month;
                anoAgendamento = year;
            }
        });

        btnAgendar2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent agendar2 = new Intent(FormAgendar.this, FormMenu.class);
                startActivity(agendar2);
                Toast.makeText(FormAgendar.this, "Agendamento marcado!", Toast.LENGTH_SHORT).show();
            }
            public void FormMenu(View view){
                Intent agendar2 = new Intent(FormAgendar.this, FormMenu.class);
                startActivity(agendar2);
            }
        });

        btnVoltar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Voltar = new Intent(FormAgendar.this, FormMenu.class);
                startActivity(Voltar);
            }
        });
    }


}