package com.example.cw9_classes

import java.io.File

data class Book(var title: String, var author: String, var year: Int);
fun main() {
    addToFile()
    val books = readFromFile()
    books.forEach { println("Tytul: ${it.title} Autor: ${it.author} Rok: ${it.year}") }
}

//uzytkownik z klawiatury podaje tytul ksiazki, autora, rok wydania
//utworz klase ksiazka, ktora bedzie miala pola tytul, autor, rokWydania
//zapisuj do pliku ksiazki.txt
//zakonczenie wprowadzania danych przez wpisanie stop
//funkcja dopisujaca do pliku az stop
fun addToFile(fileName: String = "ksiazki.txt") {
    var isContinue = true;
    do {
        println("Czy chcesz dodac ksiazke? (t/n)");
        val answer = readLine()!![0];

        if (answer == 't') {
            //informacje o ksiazce
            print("Podaj tytul ksiazki: ");
            val title = readLine() ?: "noname";
            print("Podaj autora ksiazki: ");
            val author = readLine() ?: "noname";
            print("Podaj rok wydania ksiazki: ");
            val year = readLine()?.toInt()!!;
            val b = Book(title, author, year);
            //zapis do pliku
            File(fileName).appendText("${b.title}|${b.author}|${b.year}\n");
        } else {
            isContinue = false;
        }
    } while (isContinue)
}

//funkcja wczytujaca z pliku ksiazki.txt i wyswietlajaca je na ekranie
fun readFromFile(): List<Book> {
    val list = mutableListOf<Book>();
    File("ksiazki.txt").forEachLine {
        val (title, author, year) = it.split("|");
        list.add(Book(title, author, year.toInt()));
    }
    return list
}