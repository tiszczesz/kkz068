fun main() {
    //val p1 = Person("Jan", "Kowalski")
    //println(p1)
    var s1 = Student("Jan", "Kowalski", 12345)
    println(s1)
    val w1 = Worker("Jan", "Kowalski", 1234.56)
    println(w1)
    val t1 = Teacher("Jan", "Kowalski", "Matematyka")
    println(t1)
}

//open class Person(protected var firstname: String, protected var lastname: String) {
//    init {
//        "tworzenie klasy Person"
//    }
//    override fun toString(): String {
//        return "$firstname $lastname"
//    }
//}
abstract class Person(protected var firstname: String, protected var lastname: String) {
    init {
        "tworzenie klasy Person"
    }

    override fun toString(): String {
        return "$firstname $lastname"
    }
}

class Student(firstname: String, lastname: String, var index: Int) : Person(firstname, lastname) {
    init {
        "tworzenie klasy Student"
    }

    override fun toString(): String {
        return "${super.toString()} $index"
    }
}

class Worker(firstname: String, lastname: String, var salary: Double)
    : Person(firstname, lastname), IWorkered {
    init {
        "tworzenie klasy Worker"
    }

    override fun toString(): String {
        return "${super.toString()} $salary"
    }

    override fun work(): String {
        return "Pracownik cieżko pracuje za pensje: $salary"
    }
}

class Teacher(firstname: String, lastname: String, var subject: String) :
    Person(firstname, lastname),IWorkered {
    init {
        "tworzenie klasy Teacher"
    }

    override fun toString(): String {
        return "${super.toString()} $subject"
    }

    override fun work(): String {
        return "Nauczyciel uczy przedmiotu: $subject tez dla kasy"
    }
}

interface IWorkered {
    fun work(): String
}