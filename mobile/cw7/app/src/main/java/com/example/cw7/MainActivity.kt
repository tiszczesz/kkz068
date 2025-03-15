package com.example.cw7

import android.os.Bundle
import android.widget.EditText
import android.widget.SeekBar
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.cw7.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private lateinit var bind: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        bind = ActivityMainBinding.inflate(layoutInflater)
        setContentView(bind.root)
        //setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        //val etTermin = findViewById<EditText>(R.id.etTime)
        bind.seekBar.min = 10
        bind.tvProcent.text = "${bind.seekBar.progress}%"
        bind.seekBar.setOnSeekBarChangeListener(
            object : SeekBar.OnSeekBarChangeListener {
                override fun onProgressChanged(
                    p0: SeekBar?,
                    p1: Int,
                    p2: Boolean
                ) {
                    bind.tvProcent.text = "$p1%"
                }

                override fun onStartTrackingTouch(p0: SeekBar?) {
                    // TODO("Not yet implemented")
                }

                override fun onStopTrackingTouch(p0: SeekBar?) {
                    //  TODO("Not yet implemented")
                }

            })
        bind.btnCount.setOnClickListener {
            try {
                val proc = bind.seekBar.progress
                val amount = bind.etAmount.text.toString().toDouble()
                val month = bind.etTime.text.toString().toInt()
                val result = Calculation(proc, amount, month)
                bind.tvResult.text =
                    "Całkowita kwota pożyczki: $result zł";
            }catch (ex:Exception){
//                bind.tvResult.text = "Błąd"
                Toast.makeText(this@MainActivity, "Błąd",
                          Toast.LENGTH_SHORT).show();
            }

        }
    }
}