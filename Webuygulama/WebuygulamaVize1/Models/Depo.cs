using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;


namespace WebuygulamaVize1.Models

{
    [Serializable]
    public class Depo
    {
        public virtual int Depo_Id { get; set; }
        public virtual string Depo_Ad { get; set; }
        public virtual string Depo_Sube { get; set; }
        public virtual string Sehir { get; set; }
        public virtual ICollection<Sube> Subeler { get; set; } = new List<Sube>();
    }

    public class DepoMap:ClassMapping<Depo>

    {
        public DepoMap()
        {
            Table("Depolar");
            Id(x => x.Depo_Id, m => m.Generator(Generators.Native));
            Property(x => x.Depo_Ad, c => c.Length(20));
            Property(x => x.Depo_Sube, c => c.Length(20));
            Property(x => x.Sehir, c => c.Length(30));

            Set(e => e.Subeler,
                mapper =>
                {
                    mapper.Key(k => k.Column("Depo"));
                    mapper.Inverse(true);
                    mapper.Cascade(Cascade.All);
                },
               relation => relation.OneToMany(mapping => mapping.Class(typeof(Sube))));
        }
    }
}