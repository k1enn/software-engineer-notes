package com.example.helloapp;

import android.os.Bundle;

import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;



public class MainActivity extends AppCompatActivity {

    EditText mEditText;
    Button mButtonVN, mButtonEN, mButtonClear;
    TextView mTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // Get view
        mTextView = findViewById(R.id.tvResult);
        mEditText = findViewById(R.id.edtName);
        mButtonVN = findViewById(R.id.btnVN);
        mButtonEN = findViewById(R.id.btnEN);
        mButtonClear = findViewById(R.id.btnClear);

        // English output
        View.OnClickListener english_text = v -> {
            String name = mEditText.getText().toString();
            String result = "HELLO " + name;
            mTextView.setText(result);
        };
        mButtonEN.setOnClickListener(english_text);

        // Vietnamese output
        View.OnClickListener vietnamese_text = v -> {
            String name = mEditText.getText().toString();
            String result = "XIN CHÀO " + name;
            mTextView.setText(result);
        };
        mButtonVN.setOnClickListener(vietnamese_text);

        // Clear text
        View.OnClickListener clear_text = v -> {
            mEditText.setText(""); // Clear input field
            mTextView.setText(""); // Clear result field
        };
        mButtonClear.setOnClickListener(clear_text);
    }
}