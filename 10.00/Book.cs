using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _10._03
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;



        public string Title

        {
            get { return title; }
            set { title = value; }
        }
        public String Category
        { get { return category; } set { category = value; } }

        public String Author
        { get { return author; } set { author = value; } }


        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = pages = value <= 0 ? 1 : value;
            }
        }
        public int ReleaseDate
        {
            get => releaseDate;
            set
            {
                if ((value >= 2021) || (value <= 1450))
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }

        }
        public void vypis()

        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }


    }
           
}




        


