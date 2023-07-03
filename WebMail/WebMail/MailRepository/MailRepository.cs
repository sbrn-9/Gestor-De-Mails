using MailEntities;
using System.Collections.Generic;
using System.ComponentModel;

namespace MailRepositoryInt
{
    public class MailRepository
    {
        public List<Mail> Search(string Busqueda)

        {

            List<Mail> list = new List<Mail>();

            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(Busqueda)
                            select m;

                list.AddRange(query.ToList());
                }


                return list;
            }
       


    public void Enviar()
    {

            using (var context = new MailContext())
            {
                
            }

        }




    }
}