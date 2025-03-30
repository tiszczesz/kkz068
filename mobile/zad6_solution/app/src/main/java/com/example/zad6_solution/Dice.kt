package com.example.zad6_solution

class Dice{
    var sides: Int = 6
    var diceName: String = "k1";
    var diceVal: Int = 1

    fun roll(): Int {
        diceVal = (1..sides).random()
        diceName = "k$diceVal"
        return diceVal
    }

    fun getValue(): Int {
        return diceVal
    }

}
