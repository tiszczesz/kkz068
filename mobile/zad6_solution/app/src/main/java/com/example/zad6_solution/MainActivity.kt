package com.example.zad6_solution

import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private var total  = 0;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val btnRun = findViewById<Button>(R.id.btnRun)
        val btnReset = findViewById<Button>(R.id.btnReset)
        val dices = listOf(Dice(), Dice(), Dice(), Dice(), Dice())
        val game = DicesGame(dices)
        val k1 = findViewById<ImageView>(R.id.k1)
        val k2 = findViewById<ImageView>(R.id.k2)
        val k3 = findViewById<ImageView>(R.id.k3)
        val k4 = findViewById<ImageView>(R.id.k4)
        val k5 = findViewById<ImageView>(R.id.k5)
        val dicesImages = listOf(k1, k2, k3, k4, k5)
        val score = findViewById<TextView>(R.id.score)
        val scoreTotal = findViewById<TextView>(R.id.scoreTotal)
        btnRun.setOnClickListener {
            game.play()

            // Toast.makeText(this@MainActivity, "Score: ${game.getDices()}", Toast.LENGTH_LONG).show()

            for (img in dicesImages) {
                val dice = dices[dicesImages.indexOf(img)].diceName
                when (dice) {
                    "k1" -> img.setImageResource(R.drawable.k1)
                    "k2" -> img.setImageResource(R.drawable.k2)
                    "k3" -> img.setImageResource(R.drawable.k3)
                    "k4" -> img.setImageResource(R.drawable.k4)
                    "k5" -> img.setImageResource(R.drawable.k5)
                    "k6" -> img.setImageResource(R.drawable.k6)
                }
            }
            total += game.getScore()
            score.text = "Wynik tego losowania: ${game.getScore()}"
            scoreTotal.text = "Wynik gry: $total"
        }
        btnReset.setOnClickListener {
            game.endGame()
            for (img in dicesImages) {
                img.setImageResource(R.drawable.question)
            }
            total = 0
            score.text = "Wynik tego losowania: 0"
            scoreTotal.text = "Wynik gry: $total"
        }


    }
}

