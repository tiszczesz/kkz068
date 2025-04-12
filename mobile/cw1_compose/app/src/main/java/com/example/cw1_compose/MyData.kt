package com.example.cw1_compose

class MyData {
    public fun getData(howMany: Int, text: String): List<String> {
        val list = mutableListOf<String>()
        for (i in 1..howMany) {
            list.add("$text $i")
        }
        return list
    }
}