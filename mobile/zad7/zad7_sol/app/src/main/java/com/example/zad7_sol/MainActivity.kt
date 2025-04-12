package com.example.zad7_sol

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.Spinner
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val myTools = MyTools()
        val mycourses = mutableListOf<String>()
        val courses = myTools.getCourses()
        val coursesList = findViewById<Spinner>(R.id.spinner)
        val adapter = ArrayAdapter(this, android.R.layout.simple_spinner_item, courses)
        val tvFirstname = findViewById<TextView>(R.id.editTextFirstname)
        val tvLastname = findViewById<TextView>(R.id.editTextLastname)
        val acceptedCourses = findViewById<ListView>(R.id.listView)
        val addapterList = ArrayAdapter(this, android.R.layout.simple_list_item_1, mycourses)
        acceptedCourses.adapter=addapterList
        coursesList.adapter = adapter
        val btnSave = findViewById<Button>(R.id.btnSave)
        btnSave.setOnClickListener { 
            val selectedCourses = coursesList.selectedItem.toString()
            val firstname = tvFirstname.text.toString()
            val lastname = tvLastname.text.toString()
            if (firstname.isEmpty() || lastname.isEmpty()) {
                tvFirstname.error = "Podaj swoje imię"
                tvLastname.error = "Podaj swoje nzwisko"
                return@setOnClickListener
            }
            mycourses.add("$firstname $lastname - $selectedCourses")
            addapterList.notifyDataSetChanged()
        }
    }
}