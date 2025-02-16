package com.example.cw1

fun main(){
   // ex41()
    ex42()
}
fun ex41(){
   val listOfName = listOf("Jan","Anna","Maria","Piotr","Krzysztof","Zbigniew",
                                "Katarzyna","Wojciech","Małgorzata","Marek")
    println(listOfName.joinToString())
    for (elem in listOfName){
        println(elem)
    }
   // listOfName.add("Tomasz")
    println( listOfName.dropLast(1).joinToString())
    println(listOfName.size)
    println(listOfName.joinToString())
}
fun ex42(){
    val mutableListOfName = mutableListOf("Jan","Anna","Maria","Piotr","Krzysztof","Zbigniew",
        "Katarzyna","Wojciech","Małgorzata","Marek")
    println(mutableListOfName.joinToString())
    for (elem in mutableListOfName){
        println(elem)
    }
    mutableListOfName.add("Tomasz")
    println(mutableListOfName.size)
    println(mutableListOfName.joinToString())
    mutableListOfName.removeAt(mutableListOfName.size-2)
    println(mutableListOfName.joinToString())
    mutableListOfName.forEach {println(it.uppercase()) }
}