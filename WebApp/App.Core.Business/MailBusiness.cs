using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business
{
    public class MailBusiness
    {
        public MailRepository _mailRepository { get; set; }

        public MailBusiness()
        {
            _mailRepository = new MailRepository(); //TODO: DI Inyectar 
        }

        public List<Mail> Search(string textToSearch, 
                                int pageSize,
                                int pageIndex) {

            //TODO: Validar textToSearch, pageIndex
            //TODO: Paginar

            return _mailRepository.Search(textToSearch, 
                                          pageSize, 
                                          pageIndex); 
        }

        public void Enviar(string asunto, string contenido, string remitente, string destinatario)
        {
             _mailRepository.Enviar(asunto,contenido,remitente,destinatario);
        }

        public List<Mail> BSalida()
        {
            return _mailRepository.BSalida();
        }

        public List<Mail> BEntrada()
        {
            return _mailRepository.BEntrada();
        }

    }
}
