package com.example.cw10_list

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import android.widget.Toast
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
        val etAdd = findViewById<EditText>(R.id.etAdd)
        val btnAdd = findViewById<Button>(R.id.btnAdd)
        val lvContacts = findViewById<ListView>(R.id.lvContacts)
        val adapterList = ArrayAdapter<String>(
            this,
            android.R.layout.simple_list_item_1, contacts
        )
        // set the adapter to the list view datagridview.DataSource = contacts
        lvContacts.adapter = adapterList;
        btnAdd.setOnClickListener {
            val contact = etAdd.text.toString()
            if (contact.isNotEmpty()) {
                contacts.add(contact)
                adapterList.notifyDataSetChanged()
                etAdd.text.clear()
            }
        }

        lvContacts.setOnItemClickListener { parent, view, position, id ->
            val contact = contacts[position]
            Toast.makeText(this, contact, Toast.LENGTH_SHORT).show()
        }
        lvContacts.setOnItemLongClickListener { parent, view, position, id ->
            contacts.removeAt(position)
            adapterList.notifyDataSetChanged()
            true
        }
       

    }
}