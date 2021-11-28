using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.Mappings
{
    class CustomerMap : ClassMapping<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type (NHibernateUtil.Int64);
                x.Column("Id");
            });

            Property(b => b.Name, x =>
            {
                x.Length(255);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.Email, x =>
            {
                x.Length(255);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Table("tb_Cliente");
        }
    }
}
