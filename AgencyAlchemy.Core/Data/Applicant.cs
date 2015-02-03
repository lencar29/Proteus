using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgencyAlchemy.Core.Data
{
    public class Applicant:Person
    {
        private Applicant() : base() { }

        public String metrics { get; set; }

        public IEnumerable<Media> GetMedia(out int count, int page = 1, int pageSize = 10)
        {
            return Media.GetTalentMedia(this.people_pk, out count, page, pageSize);
        }
    }
}
