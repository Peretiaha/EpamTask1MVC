using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpamWebApp1.Models;

namespace EpamWebApp1.Models
{
    public class ArticleList
    {

        Article ar1 = new Article("Сериал 'Чернобль'", DateTime.Today.Date, "«Чернобыль» драматизирует «истинную историю одной из худших техногенных катастроф в истории и рассказывает о храбрых мужчинах и женщинах, которые пожертвовали собой, чтобы спасти Европу от невообразимой катастрофы. Мини-сериал сосредоточен на душераздирающем масштабе катастрофы на атомной станции, которая произошла в УССР в апреле 1986 года, раскрывая, как и почему это произошло, и рассказывая шокирующие и замечательные истории героев, которые сражались и пали»");
        Article ar2 = new Article("Сериал 'Сотня'", DateTime.Today.Date, "«Спустя 97 лет после ядерного апокалипсиса считается, что на Земле никто не выжил. Единственные люди обитают на гигантской космической орбитальной станции «Ковчег». Ресурсы станции ограничены, поэтому за любой проступок совершеннолетнего наказание — смертная казнь. На Землю решено отправить сотню несовершеннолетних правонарушителей, которые проверят, насколько планета пригодна к жизни.»");


        public  List<Article> arList = new List<Article>();

        public ArticleList()
        {
            arList.Add(ar1);
            arList.Add(ar2);
        }

        public List<Article> ArticleListFull()
        {
            return arList;
        }

        public int ArticleCount()
        {
            return arList.Count;
        }

        public void Add(Article ar)
        {

            arList.Add(ar);

        }



       


    }
}