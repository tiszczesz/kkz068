package com.example.zad4_solution

import android.content.Intent
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
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
        val btnAdd = findViewById<Button>(R.id.button)
        val list = findViewById<ListView>(R.id.listView)
        val edit = findViewById<EditText>(R.id.editAdd)
        val changeBtn = findViewById<Button>(R.id.btnChange)
        changeBtn.setOnClickListener {
            val intent = Intent(this, TodosActivity::class.java)
            startActivity(intent)
        }
        val todos = mutableListOf<String>(
            "Zakupy: chleb, masło, ser",
            "Do zrobienia: obiad, umyć podłogi",
            "weekend: kino, spacer z psem"
        )
//        val todoAdapter = ArrayAdapter(
//            this,
//            android.R.layout.simple_list_item_1,
//            todos)
        val todoAdapter = ArrayAdapter<String>(
            this,
            R.layout.list_item,
            todos)
        list.adapter = todoAdapter
        btnAdd.setOnClickListener {
            val todo = edit.text.toString()
            todos.add(todo)
            todoAdapter.notifyDataSetChanged()
            edit.text.clear()
        }
    }
}