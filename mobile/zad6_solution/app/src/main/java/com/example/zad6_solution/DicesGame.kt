package com.example.zad6_solution

class DicesGame(private val dices: List<Dice>) {

    fun play() {
        for (dice in dices) {
            dice.roll()
        }
    }

    fun getScore(): Int {
        var total = 0;
        //play()
        for (elem in (1..6)) {
            if (dices.count { it.getValue() == elem } > 1) {
                total += elem * dices.count({
                    it.getValue() == elem
                })
            }
        }
        return total;
    }

    fun getDices(): List<Dice> {
        return dices
    }
    fun endGame(){
        for (dice in dices) {
            dice.diceVal = 0
            dice.diceName = "question"
        }
    }
}