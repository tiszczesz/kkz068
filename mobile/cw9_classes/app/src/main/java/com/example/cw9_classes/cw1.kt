package com.example.cw9_classes

import java.io.File

fun main(){
   // ex1()
    val listPersons = personsToList();
    listPersons.forEach { println("imie: ${it.name} wiek: ${it.age} adres: ${it.address}") }
}
data class Person(var name:String,var age:Int,var address:String);

fun ex1(){
    val p1 = Person("Ali", 20, "Tehran");
    val p2 = Person("Magda", 20, "Warszawa");
    val p3 = Person("Tomasz", 44, "Kraków");
    val p4 = Person("Kasia", 33, "Gdańsk");
    val listPersons = listOf(p1,p2,p3,p4);
    listPersons.forEach { println("imie: ${it.name} wiek: ${it.age} adres: ${it.address}") }
    File("persons.txt").printWriter().use { out ->
        listPersons.forEach { out.println("${it.name}|${it.age}|${it.address}") }
    }
}
fun personsToList():List<Person>{
    val listPersons = mutableListOf<Person>();
    File("persons.txt").forEachLine {
        val (name, age, address) = it.split("|");
        listPersons.add(
            Person(name, age.toInt(), address)
        );
    }
//    val lines = File("gggg").readLines()
//    for (line in lines) {
//        val (name, age, address) = line.split("|");
//        listPersons.add(Person(name, age.toInt(), address));
//    }
    return listPersons;
}