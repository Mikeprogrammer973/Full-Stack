package com.pronote.school;

import com.pronote.school.model.Student;
import com.pronote.school.util.enums.*;

public class School {
    public static void main(String[] args) throws Exception {
        Student student = new Student();

        student.sex = Sex.FEMALE;
        student.color = Color.UNKNOW;
        student.name = "Maria Oh";
        student.age = 19;

        System.out.println(student.name);
    }
}
