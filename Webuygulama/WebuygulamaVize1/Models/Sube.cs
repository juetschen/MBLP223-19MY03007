using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WebuygulamaVize1.Models
{
    [Serializable]
    public class Sube
    {
        public virtual int Sube_Id { get; set; }
        public virtual string Sube_Ad { get; set; }
        public virtual string Sehir { get; set; }
        public virtual ICollection<Meyve> Subeler { get; set; } = new List<Meyve>();
    }


    public class SubeMap : ClassMapping<Sube>
    {
        public SubeMap()
        {
            Table("Subeler");
            Id(x => x.Sube_Id, m => m.Generator(Generators.Native));
            Property(x => x.Sube_Ad, c => c.Length(20));
            Property(x => x.Sehir, c => c.Length(30));

            Set(e => e.Subeler,
                mapper =>
                {
                    mapper.Key(k => k.Column("ad"));
                    mapper.Inverse(true);
                    mapper.Cascade(Cascade.All);
                },
               relation => relation.OneToMany(mapping => mapping.Class(typeof(Sube))));
        }
    }
}