package com.pronote.school.model;
import com.pronote.school.util.enums.*;

public class Student {
    private String name;
    private int age;
    public Color color;
    public Sex sex;
    private Estado estado;

    public Student(Estado estado)
    {
        this.estado = estado;
    }

    public Estado getEstado() {
        return estado;
    }
    
    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    void eating(Food food)
    {

    }

    void drinking (Drink drink)
    {

    }

    void running()
    {

    }
}
