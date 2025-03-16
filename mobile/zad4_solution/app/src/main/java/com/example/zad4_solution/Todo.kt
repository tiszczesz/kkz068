package com.example.zad4_solution

data class Todo(var title: String,var Content:String);

val todos = mutableListOf<Todo>(
    Todo("Title1", "Content1"),
    Todo("Title2", "Content2"),
    Todo("Title3", "Content3"),
    Todo("Title4", "Content4")
)