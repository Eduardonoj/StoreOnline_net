using System;
using System.Collections.Generic;
using StoreOnline.App.Interfaces;

namespace StoreOnline.App.Model
{
    public class Book : Publication, IVisualizable
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool readed;
        public bool Readed
        {
            get { return readed; }
            set { readed = value; }
        }

        private int isbn;
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private int timeReaded;
        public int TimeReaded
        {
            get { return timeReaded; }
            set { timeReaded = value; }
        }

        public Book() : base()
        {

        }

        public Book(string title, DateTime edititionDate, string editorial, string[] authors) : base(title, edititionDate, editorial)
        {
            this.Authors = authors; //aqui colocamos esto para ya no crear otro constructo de 4 parametros en Publication y asi hacemos ref a la set de la case autores y ya se le asigna el valor authors
        }
        public DateTime StartToSee(DateTime dateI)
        {
            return dateI;
        }

        public void StopToSee(DateTime dateI, DateTime dateF)
        {
            this.TimeReaded = dateF.Second - dateI.Second;
        }

        public override string ToString()
        {
            return $"Book: {this.Isbn} {this.Title}";
        }
        public static List<Book> makeBookList()
        { //se uso list y no arrayList xq daba error xq los dos primeros grupos de arrays ya o se usan
            return null;
        }
    }
}