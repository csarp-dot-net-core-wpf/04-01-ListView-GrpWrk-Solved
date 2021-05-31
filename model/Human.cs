using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Ember osztály
    /// </summary>
    abstract class Human
    {
        /// <summary>
        /// Ember neve
        /// </summary>
        private string name;
        /// <summary>
        /// Ember fényképének utvonala
        /// </summary>
        protected string image;
        /// <summary>
        /// Az ember ki lett-e választva
        /// </summary>
        protected bool selected;

        /// <summary>
        /// Név tulajdonság
        /// </summary>
        public string Name 
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Fénykép tulajdonság
        /// </summary>
        public string Image
        {
            get
            {
                return image;
            }
        }

        /// <summary>
        /// Kiválasztott tulajdonság
        /// </summary>
        public bool Selected 
        {
            get
            {
                return selected;
            }

            set
            {
                selected = value;
            }
        }

        /// <summary>
        /// Üres konstruktor
        /// </summary>
        protected Human()
        {
            name = string.Empty;
            image = string.Empty;
            Selected = false;
        }

        /// <summary>
        /// Konstruktor névvel és kép útvonalával
        /// </summary>
        /// <param name="name">Az ember neve</param>
        /// <param name="image">Az ember fényképének útvonala</param>
        protected Human(string name, string image)
        {
            this.name = name;
            this.image = image;
            Selected = false;
        }

    }
}
