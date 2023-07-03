using System.ComponentModel.DataAnnotations.Schema;

namespace MailEntities
{

    [Table("Mail")]
    public class Mail
    {
        public int MailId { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public string Remitente{ get; set; }
        public string Destinatario { get; set; }

    }
}