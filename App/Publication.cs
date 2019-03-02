using System;

namespace StoreOnline.App.Model
{
    public class Publication
    {
        private string title;
             public string Title

        {
            get { return title;}
            set { title = value;}
        }

        private DateTime edititionDate;
        public DateTime EdititionDate
        {
            get { return edititionDate;}
            set { edititionDate = value;}
        }
        
        private string editorial;
        public string Editorial
        {
            get { return editorial;}
            set { editorial = value;}
        }
        
        private string[] authors;
        public string[] Authors
        {
            get { return authors;}
            set { authors = value;}
        }

        public Publication(){}

    public Publication (string title, DateTime edititionDate, string editorial){

        this.title = title;
        this.edititionDate = edititionDate;
        this.editorial = editorial;
    }

    }
}