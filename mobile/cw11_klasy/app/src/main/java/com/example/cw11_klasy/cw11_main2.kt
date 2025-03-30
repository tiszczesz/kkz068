package com.example.cw11_klasy

fun main() {
    val s1 = Samochod("Audi", "A4", 2020)
    val s2 = Samochod2("BMW", "X5", 2021)
    println("Rocznik: ${s1.rocznik}")
    //uzycie metody toString
    println(s1)
    println(s2)
}

//klasa w kotlinie z domyslnym konstruktorem wersja klasyczna
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

//klasa w kotlinie z domyslnym konstruktorem wersja uproszczona
class Samochod2(private var marka: String, protected var model: String, var rocznik: Int) {
    //metoda toString
    override fun toString(): String {
        return "Samochod(marka='$marka', model='$model', rocznik=$rocznik)"
    }
}