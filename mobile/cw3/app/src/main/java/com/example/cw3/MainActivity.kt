package com.example.cw3

import android.content.Context
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private var likes = 0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        //odwolanie do dwóch przycisków btnLike i btnDelete
        val btnLike = findViewById<Button>(R.id.btnLike)
        val btnDelete = findViewById<Button>(R.id.btnDelete)
        val btnSave = findViewById<Button>(R.id.btnSave)
        val tvLikes = findViewById<TextView>(R.id.tvLikes)
//        val result = getFromSharedPreferences(this, "likes")
//        if(result!=null){
//            likes = result.toInt()
//            tvLikes.text = "$likes Polubień"
//        }
        getFromSharedPreferences(this, "likes")?.let {
            likes = it.toInt()
            tvLikes.text = "$likes Polubień"
        }
        btnLike.setOnClickListener{
            likes++
            tvLikes.text = "$likes Polubień"
            //setText(tvLikes)
        }
        btnSave.setOnClickListener{
            saveToSharedPreferences(this, "likes", likes.toString())
        }
        btnDelete.setOnClickListener{
            likes--
            if (likes < 0){
                likes = 0
            }
            tvLikes.text = "$likes Polubień"
           // setText(tvLikes)
        }


    }
    fun saveToSharedPreferences(context: Context, key: String, value: String) {
        val sharedPreferences = context.getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        val editor = sharedPreferences.edit()
        editor.putString(key, value)
        editor.apply()
    }

    // Retrieve data from SharedPreferences
    fun getFromSharedPreferences(context: Context, key: String): String? {
        val sharedPreferences = context.getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        return sharedPreferences.getString(key, null)
    }
//    fun setText(tvLikes: TextView){
//        tvLikes.text = "$likes Polubień"
//    }
}