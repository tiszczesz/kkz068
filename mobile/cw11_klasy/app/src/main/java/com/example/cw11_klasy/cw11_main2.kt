package com.example.cw11_klasy

import java.time.Year
import java.util.Calendar
import java.util.Date

fun main() {
    val s1 = Samochod("Audi", "A4", 2020)
    val s2 = Samochod2("BMW", "X5", 2021)
    println("Rocznik: ${s1.rocznik}")
    //uzycie metody toString
    println(s1)
    println(s2)
    val b1 = Book("  Wojna i pokój  ", "L. Tołstoj", 1869)
    println(b1)
    b1.Title = "ala ma kota"
    b1.Year = 2029
    println(b1)
    val b2 = Book()
    println(b2)
    b2.Inna()
}

//klasa w kotlinie z  konstruktorem wersja klasyczna
class Samochod {
    private var marka: String = ""
    protected var model: String = ""
    public var rocznik: Int = 0

    //konstruktor
    constructor(marka: String, model: String, rocznik: Int) {
        this.marka = marka
        this.model = model
        this.rocznik = rocznik
    }
    override fun toString(): String {
        return "Samochod(marka='$marka', model='$model', rocznik=$rocznik)"
    }
}

//klasa w kotlinie z  konstruktorem wersja uproszczona
class Samochod2(private var marka: String, protected var model: String, var rocznik: Int) {
    //metoda toString
    override fun toString(): String {
        return "Samochod(marka='$marka', model='$model', rocznik=$rocznik)"
    }
}


class Book(private var title: String, private var author: String, private var year: Int) {
    //metoda wywołana podczas tworzenia obiektu
    init {
        println("Tworzenie obiektu Book")
        this.title = title.trim()
        this.author = author.uppercase()
    }
    //konstruktor bezparametrowy
    constructor() : this("noname", "noname", 2000) {
        println("Tworzenie obiektu Book bezparametrowego")
    }
    public var Title
        get() = ">>>>$title<<<<"
        set(value) {
            title = value.trim()
        }
    var Year
        get() = year
        set(value) {
            val calendar = Calendar.getInstance()
            val currentYear = calendar.get(Calendar.YEAR)
            if (value >= currentYear) {
                println("Nie można ustawić przyszłego roku")
                year = currentYear
            } else {
                year = value
            }
        }
    //metoda toString
    override fun toString(): String {
        return "Book(title='$Title', author='$author', year=$year)"
    }

    fun Inna(){
        println("Inna metoda: ${toString()}")
    }
}