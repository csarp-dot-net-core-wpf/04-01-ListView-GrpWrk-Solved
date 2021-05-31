using oop.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop.repository
{
    /// <summary>
    /// Iskola polgárok, azaz diákok és tanárok
    /// </summary>
    class SchoolCitizens
    {
        /// <summary>
        /// Diákok listája
        /// </summary>
        List <Student> students;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public SchoolCitizens()
        {
            students = new List<Student>();
            students.Add(new Student("Bukfenc Béla", "/images/BukfencBela.jpg", "9.a", 2.35));
            students.Add(new Student("Stréber Szandra", "/images/StreberSzandra.jpg", "9.a", 4.95));
            students.Add(new Student("Matek Miklós", "/images/MatekMiklos.jpg", "9.b", 4.15));
            students.Add(new Student("Humán Helga", "/images/HumanHelga.jpg", "9.b", 3.67));
            students.Add(new Student("Jeletkező János", "/images/JelentkezoJanos.jpg", "9.b", 4.35));
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        /// <summary>
        /// Kiválasztott iskolapolgárok száma
        /// </summary>
        public int StudentNumber
        {
            get
            {
                int number = 0;
                foreach (Human human in students)
                { 

                    number += 1;
                }
                return number;
            }
        }


        /// <summary>
        /// Kiválasztott diákok száma
        /// </summary>
        public int SelectedStudentNumber
        {
            get
            {
                int selectedStudentNumber = 0;
                foreach (Human human in students)
                {
                    if (human is Student)
                    {
                        if (human.Selected)
                            selectedStudentNumber += 1;
                    }
                }
                return selectedStudentNumber;
            }
        }


        /// <summary>
        /// Kijelölt diákok átlagának átlaga
        /// </summary>
        public double SelectedStudentAvarageOfGradePointAvarage
        {
            get
            {
                double sumOfGradePointAvarage = 0;
                foreach (Human human in students)
                {
                    if (human is Student)
                    {
                        Student s = human as Student;
                        if (human.Selected)
                            sumOfGradePointAvarage += s.GradePointAvarage;
                    }
                }
                return sumOfGradePointAvarage / SelectedStudentNumber;
            }
        }


    }
}
