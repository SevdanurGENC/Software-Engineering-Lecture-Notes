package com.mycompany.codecoveragedemo;

public class CodeCoverage {
    
    public static void main(String[] args){
        System.out.println("Hello Java!");
        start();
    }
    
    public static String start(){
        System.out.println("Start");
        return "start";
    }
    
    public static String stop(){
        System.out.println("Stop");
        return "stop";
    }    
    
}
