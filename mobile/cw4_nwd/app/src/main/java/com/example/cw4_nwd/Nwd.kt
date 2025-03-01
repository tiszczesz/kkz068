package com.example.cw4_nwd

fun nwd(a:Int,b:Int):Int{
    if (b==0) return a
    return nwd(b,a%b)
}