package com.example.cw9_classes

import java.time.Year

class Car(
    private var brand: String,
    private var model: String,
    private var year: Int = 2021,
    private var mileage: Int = 1000
) {
    var Brand: String
        get() = brand.uppercase()
        set(value) {
            brand = "--$value--"
        }
    var CarYear: Int
        get() = year
        set(value) {
            year = if (value > Year.now().value) Year.now().value else value
        }

    constructor() : this("noname", "noname", 2025, 0) {
        println("Constructor 2")
    }

    fun printCar() {
        println("Brand: $brand, Model: $model, Year: $year, Mileage: $mileage")
    }

    override fun toString(): String {
        return "(toString:) Brand: $brand, Model: $model, Year: $year, Mileage: $mileage"
    }
}