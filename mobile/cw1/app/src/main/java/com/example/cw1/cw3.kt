package com.example.cw1
import java.io.File
import kotlin.random.Random

fun main() {
   // ex31()
//    println(ex32().joinToString ())
//    val data = ex32()
//    for (i in data) {
//        print("$i ")
//    }
//    for(index in 0 until 5){
//        print("${data[index]} ")
//    }
    println("\n======================================")
 //   println(ex33(1,10).joinToString())
    println("\n======================================")
//    val data2 = ex33(1,100)
//    saveToFile(data2)
    readFromFile()
}

fun ex31() {
    //deklaracja tablicy liczb całkowitych o rozmiarze 10 zerami
    val numbers = Array<Int>(10) { 0 }
    numbers[2] = 6
    println(numbers.joinToString())
    for (i in numbers) {
       print("$i ")
    }
}
fun ex32():Array<Int>{
    val numbers = intArrayOf(1,2,3,4,5,6,7,8,9,10)
    return numbers.toTypedArray()
}
fun ex33(from:Int,to:Int):Array<Int>{
    //podaj rozmiar tablicy
    print("Podaj rozmiar tablicy: ");
    val size = readln().toInt();
    return Array<Int>(size) {  Random.nextInt(from, to) }
}

fun saveToFile(data:Array<Int>){
    val file = File("data.txt")
    file.writeText(data.joinToString())
}
fun readFromFile(){
    val file = File("message.txt")
    val data = file.readText()
    val data2 = file.readLines().toTypedArray()
    println(data)
    println("\n======================================")
    for (i in data2) {
        println(i)
    }
}