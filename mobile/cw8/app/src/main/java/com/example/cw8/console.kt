package com.example.cw8

import kotlin.random.Random

fun main() {

    val arr = Array<Int>(20) { Random.nextInt(100) }
    println("\nBefore sorting:")
    arr.forEach { print("$it ") }
    bubbleSort(arr)
    println("\nAfter sorting:")
    arr.forEach { print("$it ") }
}

fun bubbleSort(arr: Array<Int>) {
    val n = arr.size
    for (i in 0 until n - 1) {
        for (j in 0 until n - i - 1) {
            if (arr[j] > arr[j + 1]) {
                val temp = arr[j]
                arr[j] = arr[j + 1]
                arr[j + 1] = temp
            }
        }
    }
}