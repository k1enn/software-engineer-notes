package com.example.buoi3_lithuyet;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class ActivityOne extends AppCompatActivity {


    EditText edtName, edtAge;
    Button btnStartActivity;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_one);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        edtName = (EditText)findViewById(R.id.edtName);
        edtAge = (EditText)findViewById(R.id.edtAge);
        btnStartActivity = (Button)findViewById(R.id.btnStartActivity);
        // Set OnClickListener for the button
        btnStartActivity.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create a new Intent to start ActivityTwo
                Intent i = new Intent(ActivityOne.this, ActivityTwo.class);

                // Create a Bundle to pass data
                Bundle b = new Bundle();
                b.putString("strName", edtName.getText().toString()); // Get the name input
                b.putInt("intAge", Integer.parseInt(edtAge.getText().toString())); // Get the age input

                // Attach the Bundle to the Intent
                i.putExtras(b);

                // Start ActivityTwo
                startActivity(i);
            }
        });
    }



}