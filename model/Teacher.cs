using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Tanár
    /// </summary>
    class Teacher : Human
    {
        /// <summary>
        /// A tanár által tanított tantárgy vagy tantárgyak
        /// </summary>
        private string subject;
        /// <summary>
        /// A tanár fizetése
        /// </summary>
        private int payment;

        /// <summary>
        /// Fizetés tulajdonság
        /// </summary>
        public int Payment
        {
            get
            {
                return payment;
            }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A tanár neve</param>
        /// <param name="image">A tanár képények útvonala</param>
        /// <param name="subject">A tanár által tanított tantárgy vagy tantárgyak</param>
        /// <param name="payment">A tanár fizetése</param>
        public Teacher(string name, string image,string subject, int payment)
            :base(name,image)
        {
            this.subject = subject;
            this.payment = payment;
        }
    }
}
