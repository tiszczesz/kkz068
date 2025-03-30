package com.example.zad6_solution

import org.junit.Test

import org.junit.Assert.*

/**
 * Example local unit test, which will execute on the development machine (host).
 *
 * See [testing documentation](http://d.android.com/tools/testing).
 */
class ExampleUnitTest {
    @Test
    fun score_isCorrect() {
        val dices = listOf(Dice(), Dice(), Dice(), Dice(), Dice())
        dices[0].diceVal = 3
        dices[1].diceVal = 5
        dices[2].diceVal = 2
        dices[3].diceVal = 1
        dices[4].diceVal = 5
        val game = DicesGame(dices)
        assertEquals(10, game.getScore())
    }
}