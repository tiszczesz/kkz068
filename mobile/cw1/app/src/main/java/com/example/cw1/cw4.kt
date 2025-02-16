package com.example.cw1

fun main(){
    ex41()
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
    val listOfName = mutableListOf("Jan","Anna","Maria","Piotr","Krzysztof","Zbigniew",
        "Katarzyna","Wojciech","Małgorzata","Marek")
    println(listOfName.joinToString())
    for (elem in listOfName){
        println(elem)
    }
    listOfName.add("Tomasz")
    println(listOfName.size)
    println(listOfName.joinToString())
    listOfName.removeAt(listOfName.size-2)
    println(listOfName.joinToString())

}