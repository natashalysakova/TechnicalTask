﻿using System.Linq;
using TechnicalTask.Data;
using TechnicalTask.Models;

namespace TechnicalTask.Repository
{
    public class CountryRepository : Repository<Country>
    {
        public CountryRepository(TtContext context) : base(context)
        {
        }

        public override bool IsValid(Country item)
        {
            var organizationId = item.OrganizationCountries.ToArray()[0].OrganizationId;
            var organization = Context.Organizations.Find(organizationId);

            if (organization == null) return false;

            var countries = Context.OrganizationCountries.Where(x => x.OrganizationId == organizationId).ToList();

            return countries.All(x => x.Country.Name != item.Name);
        }

        public override void Create(Country item)
        {
            base.Create(item);

            var organizationId = item.OrganizationCountries.ToArray()[0].OrganizationId;

            Context.OrganizationCountries.Add(new OrganizationCountry
            {
                OrganizationId = organizationId,
                CountryId = item.Id
            });
            Context.SaveChanges();           
        }         
    }
}
