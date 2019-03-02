using System;
using System.Collections.Generic;

namespace StoreOnline.App.Model
{
    public class Magazine : Publication
    {
        private int id;
        public int Id
        {
            get { return id;}
            
        }

        public Magazine () : base(){

        }
        public Magazine(string title, DateTime edititionDate, string editorial):
         base (title, edititionDate, editorial){

        }
        public static List <Magazine> makeMagazineList(){
            return null;
        }

        public override string ToString(){
            return $"Magazine: {this.Title}";
        }
    }
}