using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class CommentsList
    {

        public  List<Comments> comList = new List<Comments>();
        public Comments com1 = new Comments("Admin",DateTime.Today.Date, "Мама всегда безумно интересно рассказывала о Чернобыльской трагедии, и я с огромным удовольствием каждый раз слушала её рассказы. Она рассказывала о том как распространялись слухи, как люди боролись с радиацией, как ликвидировали катастрофу и многое...");
        public Comments com2 = new Comments("User1", DateTime.Today.Date, "Всем привет. Сегодня обнаружил на обменнике данный сериал, премьера которого состоялась на днях. Пока что посмотрел первую серию. Но по ней можно определить, что кино достойно внимания. Фильм художественный. Тема всем известная, про аварию на...");


        public  CommentsList()
        {
            comList.Add(com1);
            comList.Add(com2);
        }

        public int Count()
        {
            return comList.Count;
        }

        public List<Comments> Info()
        {
            return comList;
        }
    }
}