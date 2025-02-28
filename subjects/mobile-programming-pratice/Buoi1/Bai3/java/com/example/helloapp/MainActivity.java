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

// Github: @k1enn

public class MainActivity extends AppCompatActivity {

    // Khai báo các thành phần giao diện
    EditText mEditTextA,mEditTextB;
    Button mButtonAdd, mButtonSub, mButtonMulti, mButtonDiv;
    TextView mTextView;

    // Dùng để xóa ô nhập liệu
    public boolean deleteInput(EditText mEditTextA, EditText mEditTextB) {
        mEditTextA.setText("");
        mEditTextB.setText("");
        return true;
    }

    public boolean deleteInput(EditText text){
        text.setText("");
        return true;
    }

    // Hàm định dạng kết quả, giúp xuất kết quả theo định dạng
    public String formatResult(String a, String b, double result, String operator) {
        return String.format("%s %s %s = %s", a, operator, b, result);
    }

    // Dùng kiểm tra để tránh trường hợp nhập sai
    private boolean validateAndParseInputs(EditText editTextA, EditText editTextB, TextView textView, double[] result) {
        String a = editTextA.getText().toString();
        String b = editTextB.getText().toString();
        boolean checkPoint = false;

        if (a.isEmpty() || b.isEmpty()) {
            textView.setText("Bạn nhập thiếu");
            return true;
        }

        // Kiểm tra parsing A
        try {
            result[0] = Double.parseDouble(a);
        } catch (Exception e) {
            textView.setText("Xin mời nhập số cho A");
            deleteInput(editTextA); // Xóa A để nhập lại
            checkPoint = true;
            return checkPoint;
        }

        // Kiểm tra nếu parsing A thành công, tiếp tục với B
        if (checkPoint == false) {
            try {
                result[1] = Double.parseDouble(b);
            } catch (Exception e) {
                textView.setText("Xin mời nhập số cho B");
                deleteInput(editTextB); // Xóa B để nhập lại
                return true;
            }
        }

        return false;
    }


    // Hàm chính
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

        // Lấy tham chiếu đến các thành phần giao diện
        mTextView = findViewById(R.id.txtResult);
        mTextView.setEnabled(false); // Không cho phép nhập vào ô kết quả
        mEditTextA = findViewById(R.id.inputA);
        mEditTextB = findViewById(R.id.inputB);
        mButtonAdd = findViewById(R.id.add); // Cộng
        mButtonSub = findViewById(R.id.sub); // Trừ
        mButtonMulti = findViewById(R.id.multi); // Nhân
        mButtonDiv = findViewById(R.id.div); // Chia

        //Phép cộng
        View.OnClickListener add_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả
            if (validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                return; // Kết thúc khi kiểm tra không hợp lệ
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

            // Hiển thị kết quả
            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB); // Xóa các ô nhập liệu
        };
        mButtonAdd.setOnClickListener(add_text);

        // Phép trừ
        View.OnClickListener subtract_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả
            if (validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                return; // Kết thúc khi kiểm tra không hợp lệ
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

            // Hiển thị kết quả
            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB); // Xóa các ô nhập liệu
        };
        mButtonSub.setOnClickListener(subtract_text);

        // Phép nhân
        View.OnClickListener multiply_text = v -> {
            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả
            if (validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
                return; // Kết thúc khi kiểm tra không hợp lệ
            }

            // Lấy giá trị đã được chuyển đổi từ mảng
            double decimalA = decimalValues[0];
            double decimalB = decimalValues[1];

            // Tính toán kết quả và hiển thị
            String result = formatResult(
                    String.valueOf(decimalA),
                    String.valueOf(decimalB),
                    decimalA * decimalB,
                    "x"
            );

            // Hiển thị kết quả
            mTextView.setText(result);
            deleteInput(mEditTextA, mEditTextB); // Xóa các ô nhập liệu
        };
        mButtonMulti.setOnClickListener(multiply_text);

        // Phép chia
        View.OnClickListener divide_text = v -> {
            mTextView.setText("");

            mTextView.setText("");

            double[] decimalValues = new double[2]; // Mảng chứa kết quả chuyển đổi từ chuỗi
            if (validateAndParseInputs(mEditTextA, mEditTextB, mTextView, decimalValues)) {
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
                        ":"
                );

                // Hiển thị kết quả
                mTextView.setText(result);
                deleteInput(mEditTextA, mEditTextB); // Xóa các ô nhập liệu

            } else {
                String result = formatResult(
                        "",
                        "",
                        0,
                        "Không thể chia cho 0"
                );

                // Hiển thị kết quả
                mTextView.setText(result);
                deleteInput(mEditTextA, mEditTextB); // Xóa các ô nhập liệu
            }
        };
        mButtonDiv.setOnClickListener(divide_text);
    }
}