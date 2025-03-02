package com.example.cw6

import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.Spinner
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
        // ------------------------------
        val educationsSpin = findViewById<Spinner>(R.id.eduspinner)
        val result = findViewById<TextView>(R.id.tvResult)
        val runButton = findViewById<Button>(R.id.btnRun)
        val firstNameEdit = findViewById<EditText>(R.id.edFirstname)
        val lastNameEdit = findViewById<EditText>(R.id.edLastname)
        val selectedEducation = findViewById<TextView>(R.id.tvEducation)
        //---------------------------
        //  val educations2 = arrayOf("Primary", "Secondary", "High School", "University")
        val educations = resources.getStringArray(R.array.educations)
        val adapter: ArrayAdapter<String> =
            ArrayAdapter(this, android.R.layout.simple_spinner_item, educations)
        educationsSpin.adapter = adapter

        educationsSpin.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(p0: AdapterView<*>?, p1: View?, p2: Int, p3: Long) {
                selectedEducation.text = educations[p2]
            }

            override fun onNothingSelected(p0: AdapterView<*>?) {
                selectedEducation.text ="noname"
            }

        }

        runButton.setOnClickListener {
            result.text = ""
            //    Toast.makeText(this@MainActivity, "Hello", Toast.LENGTH_LONG).show()
            val firstName = firstNameEdit.text.toString()
            val lastName = lastNameEdit.text.toString()
            if (firstName.isEmpty() || lastName.isEmpty()) {
                Toast.makeText(this@MainActivity, "Podaj swoje dane", Toast.LENGTH_LONG)
                    .show()
                return@setOnClickListener
            }
            val education = educationsSpin.selectedItem.toString()
            val eduInfo = when (education) { //switch case
                educations[0] -> "do nauki"
                educations[1] -> "trochę mało"
                educations[2] -> "zapraszamy do wspłpracy"
                educations[3] -> "brak danych"
                else -> "Nieznane"
            }
            result.text = "Witaj $firstName $lastName,\n edukacja: $eduInfo"
        }
    }

}