package com.example.cw1

import kotlin.random.Random


fun main() {
    // println(welcome("Hello: "))
    // loop1()
    println("\nsuma liczb wylosowanych: ${loop2()}")
    loop3()
    //println(7/2)
    println("\n======================================")
    getPrimes(200)
}

fun welcome(msg: String): String {
    //prosi o imie i zwraca przywitanie
    print("Podaj imie: ")
    val firstname = readln()
    print("Podaj wiek: ")
    val age = readln().toInt()
    val info = if (age < 18) "niepelnoletni" else "pelnoletni"
//    if(age<18)
//        return "$msg $firstname niepelnoletni"
    return "$msg $firstname  \n $info";
}

fun loop1() {
    print("podaj ilosc powtorzen: ")
    val howMany: Int = readln().toInt()
    for (i in 1..howMany) {
        print("$i ")
    }
}

fun loop2(): Int {
    var sum = 0;
    while (sum < 100) {
        val random = Random.nextInt(1, 20)
        print("$random ")
        sum += random
    }
    return sum
}

fun loop3() {
    do {
        val random = Random.nextInt(0, 10)
        print("$random ")
    } while (random != 0)
}
fun getPrimes(limit:Int):Unit{
    for (index in 2..limit){
        if(isPrime(index)) print("$index ")
    }
}
fun isPrime(number: Int): Boolean {
    if(number<2) return false;
    var count = 2
    while(count*count<=number){
        if(number%count==0) return false;
        count++
    }
    return true;
}