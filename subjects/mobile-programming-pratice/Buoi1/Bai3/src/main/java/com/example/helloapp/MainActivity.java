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

    EditText mEditTextA,mEditTextB;

    Button mButtonAdd, mButtonSub, mButtonMulti, mButtonDiv;
    TextView mTextView;

    public boolean deleteInput(EditText mEditTextA, EditText mEditTextB) {
        mEditTextA.setText("");
        mEditTextB.setText("");
        return true;
    }


    public String formatResult(String a, String b, double result, String operator) {
        return String.format("%s %s %s = %s", a, operator, b, result);
    }


    private boolean validateAndParseInputs(EditText editTextA, EditText editTextB, TextView textView, double[] result) {
        String a = editTextA.getText().toString();
        String b = editTextB.getText().toString();

        if (a.isEmpty() || b.isEmpty()) {
            textView.setText("Bạn nhập thiếu");
            deleteInput(editTextA, editTextB);
            return false;
        }

        try {
            result[0] = Double.parseDouble(a);
            result[1] = Double.parseDouble(b);
        } catch (Exception e) {
            textView.setText("Xin mời nhập số");
            deleteInput(editTextA, editTextB);
            return false;
        }

        return true;
    }



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
        mTextView = findViewById(R.id.txtResult);
        mEditTextA = findViewById(R.id.inputA);
        mEditTextB = findViewById(R.id.inputB);
        mButtonAdd = findViewById(R.id.add);
        mButtonSub = findViewById(R.id.sub);
        mButtonMulti = findViewById(R.id.multi);
        mButtonDiv = findViewById(R.id.div);

        //Addition
        View.OnClickListener add_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả chuyển đổi từ chuỗi
            if (!validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                // Nếu không hợp lệ, đã xử lý lỗi trong hàm validateAndParseInputs, kết thúc ở đây
                return;
            }

            // Lấy giá trị đã được chuyển đổi từ mảng
            double decimalA = decimalValues[0];
            double decimalB = decimalValues[1];

            // Tính toán kết quả và hiển thị
            String result = formatResult(
                    String.valueOf(decimalA),
                    String.valueOf(decimalB),
                    decimalA + decimalB,
                    "+"
            );

            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB);
        };
        mButtonAdd.setOnClickListener(add_text);

        // Subtraction
        View.OnClickListener subtract_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả chuyển đổi từ chuỗi
            if (!validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                // Nếu không hợp lệ, đã xử lý lỗi trong hàm validateAndParseInputs, kết thúc ở đây
                return;
            }

            // Lấy giá trị đã được chuyển đổi từ mảng
            double decimalA = decimalValues[0];
            double decimalB = decimalValues[1];

            // Tính toán kết quả và hiển thị
            String result = formatResult(
                    String.valueOf(decimalA),
                    String.valueOf(decimalB),
                    decimalA - decimalB,
                    "-"
            );

            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB);
        };
        mButtonSub.setOnClickListener(subtract_text);

        // Multiplication
        View.OnClickListener multiply_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả chuyển đổi từ chuỗi
            if (!validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                // Nếu không hợp lệ, đã xử lý lỗi trong hàm validateAndParseInputs, kết thúc ở đây
                return;
            }

            // Lấy giá trị đã được chuyển đổi từ mảng
            double decimalA = decimalValues[0];
            double decimalB = decimalValues[1];

            // Tính toán kết quả và hiển thị
            String result = formatResult(
                    String.valueOf(decimalA),
                    String.valueOf(decimalB),
                    decimalA * decimalB,
                    "*"
            );

            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB);
        };
        mButtonMulti.setOnClickListener(multiply_text);

        // Division
        View.OnClickListener divide_text = v -> {
            mTextView.setText("");

            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả chuyển đổi từ chuỗi
            if (!validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                // Nếu không hợp lệ, đã xử lý lỗi trong hàm validateAndParseInputs, kết thúc ở đây
                return;
            }

            // Lấy giá trị đã được chuyển đổi từ mảng
            double decimalA = decimalValues[0];
            double decimalB = decimalValues[1];

            if (decimalB != 0 && decimalA != 0) {

                // Tính toán kết quả và hiển thị
                String result = formatResult(
                        String.valueOf(decimalA),
                        String.valueOf(decimalB),
                        decimalA / decimalB,
                        "/"
                );

                mTextView.setText(result);
                deleteInput(mEditTextA, mEditTextB);

            } else {
                String result = formatResult(
                        "",
                        "",
                        0,
                        "Không thể chia cho 0"
                );

                mTextView.setText(result);
                deleteInput(mEditTextA, mEditTextB);
            }
        };
        mButtonDiv.setOnClickListener(divide_text);

    }
}