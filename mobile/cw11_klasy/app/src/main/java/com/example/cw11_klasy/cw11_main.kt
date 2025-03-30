package com.example.cw11_klasy
import java.io.File

fun main(){
    val p1:Person = Person("Jan","Kowalski",25);
    val p2 = Person("Anna","Nowak",30);
    println(p1);
    println(p2);
    println("p1.firstname");
    val persons = generPersons()
   // savePersonsToFile("persons.txt", persons);
    val loadedPersons = loadPersonsFromFile("persons.txt");
    for (person in loadedPersons) {
        println(person);
    }
}
//data class Najprostrze dane różnego typu w jednej zmiennej
data class Person(var firstname:String,var lastname:String,var age:Int){
    //przeciążenie operatora toString
    override fun toString(): String {
        return "$firstname|$lastname|$age"
    }
};
fun generPersons():Array<Person> {
    val persons = arrayOf(
        Person("Jan", "Kowalski", 25),
        Person("Anna", "Nowak", 30),
        Person("Piotr", "Zalewski", 28)
    )
    return persons;
}
fun savePersonsToFile(filename:String,data:Array<Person>){
    val file = File(filename);
    file.printWriter().use { out ->
        for (person in data) {
            out.println(person.toString());
        }
    }
//    val pw = file.printWriter();
//    for (person in data) {
//        pw.println(person.toString());
//    }
}
fun loadPersonsFromFile(filename:String): List<Person>{
    val file = File(filename);
//    val lines = file.readLines()
//    for (line in lines) {
//        val parts = line.split("|");
//        if (parts.size == 3) {
//            val person = Person(parts[0], parts[1], parts[2].toInt());
//            persons.add(person);
//        }
//    }
    val persons = mutableListOf<Person>();
    file.forEachLine { line ->
        val parts = line.split("|");
        if (parts.size == 3) {
            val person = Person(parts[0], parts[1], parts[2].toInt());
            persons.add(person);
        }
    }
    return persons;
}