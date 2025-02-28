package com.example.studentsqllite;

import static java.lang.String.valueOf;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import java.util.ArrayList;
import java.util.List;

public class DBManager extends SQLiteOpenHelper {
    private final String TAG = "DBManager";
    private static final String DATABASE_NAME = "students_manager";
    private static final String TABLE_NAME = "students";
    private static final String ID = "id";
    private static final String NAME = "name";
    private static final String ADDRESS = "address";
    private static final String PHONE_NUMBER = "phone";
    private static final String EMAIL = "email";
    private static int VERSION = 1;
    private Context context;

    public DBManager(Context context) {
        super(context, DATABASE_NAME, null, VERSION);
        this.context = context;
        Log.d(TAG, "DBManager");
    }

    private String SQLQuery = "CREATE TABLE " + TABLE_NAME + " (" +
            ID + " integer primary key, " +
            NAME + " TEXT, " +
            EMAIL + " TEXT, " +
            PHONE_NUMBER + " TEXT, " +
            ADDRESS + " TEXT)";


    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(SQLQuery);
        Log.d(TAG, "onCreate: ");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        Log.d(TAG, "onUpdate: ");
    }

    public void addStudent(Student student) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(NAME, student.getmName());
        values.put(ADDRESS, student.getmAddress());
        values.put(PHONE_NUMBER, student.getmPhoneNumber());
        values.put(EMAIL, student.getmEmail());

        db.insert(TABLE_NAME, null, values);
        db.close();
        Log.d(TAG, "addStudent successfully");
    }

    public List<Student> getAllStudent() {
        List<Student> listStudent = new ArrayList<>();

        String selectQuery = "SELECT * FROM " + TABLE_NAME;

        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(selectQuery, null);
        if(cursor.moveToFirst()) {
            do {
                Student student = new Student();
                student.setmId(cursor.getInt(0));
                student.setmName(cursor.getString(1) + "");
                student.setmEmail(cursor.getString(2));
                student.setmPhoneNumber(cursor.getString(3));
                student.setmAddress(cursor.getString(4));
                listStudent.add(student);
            } while(cursor.moveToNext());
        }
        db.close();
        return listStudent;
    }
    public int updateStudent(Student student) {
       SQLiteDatabase db = this.getWritableDatabase();
       ContentValues values = new ContentValues();
        values.put(NAME, student.getmName());
        values.put(ADDRESS, student.getmAddress());
        values.put(EMAIL, student.getmEmail());
        values.put(PHONE_NUMBER, student.getmPhoneNumber());

        return db.update(TABLE_NAME, values, ID+"=?", new String[]{String.valueOf(student.getmId())});
    }

    public int deleteStudent(int id) {
       SQLiteDatabase db = this.getWritableDatabase();
       return db.delete(TABLE_NAME, ID+"=?", new String[] {String.valueOf(id)});
    }
}
