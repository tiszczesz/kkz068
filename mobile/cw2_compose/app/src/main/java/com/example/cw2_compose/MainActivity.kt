package com.example.cw2_compose

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.Button
import androidx.compose.material3.OutlinedButton
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.cw2_compose.ui.theme.Cw2_composeTheme
import androidx.compose.foundation.lazy.items

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            Cw2_composeTheme {

                MyForm()
            }
        }
    }
}

@Composable
fun MyForm() {
    var firstname by remember { mutableStateOf("") }
    var lastname by remember { mutableStateOf("") }
    var email by remember { mutableStateOf("") }
    var listUsers = remember { mutableStateListOf<String>() }
    Column(
        modifier = Modifier.fillMaxWidth()
    ) {
        Spacer(modifier = Modifier.height(60.dp))
        Row(
            verticalAlignment = Alignment.CenterVertically,
            horizontalArrangement = Arrangement.End,
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp)
        ) {
            Text("Podaj imię: ", fontSize = 20.sp)
            OutlinedTextField(firstname, onValueChange = { value ->
                firstname = value
            })
        }
        Row(
            verticalAlignment = Alignment.CenterVertically,
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp)
        ) {
            Text("Podaj nazwisko: ", fontSize = 20.sp)
            OutlinedTextField(lastname, onValueChange = {
                lastname = it
            })
        }
        Row(
            verticalAlignment = Alignment.CenterVertically,
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp)
        ) {
            Text("Podaj email: ", fontSize = 20.sp)
            OutlinedTextField(email, onValueChange = {
                email = it
            })
        }
        Button(
            modifier = Modifier
                .fillMaxWidth()
                .padding(24.dp)
                .background(Color(0xFF6200EE)),
            onClick = {
                if (firstname.isNotEmpty() && lastname.isNotEmpty() && email.isNotEmpty()) {
                    listUsers.add("$firstname $lastname email: $email")
                    firstname = ""
                    lastname = ""
                    email = ""
                }
            })
        {
            Text("Zatwierdź", fontSize = 20.sp, modifier = Modifier.padding(8.dp))
        }
        LazyColumn(
            modifier = Modifier
                .fillMaxSize()
                .background(Color(0xFFEFF3F3)),
        ) {
            items(listUsers) { item ->
                Text(text = item, modifier = Modifier.padding(8.dp))
            }
        }
    }
}

@Preview(showBackground = true)
@Composable
fun DefaultPreview() {
    Cw2_composeTheme {
        MyForm()
    }
}