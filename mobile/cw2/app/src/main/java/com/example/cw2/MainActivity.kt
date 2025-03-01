package com.example.cw2

import android.os.Bundle
import android.widget.Button
import android.widget.TextView
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
        val incrementButton = findViewById<Button>(R.id.inc)
        val decrementButton = findViewById<Button>(R.id.dec)
        val counter = findViewById<TextView>(R.id.counter)
        var count = 0
        val limit = 20
        incrementButton.setOnClickListener {
            count++
            if(count>limit){
                count = limit
                Toast.makeText(this, "Osiągnięto limit", Toast.LENGTH_SHORT)
                    .show()
            }
            counter.text = count.toString()
        }
        decrementButton.setOnClickListener {
            count--
            if(count<-limit){
                count = -limit
                Toast.makeText(this, "Osiągnięto limit", Toast.LENGTH_SHORT)
                    .show()
            }
            counter.text = count.toString()
        }
    }
}