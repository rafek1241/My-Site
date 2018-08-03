using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Certificate
    {
        public long CertificateId { get; set; }

        /// <summary>
        /// Exam title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Exam number
        /// </summary>
        public string Number { get; set; }

        public string License { get; set; }

        public DateTime CertificateBegin { get; set; }

        /// <summary>
        /// null if certificate is for a lifetime.
        /// </summary>
        public DateTime? CertificateEnd { get; set; }

        public string Url { get; set; }

        public byte[] Photo { get; set; }

        public virtual Institution Institution { get; set; }
    }
}
