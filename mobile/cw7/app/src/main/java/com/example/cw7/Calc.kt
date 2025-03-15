package com.example.cw7

fun Calculation  (proc:Int,amount:Double=1000.0,month:Int=12):Double{
    return amount+amount*month*proc/100/12
}