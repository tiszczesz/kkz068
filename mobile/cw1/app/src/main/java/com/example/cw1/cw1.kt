package com.example.cw1

fun main() {
    //ex1()
    println( ex2());
    println( ex3("to jest informacja",45));
}

fun ex1() {
    //definiowanie zmiennej i typu String
    //val i:String = readln()
    print("Podaj liczbe: ")
    val a: Int = readln().toInt()
    // println("ffff $i")
    println("liczba a = $a");
}

fun ex2(): String { //()=>{return "ffff"}
    return "dsdsfsfsf";
}

fun ex3(message: String, number: Int): String {
    val a = 12;
    //a = 56; error a niezmienialne
    var napis = "ala ma kota";
    napis += " malego";
    return "message: $message, number: $number,  napis: $napis,a = $a"
}