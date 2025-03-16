package com.example.zad4_solution

class Note(protected var title:String, protected var content:String) {
    companion object{
        var counter: Int = 0
    }
    private var  id:Int
    init {
        counter++
        id = counter
    }

    public fun getNote(){
        println( "Title: $title\nContent: $content")
    }

    fun info(){
        println("counter: $counter id: $id Title: $title Content: $content")
    }
}