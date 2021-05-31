using oop.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Diák
    /// </summary>
    class Student : Human
    {
        /// <summary>
        /// A diák osztálykódja (pl. 9.a)
        /// </summary>
        private string classId;
        /// <summary>
        /// A diák év végi átlaga
        /// </summary>
        private double gradePointAvarage;

        /// <summary>
        /// Diák év év átlaga tulajdonság
        /// </summary>
        public double GradePointAvarage
        {
            get
            {
                return gradePointAvarage;
            }
        }

        /// <summary>
        /// Osztály kód tulajdonság
        /// </summary>
        public string ClassId 
        { 
            get
            {
                return classId;
            }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A diák neve</param>
        /// <param name="image">A diák képének útvonala</param>
        /// <param name="subject">A diák osztálykódja</param>
        /// <param name="payment">A diák év végi átlaga </param>
        public Student(string name, string image, string classId, double gradePointAvarage)
            : base(name, image)
        {
            this.classId = classId;
            this.gradePointAvarage = gradePointAvarage;
        }
    }
}
