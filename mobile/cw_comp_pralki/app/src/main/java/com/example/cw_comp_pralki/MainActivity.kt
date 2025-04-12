package com.example.cw_comp_pralki

import android.os.Bundle
import android.widget.ImageView
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.material3.Button
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults

import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.cw_comp_pralki.ui.theme.Cw_comp_pralkiTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            Cw_comp_pralkiTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->

                    RunDevicesView(
                        modifier = Modifier
                            .padding(innerPadding)
                    )
                }
            }
        }
    }
}

@Composable
fun RunDevicesView(modifier: Modifier = Modifier) {
    var runNumber by remember { mutableStateOf("0") }
    var runState by remember { mutableStateOf("Numer prania: nie podano") }
    var start by remember { mutableStateOf("wyłączony") }
    var charged by remember { mutableStateOf("naładowany") }
    var state by remember { mutableStateOf("WŁĄCZ") }
    Column(
        modifier = modifier
            .background(
                Color(0xFFADD8E6) // Replace with your desired color
            ).fillMaxSize()
    ) {
        Text(
            text = "Urządzenia domowe", modifier.fillMaxWidth(),
            textAlign = TextAlign.Center,
            fontSize = 24.sp
        )
        Text(
            text = "Autor: XXXXXXXXXXXX", modifier.fillMaxWidth(),
            textAlign = TextAlign.Center,
            fontSize = 20.sp
        )
        Row(
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp),
            horizontalArrangement = Arrangement.Center
        ) {
            val image = painterResource(R.drawable.pralka)
            Image(
                painter = image,
                contentDescription = null,
                modifier = Modifier
                    .height(150.dp)

            )
            Spacer(Modifier.width(30.dp))
            Column() {
                Text(text = "Pralka",
                    textAlign = TextAlign.Center,
                    fontSize = 16.sp
                )
                TextField(

                    runNumber,
                    onValueChange = {
                        runNumber = it
                    },
                    label = {
                        Text("Podaj nr prania 1..12")
                    },
                    colors = TextFieldDefaults.colors(
                        focusedContainerColor = Color(0xFF87CEEB),
                        unfocusedContainerColor = Color(0xFF87CEEB),
                        disabledContainerColor = Color(0xFF87CEEB),
                        errorContainerColor = Color.Red,
                    ),



                )
                Button(
                    onClick = {
                        val actual = runNumber.toIntOrNull()
                        if (actual != null && (actual >= 1 && actual <= 12)) {
                            runState = "Numer prania: $runNumber"
                        }  else{runState = "Numer prania: nie podano"}
                    },
                    modifier = Modifier.fillMaxWidth()
                ) {
                    Text(text = "ZATWIERDŹ")
                }
                Text(runState)


            }
        }
        Row(
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp),
            horizontalArrangement = Arrangement.Center
        ) {
            val image = painterResource(R.drawable.odkurzacz)
            Image(
                painter = image,
                contentDescription = null,
                modifier = Modifier
                    .height(150.dp)

            )
            Spacer(Modifier.width(30.dp))
            Column() {
                Text(text = "Odkurzacz",
                    textAlign = TextAlign.Center,
                    fontSize = 16.sp
                )

                Button(
                    onClick = {
                        if (state == "WŁĄCZ") {
                            state = "WYŁĄCZ"
                            start = "włączony"
                            charged = "nienaładowany"
                        } else {
                            state = "WŁĄCZ"
                            start = "wyłączony"
                            charged = "naładowany"
                        }
                    },
                    modifier = Modifier.fillMaxWidth()
                ) {
                    Text(text = state )
                }
                Text(text = "Stan: $start")
                Text(text = charged)


            }
        }

    }

}


