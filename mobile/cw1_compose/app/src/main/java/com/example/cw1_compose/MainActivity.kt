package com.example.cw1_compose

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.style.TextAlign

import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.cw1_compose.ui.theme.Cw1_composeTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            Cw1_composeTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    Greeting(
                        name = "kkz68",
                        modifier = Modifier.padding(innerPadding)
                    )
                }
            }
        }
    }
}

@Composable
fun Greeting(name: String, modifier: Modifier = Modifier) {
    Column(
        verticalArrangement = Arrangement.Center,
        modifier = Modifier.fillMaxSize()
    ) {
        Text(
            text = "Hello $name!",
            textAlign = TextAlign.Center,
            modifier = modifier.fillMaxWidth()
        )
        Text(
            text = "To jest kolejny napius w Text",
            textAlign = TextAlign.Center,
            modifier = modifier.fillMaxWidth()
        )
        MyFirstComposeView()
    }

}

@Composable
fun MyFirstComposeView() {
    var myValue = remember { mutableStateOf("") }
    Row(
        horizontalArrangement = Arrangement.SpaceEvenly,
        modifier = Modifier.fillMaxWidth()
    ) {

        OutlinedTextField(
            myValue.value, onValueChange = { myValue.value = it },
            modifier = Modifier
                .padding(4.dp),

            label = { Text(text = "Wpisz coś") },
            placeholder = { Text(text = "Wpisz coś") },
        )
        Text(
            text = myValue.value,
            fontSize = 24.sp,
            color = Color(0xFFFF5722),
            modifier = Modifier
                .padding(16.dp)
        )
    }

}

//tylko podczas pracy edycji podgląd
@Preview(showBackground = true)
@Composable
fun GreetingPreview() {
    Cw1_composeTheme {
        Greeting("hhhh")
    }
}