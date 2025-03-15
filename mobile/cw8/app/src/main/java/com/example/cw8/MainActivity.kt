package com.example.cw8

import android.graphics.Color
import android.graphics.Color.*
import android.os.Bundle
import android.widget.Button
import android.widget.SeekBar
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val texts = arrayOf("Hello, World!", "Hello, Android!", "Hello, Kotlin!")
        val colors = resources.getStringArray(R.array.colors_array)
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val btnNext = findViewById<Button>(R.id.btnNext)
        val tvShowSize = findViewById<TextView>(R.id.tvShowSize)
        val tvResult = findViewById<TextView>(R.id.tvResult)
        val tvResult2 = findViewById<TextView>(R.id.tvResult2)
        val seekBar = findViewById<SeekBar>(R.id.seekBar)
        seekBar.progress = 30
        val seekBar2 = findViewById<SeekBar>(R.id.seekBar2)
        seekBar2.progress = seekBar2.max
        var index = 0
        tvResult.text = texts[index]
        tvResult.textSize = seekBar.progress.toFloat()
        tvShowSize.text = "Rozmiar: ${seekBar.progress}"
        btnNext.setOnClickListener {
            index = (index + 1) % texts.size
            tvResult.text = texts[index]
        }
        seekBar.setOnSeekBarChangeListener(object: SeekBar.OnSeekBarChangeListener{
            override fun onProgressChanged(p0: SeekBar?, p1: Int, p2: Boolean) {
                if(p1>0){
                    tvResult.textSize = p1.toFloat()
                    tvShowSize.text = "Rozmiar: $p1"
                }
            }

            override fun onStartTrackingTouch(p0: SeekBar?) {
               // TODO("Not yet implemented")
            }

            override fun onStopTrackingTouch(p0: SeekBar?) {
               // TODO("Not yet implemented")
            }
        })
        seekBar2.setOnSeekBarChangeListener(object: SeekBar.OnSeekBarChangeListener{
            override fun onProgressChanged(p0: SeekBar?, p1: Int, p2: Boolean) {
                if(p1>0){
                    tvResult2.alpha = p1.toFloat()/100
                  //  tvResult2.background

                }
            }

            override fun onStartTrackingTouch(p0: SeekBar?) {
                // TODO("Not yet implemented")
            }

            override fun onStopTrackingTouch(p0: SeekBar?) {
                // TODO("Not yet implemented")
            }
        })
    }
}