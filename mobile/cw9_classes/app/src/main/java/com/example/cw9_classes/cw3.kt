package com.example.cw9_classes


fun main() {
    val car1 = Car("Audi", "A4", 2010, 200000)
    val car2 = Car("BMW", "X5", 2015, 100000)
    val car3 = Car("Mercedes", "S500")
    val  car4 = Car()
    val car5  = Car("Tesla", "Model S")
    car5.CarYear = 2027
    car1.Brand = "Audiiii"
    val cars = listOf(car1, car2, car3,car4,car5)
    cars.forEach { println(it) }
    cars.forEach { it.printCar() }
}