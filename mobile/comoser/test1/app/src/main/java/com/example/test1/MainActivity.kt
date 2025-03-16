package com.example.test1

import android.os.Bundle
import android.widget.EditText
import android.widget.SeekBar

import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.OutlinedTextFieldDefaults
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.TextUnit
import androidx.compose.ui.unit.TextUnitType
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.HorizontalDivider
import androidx.compose.material3.Slider
import androidx.compose.material3.SliderDefaults
import androidx.compose.ui.unit.dp
import com.example.test1.ui.theme.Test1Theme
import kotlin.math.roundToInt

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            Test1Theme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    Column(modifier = Modifier.padding(innerPadding)) {
                        Animals()
                    }
                }
            }
        }
    }

    @Composable
    fun Animals() {
        var wlasciciel = remember { mutableStateOf("") }
        var currentAnimal = remember { mutableStateOf("") }
        var age = remember { mutableStateOf(0f) }
        var ageMax = remember { mutableStateOf(20) }
        Column(
            modifier = Modifier
                .fillMaxSize()
                .background(Color(0xFF66EC90))
        ) {
            Text(
                modifier = Modifier
                    .background(Color(0xFF009688))
                    .fillMaxWidth()
                    .padding(10.dp),
                textAlign = TextAlign.Center,
                fontSize = TextUnit(36f, TextUnitType.Sp),
                text = "Animals"
            )
            OutlinedTextField(
                value = wlasciciel.value,
                onValueChange = { wlasciciel.value = it },
                label = { Text("Imię i nazwisko właściciela") },
                modifier = Modifier.fillMaxWidth(),
                colors = OutlinedTextFieldDefaults.colors(
                    focusedBorderColor = Color.Black,
                    unfocusedBorderColor = Color.Transparent,
                    focusedLabelColor = Color.Gray,
                    unfocusedLabelColor = Color.Gray
                ),
//                shape = androidx.compose.foundation.shape.RoundedCornerShape(0.dp)
            )
            LazyColumn {
                items(listOf("Pies", "Kot", "Świnka morska")) { animal ->
                    Text(
                        text = animal,
                        modifier = Modifier
                            .fillMaxWidth()
                            .padding(12.dp)
                            .clickable {
                                val context = this@MainActivity

                                currentAnimal.value = animal
                                when(animal){
                                    "Pies" -> ageMax.value = 18
                                    "Kot" -> ageMax.value = 20
                                    "Świnka morska" -> ageMax.value = 9
                                }
                                Toast.makeText(context, currentAnimal.value, Toast.LENGTH_SHORT)
                                    .show()
                            }
                    )
                    HorizontalDivider(color = Color.Gray, thickness = 1.dp)
                }
            }
            Row {
                Text("ile ma lat: ")
                Text(text = age.value.roundToInt().toString())
                Spacer(modifier = Modifier.width(10.dp))
                Slider(
//                    modifier = Modifier.padding(10.dp),
                    value = age.value,
                    onValueChange = { age.value = it },
                    valueRange = 0f..ageMax.value.toFloat(),
                    steps = 19,
                    colors = SliderDefaults.colors(
                        thumbColor = Color.Black,
                        activeTrackColor = Color.Gray
                    )
                )
            }
        }


    }




    @Preview(showBackground = true)
    @Composable
    fun GreetingPreview() {
        Test1Theme {
            Animals()
        }
    }
}