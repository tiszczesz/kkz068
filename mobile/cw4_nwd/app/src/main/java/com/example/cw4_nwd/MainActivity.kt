package com.example.cw4_nwd
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
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
        val editA = findViewById<EditText>(R.id.editA)
        val editB = findViewById<EditText>(R.id.editB)
        val result = findViewById<TextView>(R.id.tvResult)
        val btnRun = findViewById<Button>(R.id.btnRun)
        btnRun.setOnClickListener {
            try {
                if(editA.text.isEmpty() || editB.text.isEmpty()){
                    result.text = "Brak danych"
                    return@setOnClickListener
                }
                val a = editA.text.toString().toInt()
                val b = editB.text.toString().toInt()
                result.text = "NWD($a,$b) = ${nwd(a, b)}"
            }catch (e: NumberFormatException){
                result.text = "Błąd danych"
            }catch (  e:Exception  ){
                result.text = "Błąd"
            }

        }

    }
}