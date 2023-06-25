﻿using App.Core.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Data
{
    public class MailRepository
    {
        public MailRepository()
        {
                
        }

        public List<Mail> Search(string textToSearch,
                                int pageSize,
                                int pageIndex)
        {

            //pageIndex = 1 (pageSize = 5) > ... fila/row 1
            //pageIndex = 2 (pageSize = 5) > ... fila/row 6
            //pageIndex = 3 (pageSize = 5) > ... fila/row 11
            //pageIndex = 4 (pageSize = 5) > ... fila/row 16

            var skipRows = ((pageIndex - 1) * pageSize);

            using (var context = new MailsContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(textToSearch)
                            select m;

                //pageTotal = 3;

                return query.Skip(skipRows)
                            .Take(pageSize)
                            .ToList();
            }

        }


        public void Enviar(string asunto, string contenido, string remitente, string destinatario)
        {
            /* var movie = new Mail();

            using (var conection = new MailsContext())
            {
                while(movie is not null)
                {
                    movie.Asunto = asunto;
                    movie.Contenido = contenido;
                    movie.Remitente = remitente;
                    movie.Destinatario = destinatario;
                }

            } Duda */ 
               
        }


        /* public List<Mail> BSalida()
        {
            var lista = new List<Mail>();

            return lista;
    } */

        /* public List<Mail> BEntrada()
        {
            var lista= new List<Mail>();

            return lista;
    } */

    }
}
