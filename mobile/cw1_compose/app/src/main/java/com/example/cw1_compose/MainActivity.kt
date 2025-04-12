package com.example.cw1_compose

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Button
import androidx.compose.material3.TextField
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.setValue
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
//                    Greeting(
//                        name = "kkz68",
//                        modifier = Modifier.padding(innerPadding)
//                    )
                    LazyColumnExample(modifier = Modifier.padding(innerPadding))
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
            text = "To jest kolejny napis w Text",
            textAlign = TextAlign.Center,
            modifier = modifier.fillMaxWidth()
        )
        MyFirstComposeView()
       // MyList()
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
@Composable
fun LazyColumnExample(modifier: Modifier) {
    // Lista danych (początkowo pustych)
    val items = remember { mutableStateListOf<String>() }

    Column(Modifier.fillMaxSize().padding(16.dp)) {
        // Pole tekstowe do wpisania nowego elementu
        var newItem by remember { mutableStateOf("") }

        TextField(
            value = newItem,
            onValueChange = { newItem = it },
            label = { Text("Dodaj element") },
            modifier = Modifier.fillMaxWidth()
        )

        Spacer(modifier = Modifier.height(8.dp))

        // Przycisk dodający element do listy
        Button(
            onClick = {
                if (newItem.isNotBlank()) {
                    items.add(newItem) // Dodanie nowego elementu do listy
                    newItem = "" // Wyczyszczenie pola tekstowego
                }
            },
            modifier = Modifier.fillMaxWidth()
        ) {
            Text("Dodaj")
        }

        Spacer(modifier = Modifier.height(16.dp))

        // LazyColumn wyświetlający elementy
        LazyColumn(modifier = Modifier.fillMaxSize()) {
            items(items) { item ->
                Text(text = item, modifier = Modifier.padding(8.dp))
            }
        }
    }
}



@Composable
fun MyList(){
    val myData = MyData()
    val list = myData.getData(50, "Hello")
    LazyColumn(
        verticalArrangement = Arrangement.SpaceEvenly,
        modifier = Modifier.fillMaxSize()
    ) {
        items(list) { item ->
            Text(
                text = item,
                fontSize = 18.sp,
                modifier = Modifier.padding(8.dp)
            )
        }

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