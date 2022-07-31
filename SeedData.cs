using DirectoryWebApi.Models.Entities;

namespace DirectoryWebApi
{
    public class SeedData
    {
        public static async void InitializeDatabase(WebApplication host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    await AddTestData(services.GetRequiredService<DirectoryApiDbContext>());
                }
                catch (Exception e)
                {
                    host.Logger.LogError(e, "An error occurred while seeding the database");
                }

            }
        }
        public static async Task AddTestData(DirectoryApiDbContext context)
        {
            //Already has data, should probably bail
            if (context.Esds.Any() || context.Districts.Any())
            {
                return;
            }

            //System.Diagnostics.Debug.WriteLine("No data found, attempting to add to database");
            context.Esds.Add(new EsdEntity
            {
                Id = 1,
                Name = "Educational Service District 101",
                Code = "32801",
                AddressLine1 = "4202 S Regal Street",
                AddressLine2 = "",
                State = "Washington",
                ZipCode = "99223-7738",
                AdministratorName = "Mike  Dunn",
                Phone = "(509)456-2715",
                Email = "mdunn@esd101.net"
            });

            context.Esds.Add(new EsdEntity
            {
                Id = 2,
                Name = "Educational Service District 105",
                Code = "39801",
                AddressLine1 = "33 S 2ND AVE",
                AddressLine2 = "",
                State = "Washington",
                ZipCode = "98902-3486",
                AdministratorName = "Kevin  Chase",
                Phone = "(509)454-3113",
                Email = "kevin.chase@esd105.org"
            });

            context.Districts.Add(new DistrictEntity
            {
                Id = 1,
                Code = "14005",
                Name = "Aberdeen School District",
                AddressLine1 = "216 N G ST",
                AddressLine2 = "",
                State = "Washington",
                ZipCode = "98520-5297",
                Phone = "(360)538-2006",
                Email = "jthake@asd5.org",
                AdministratorName = "Jeffrey  Thake",
                City = "ABERDEEN",
                EsdCode = "34801",
                EsdName = "Capital Region ESD 113",

            });

            context.Districts.Add(new DistrictEntity
            {
                Id = 2,
                Code = "21226",
                Name = "Adna School District",
                AddressLine1 = "PO BOX 118",
                AddressLine2 = "",
                State = "Washington",
                ZipCode = "98522-0118",
                Phone = "(360)748-0362",
                Email = "nelsont@adnaschools.org",
                AdministratorName = "Thad  nelson",
                City = "ADNA",
                EsdCode = "34801",
                EsdName = "Capital Region ESD 113",

            });

            await context.SaveChangesAsync();
        }
    }
}
