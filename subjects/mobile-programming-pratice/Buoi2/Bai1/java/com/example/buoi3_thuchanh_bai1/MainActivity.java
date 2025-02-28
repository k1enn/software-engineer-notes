package com.example.buoi3_thuchanh_bai1;

import android.content.Intent;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private final String TAG = "MainActivity";

    Button mbuttonClick;
    TextView mtextViewRe;

    @Override
    public void onCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {
        super.onCreate(savedInstanceState, persistentState);
        setContentView(R.layout.activity_main);

        mbuttonClick = findViewById(R.id.buttonClick);
        mtextViewRe = findViewById(R.id.textViewRe);

        mbuttonClick.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //Mở Activity quay số điện thoại
                Intent intent = new Intent(Intent.ACTION_DIAL);
                startActivity(intent);

                PrintToast("Created");
            }
        });

        Log.d(TAG, "onCreate");


        PrintToast("Created");
    }

    @Override
    protected void onPause()
    {
        super.onPause();

        Log.d(TAG, " onPause ");


        PrintToast("Paused");
    }

    @Override
    protected void onRestart() {
        super.onRestart();

        Log.d(TAG, " onRestart ");

        PrintToast("Restarted");
    }

    @Override
    protected void onResume() {
        super.onResume();

        Log.d(TAG, "onResume");

        PrintToast("Resumed");
    }

    @Override
    protected void onStart() {
        super.onStart();

        Log.d(TAG, "onStart ");

        PrintToast("Started");
    }

    @Override
    protected void onStop() {
        super.onStop();

        Log.d(TAG, "onStop ");

        PrintToast("Stopped");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

        Log.d(TAG, "onDestroy ");

        PrintToast("Destroyed");
    }

    public void PrintToast(String message)
    {
        Toast.makeText(getApplicationContext(), message,
                Toast.LENGTH_LONG).show();
    }

}