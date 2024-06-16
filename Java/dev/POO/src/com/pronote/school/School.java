package com.pronote.school;

import com.pronote.school.model.Student;
import com.pronote.school.util.enums.*;

public class School {
    public static void main(String[] args) throws Exception {
        Student student = new Student(Estado.SANTA_CATARINA);

        student.sex = Sex.FEMALE;
        student.color = Color.UNKNOW;
        student.setName("Maria Oh");
        student.setAge(24);

        System.out.println(student.getName());
        System.out.println(student.getEstado().getNomeMaiusculo());
    }
}
