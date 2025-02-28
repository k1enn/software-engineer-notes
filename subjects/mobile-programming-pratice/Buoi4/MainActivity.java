package com.example.buoi4_share_preference;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    EditText etEmail, etPassword;
    CheckBox remember;
    Button signInButton;

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
        initializeUI();
        setupPassword();
        setupSignIn();
    }

    public void initializeUI() {
        etEmail = findViewById(R.id.email);
        etPassword = findViewById(R.id.password);
        remember = findViewById(R.id.checkBoxRememberMe);
        signInButton = findViewById(R.id.email_sign_in_button);

    }
    public void setupPassword() {
        etPassword.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView v, int actionId, KeyEvent event) {
                if(actionId == R.id.login ) {
                    attemptLogin();
                    return true;
                }
                return false;
            }
        });
    }

    public void setupSignIn() {
        signInButton.setOnClickListener(v -> {
                attemptLogin();
        });
    }

    public void attemptLogin() {
        etEmail.setError(null);
        etPassword.setError(null);

       String email = etEmail.getText().toString();
       String password = etPassword.getText().toString();

       boolean cancel = false;
       View focusView = null;

       if (!TextUtils.isEmpty(password) && !isPasswordValid(password)) {
           etPassword.setError(getString(R.string.error_invalid_password));
           focusView = etPassword;
           cancel = true;
       }

       if(TextUtils.isEmpty(email)) {
           etEmail.setError(getString(R.string.error_field_required));
           focusView = etEmail;
           cancel = true;
       } else if (!isEmailValid(email)) {
           etEmail.setError(getString(R.string.error_invalid_email));
           focusView = etEmail;
           cancel = true;
       }

       if(cancel) {
           focusView.requestFocus();
       } else {
           if (remember.isChecked()) {
               saveLoginDetails(email, password);
               startHomeActivity();
           }
           else {
               if(getEmail().equals(email) && getPassword().equals(password)) {
                   startHomeActivity();
               }
               else {
                   startMainActivity();
               }
           }
       }
    }
    private void startHomeActivity() {
        Intent intent = new Intent(this, HomeActivity.class);
        startActivity(intent);
        finish();
    }

    private void startMainActivity() {
        Intent intent = new Intent( this, MainActivity.class);
        startActivity(intent);
        finish();
    }

    private void saveLoginDetails(String email, String password) {
        new PrefManager( this).saveLoginDetails(email, password);
    }

    private String getEmail() {
        return new PrefManager( this).getEmail();
    }

    private String getPassword() {
        return new PrefManager( this).getPassword();
    }

    private boolean isEmailValid(String email) {
        //TODO: Replace this with your own logic
        return email.contains("@");
    }

    private boolean isPasswordValid(String password) {
        return password.length() > 7;
    }
}