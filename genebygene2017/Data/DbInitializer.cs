using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using genebygene2017.Models;

namespace genebygene2017.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GGContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Samples.Any())
            {
                return; // DB has been seeded
            }
            context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

            context.Statuses.AddRange(GetStatuses());
            context.SaveChanges();
            context.Users.AddRange(GetUsers());
            context.SaveChanges();
            context.Samples.AddRange(GetSamples());
            context.SaveChanges();
        }

        private static List<Users> GetUsers()
        {
            return new List<Users>() {
                new Users() { FirstName="Kristine", LastName="Butler" },
                new Users() { FirstName="Alfred", LastName="Hunt" },
                new Users() { FirstName="Cora", LastName="Butler" },
                new Users() { FirstName="Brad", LastName="Huff" },
                new Users() { FirstName="Dewey", LastName="McDonald" },
                new Users() { FirstName="Orlando", LastName="Holt" },
                new Users() { FirstName="Clint", LastName="Reid" },
                new Users() { FirstName="Kim", LastName="Mullins" },
                new Users() { FirstName="Blanche", LastName="Mack" },
                new Users() { FirstName="Dwayne", LastName="Pena" },
            };
        }

        private static List<Samples> GetSamples()
        {
            return new List<Samples>()
            {
                new Samples() { Barcode="129076",  CreatedAt= new DateTime(2015,01,02), CreatedBy=6, StatusId=3 },
                new Samples() { Barcode="850314",  CreatedAt= new DateTime(2015, 06, 15), CreatedBy=7, StatusId=3 },
                new Samples() { Barcode="176033",  CreatedAt= new DateTime(2015, 07, 31), CreatedBy=7, StatusId=0 },
                new Samples() { Barcode="129629",  CreatedAt= new DateTime(2015, 01, 21), CreatedBy=3, StatusId=0 },
                new Samples() { Barcode="773561",  CreatedAt= new DateTime(2015, 02, 21), CreatedBy=9, StatusId=1 },
                new Samples() { Barcode="255253",  CreatedAt= new DateTime(2015, 05, 13), CreatedBy=9, StatusId=0 },
                new Samples() { Barcode="693294",  CreatedAt= new DateTime(2015, 05, 11), CreatedBy=3, StatusId=2 },
                new Samples() { Barcode="455116",  CreatedAt= new DateTime(2015, 09, 13), CreatedBy=6, StatusId=0 },
                new Samples() { Barcode="280561",  CreatedAt= new DateTime(2015, 04, 08), CreatedBy=5, StatusId=3 },
                new Samples() { Barcode="863760",  CreatedAt= new DateTime(2016, 01, 25), CreatedBy=0, StatusId=3 },
                new Samples() { Barcode="211102",  CreatedAt= new DateTime(2015, 08, 24), CreatedBy=4, StatusId=2 },
                new Samples() { Barcode="193882",  CreatedAt= new DateTime(2016, 01, 23), CreatedBy=8, StatusId=1 },
                new Samples() { Barcode="502533",  CreatedAt= new DateTime(2016, 03, 08), CreatedBy=2, StatusId=1 },
                new Samples() { Barcode="371726",  CreatedAt= new DateTime(2015, 04, 15), CreatedBy=8, StatusId=1 },
                new Samples() { Barcode="807891",  CreatedAt= new DateTime(2015, 05, 17), CreatedBy=2, StatusId=1 },
                new Samples() { Barcode="845318",  CreatedAt= new DateTime(2016, 03, 22), CreatedBy=7, StatusId=1 },
                new Samples() { Barcode="601386",  CreatedAt= new DateTime(2015, 11, 18), CreatedBy=3, StatusId=1 },
                new Samples() { Barcode="978804",  CreatedAt= new DateTime(2015, 05, 31), CreatedBy=5, StatusId=2 },
                new Samples() { Barcode="759456",  CreatedAt= new DateTime(2015, 09, 23), CreatedBy=8, StatusId=2 },
                new Samples() { Barcode="949933",  CreatedAt= new DateTime(2015, 07, 04), CreatedBy=0, StatusId=3 },
                new Samples() { Barcode="411443",  CreatedAt= new DateTime(2015, 03, 16), CreatedBy=3, StatusId=0 },
                new Samples() { Barcode="202485",  CreatedAt= new DateTime(2015, 09, 03), CreatedBy=0, StatusId=3 },
                new Samples() { Barcode="737715",  CreatedAt= new DateTime(2015, 10, 07), CreatedBy=0, StatusId=1 },
                new Samples() { Barcode="106957",  CreatedAt= new DateTime(2015, 10, 03), CreatedBy=7, StatusId=1 },
                new Samples() { Barcode="561154",  CreatedAt= new DateTime(2016, 02, 23), CreatedBy=9, StatusId=1 },
                new Samples() { Barcode="923720",  CreatedAt= new DateTime(2015, 06, 09), CreatedBy=2, StatusId=1 },
                new Samples() { Barcode="985114",  CreatedAt= new DateTime(2015, 04, 17), CreatedBy=4, StatusId=0 },
                new Samples() { Barcode="544078",  CreatedAt= new DateTime(2015, 06, 16), CreatedBy=6, StatusId=3 },
                new Samples() { Barcode="605315",  CreatedAt= new DateTime(2015, 06, 23), CreatedBy=7, StatusId=0 },
                new Samples() { Barcode="588963",  CreatedAt= new DateTime(2015, 02, 13), CreatedBy=7, StatusId=1 },
                new Samples() { Barcode="646434",  CreatedAt= new DateTime(2015, 08, 23), CreatedBy=0, StatusId=2 },
                new Samples() { Barcode="819931",  CreatedAt= new DateTime(2015, 11, 10), CreatedBy=0, StatusId=2 },
                new Samples() { Barcode="978799",  CreatedAt= new DateTime(2015, 11, 06), CreatedBy=2, StatusId=3 },
                new Samples() { Barcode="250878",  CreatedAt= new DateTime(2016, 03, 14), CreatedBy=6, StatusId=1 },
                new Samples() { Barcode="499463",  CreatedAt= new DateTime(2015, 10, 20), CreatedBy=5, StatusId=3 },
                new Samples() { Barcode="261808",  CreatedAt= new DateTime(2015, 09, 25), CreatedBy=5, StatusId=3 },
                new Samples() { Barcode="496077",  CreatedAt= new DateTime(2015, 04, 12), CreatedBy=8, StatusId=2 },
                new Samples() { Barcode="939988",  CreatedAt= new DateTime(2015, 05, 15), CreatedBy=4, StatusId=2 },
                new Samples() { Barcode="142598",  CreatedAt= new DateTime(2015, 06, 04), CreatedBy=7, StatusId=1 },
                new Samples() { Barcode="648235",  CreatedAt= new DateTime(2015, 12, 26), CreatedBy=6, StatusId=2 },
                new Samples() { Barcode="949270",  CreatedAt= new DateTime(2015, 10, 22), CreatedBy=0, StatusId=0 },
                new Samples() { Barcode="606179",  CreatedAt= new DateTime(2015, 10, 12), CreatedBy=5, StatusId=2 },
                new Samples() { Barcode="762654",  CreatedAt= new DateTime(2016, 03, 04), CreatedBy=2, StatusId=0 },
                new Samples() { Barcode="230403",  CreatedAt= new DateTime(2015, 07, 20), CreatedBy=5, StatusId=1 },
                new Samples() { Barcode="419103",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=2, StatusId=0 },
                new Samples() { Barcode="105914",  CreatedAt= new DateTime(2016, 01, 19), CreatedBy=5, StatusId=3 },
                new Samples() { Barcode="292591",  CreatedAt= new DateTime(2016, 04, 04), CreatedBy=0, StatusId=2 },
                new Samples() { Barcode="460439",  CreatedAt= new DateTime(2016, 03, 25), CreatedBy=2, StatusId=3 },
                new Samples() { Barcode="905492",  CreatedAt= new DateTime(2015, 02, 13), CreatedBy=4, StatusId=0 },
                new Samples() { Barcode="454128",  CreatedAt= new DateTime(2015, 09, 20), CreatedBy=2, StatusId=1 },
                new Samples() { Barcode="245743",  CreatedAt= new DateTime(2015, 04, 17), CreatedBy=2, StatusId=0 },
                new Samples() { Barcode="127239",  CreatedAt= new DateTime(2015, 09, 24), CreatedBy=3, StatusId=3 },
                new Samples() { Barcode="747765",  CreatedAt= new DateTime(2015, 10, 16), CreatedBy=5, StatusId=0 },
                new Samples() { Barcode="141601",  CreatedAt= new DateTime(2015, 03, 31), CreatedBy=2, StatusId=1 },
                new Samples() { Barcode="427192",  CreatedAt= new DateTime(2015, 03, 01), CreatedBy=3, StatusId=3 },
                new Samples() { Barcode="779537",  CreatedAt= new DateTime(2015, 04, 25), CreatedBy=3, StatusId=0 },
                new Samples() { Barcode="614487",  CreatedAt= new DateTime(2015, 12, 04), CreatedBy=8, StatusId=3 },
                new Samples() { Barcode="771285",  CreatedAt= new DateTime(2015, 12, 24), CreatedBy=7, StatusId=3 },
                new Samples() { Barcode="868108",  CreatedAt= new DateTime(2016, 01, 21), CreatedBy=5, StatusId=3 },
                new Samples() { Barcode="586986",  CreatedAt= new DateTime(2015, 11, 07), CreatedBy=1, StatusId=3 },
                new Samples() { Barcode="957210",  CreatedAt= new DateTime(2015, 01, 28), CreatedBy=0, StatusId=3 },
                new Samples() { Barcode="925265",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=6, StatusId=2 },
                new Samples() { Barcode="229746",  CreatedAt= new DateTime(2015, 08, 02), CreatedBy=1, StatusId=2 },
                new Samples() { Barcode="329580",  CreatedAt= new DateTime(2015, 05, 07), CreatedBy=4, StatusId=0 },
                new Samples() { Barcode="398802",  CreatedAt= new DateTime(2015, 11, 18), CreatedBy=3, StatusId=1 },
                new Samples() { Barcode="793846",  CreatedAt= new DateTime(2016, 04, 04), CreatedBy=7, StatusId=3 },
                new Samples() { Barcode="194543",  CreatedAt= new DateTime(2015, 01, 16), CreatedBy=0, StatusId=2 },
                new Samples() { Barcode="699892",  CreatedAt= new DateTime(2016, 03, 06), CreatedBy=5, StatusId=2 },
                new Samples() { Barcode="849262",  CreatedAt= new DateTime(2015, 11, 20), CreatedBy=5, StatusId=0 },
                new Samples() { Barcode="212969",  CreatedAt= new DateTime(2016, 02, 23), CreatedBy=1, StatusId=2 },
                new Samples() { Barcode="913224",  CreatedAt= new DateTime(2015, 08, 17), CreatedBy=6, StatusId=3 },
                new Samples() { Barcode="283784",  CreatedAt= new DateTime(2015, 01, 23), CreatedBy=1, StatusId=3 },
                new Samples() { Barcode="964445",  CreatedAt= new DateTime(2015, 03, 07), CreatedBy=1, StatusId=1 },
                new Samples() { Barcode="219254",  CreatedAt= new DateTime(2015, 06, 11), CreatedBy=7, StatusId=2 },
                new Samples() { Barcode="136235",  CreatedAt= new DateTime(2015, 03, 21), CreatedBy=4, StatusId=3 },
                new Samples() { Barcode="371430",  CreatedAt= new DateTime(2015, 03, 19), CreatedBy=2, StatusId=2 },
                new Samples() { Barcode="219597",  CreatedAt= new DateTime(2015, 12, 12), CreatedBy=3, StatusId=3 },
                new Samples() { Barcode="721655",  CreatedAt= new DateTime(2016, 04, 29), CreatedBy=5, StatusId=2 },
                new Samples() { Barcode="434154",  CreatedAt= new DateTime(2016, 02, 25), CreatedBy=8, StatusId=0 },
                new Samples() { Barcode="290254",  CreatedAt= new DateTime(2015, 11, 02), CreatedBy=9, StatusId=2 },
                new Samples() { Barcode="736586",  CreatedAt= new DateTime(2015, 05, 30), CreatedBy=4, StatusId=2 },
                new Samples() { Barcode="622526",  CreatedAt= new DateTime(2015, 11, 08), CreatedBy=0, StatusId=1 },
                new Samples() { Barcode="693936",  CreatedAt= new DateTime(2016, 03, 21), CreatedBy=1, StatusId=0 },
                new Samples() { Barcode="529728",  CreatedAt= new DateTime(2015, 02, 25), CreatedBy=1, StatusId=2 },
                new Samples() { Barcode="963244",  CreatedAt= new DateTime(2015, 11, 22), CreatedBy=9, StatusId=0 },
                new Samples() { Barcode="261164",  CreatedAt= new DateTime(2015, 06, 26), CreatedBy=9, StatusId=2 },
                new Samples() { Barcode="986536",  CreatedAt= new DateTime(2016, 01, 07), CreatedBy=6, StatusId=1 },
                new Samples() { Barcode="572741",  CreatedAt= new DateTime(2015, 12, 01), CreatedBy=6, StatusId=1 },
                new Samples() { Barcode="125921",  CreatedAt= new DateTime(2015, 08, 03), CreatedBy=2, StatusId=2 },
                new Samples() { Barcode="262858",  CreatedAt= new DateTime(2015, 12, 07), CreatedBy=3, StatusId=0 },
                new Samples() { Barcode="879489",  CreatedAt= new DateTime(2015, 09, 02), CreatedBy=7, StatusId=1 },
                new Samples() { Barcode="105797",  CreatedAt= new DateTime(2015, 12, 26), CreatedBy=6, StatusId=1 },
                new Samples() { Barcode="806498",  CreatedAt= new DateTime(2015, 07, 26), CreatedBy=8, StatusId=3 },
                new Samples() { Barcode="960686",  CreatedAt= new DateTime(2016, 04, 07), CreatedBy=2, StatusId=2 },
                new Samples() { Barcode="201332",  CreatedAt= new DateTime(2015, 09, 19), CreatedBy=4, StatusId=0 },
                new Samples() { Barcode="405572",  CreatedAt= new DateTime(2015, 11, 04), CreatedBy=3, StatusId=0 },
                new Samples() { Barcode="204617",  CreatedAt= new DateTime(2015, 09, 05), CreatedBy=5, StatusId=1 },
                new Samples() { Barcode="767548",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=7, StatusId=2 },
                new Samples() { Barcode="363492",  CreatedAt= new DateTime(2015, 12, 18), CreatedBy=6, StatusId=1 },
                new Samples() { Barcode="541884",  CreatedAt= new DateTime(2015, 07, 07), CreatedBy=5, StatusId=1 },
            };
        }

        private static List<Statuses> GetStatuses()
        {
            return new List<Statuses>()
            {
                new Statuses() { Status="Received" },
                new Statuses() { Status="Accessioning" },
                new Statuses() { Status="In Lab" },
                new Statuses() { Status="Report Generation" },
            };
        }

        //private static List<Users> GetUsers()
        //{
        //    return new List<Users>() {
        //        new Users() { UserId=0 , FirstName="Kristine", LastName="Butler" },
        //        new Users() { UserId=1 , FirstName="Alfred", LastName="Hunt" },
        //        new Users() { UserId=2 , FirstName="Cora", LastName="Butler" },
        //        new Users() { UserId=3 , FirstName="Brad", LastName="Huff" },
        //        new Users() { UserId=4 , FirstName="Dewey", LastName="McDonald" },
        //        new Users() { UserId=5 , FirstName="Orlando", LastName="Holt" },
        //        new Users() { UserId=6 , FirstName="Clint", LastName="Reid" },
        //        new Users() { UserId=7 , FirstName="Kim", LastName="Mullins" },
        //        new Users() { UserId=8 , FirstName="Blanche", LastName="Mack" },
        //        new Users() { UserId=9 , FirstName="Dwayne", LastName="Pena" },
        //    };
        //}

        //private static List<Samples> GetSamples()
        //{
        //    return new List<Samples>()
        //    {
        //        new Samples() { SampleId=1, Barcode="129076",  CreatedAt= new DateTime(2015,01,02), CreatedBy=6, StatusId=3 },
        //        new Samples() { SampleId=2, Barcode="850314",  CreatedAt= new DateTime(2015, 06, 15), CreatedBy=7, StatusId=3 },
        //        new Samples() { SampleId=3, Barcode="176033",  CreatedAt= new DateTime(2015, 07, 31), CreatedBy=7, StatusId=0 },
        //        new Samples() { SampleId=4, Barcode="129629",  CreatedAt= new DateTime(2015, 01, 21), CreatedBy=3, StatusId=0 },
        //        new Samples() { SampleId=5, Barcode="773561",  CreatedAt= new DateTime(2015, 02, 21), CreatedBy=9, StatusId=1 },
        //        new Samples() { SampleId=6, Barcode="255253",  CreatedAt= new DateTime(2015, 05, 13), CreatedBy=9, StatusId=0 },
        //        new Samples() { SampleId=7, Barcode="693294",  CreatedAt= new DateTime(2015, 05, 11), CreatedBy=3, StatusId=2 },
        //        new Samples() { SampleId=8, Barcode="455116",  CreatedAt= new DateTime(2015, 09, 13), CreatedBy=6, StatusId=0 },
        //        new Samples() { SampleId=9, Barcode="280561",  CreatedAt= new DateTime(2015, 04, 08), CreatedBy=5, StatusId=3 },
        //        new Samples() { SampleId=10, Barcode="863760",  CreatedAt= new DateTime(2016, 01, 25), CreatedBy=0, StatusId=3 },
        //        new Samples() { SampleId=11, Barcode="211102",  CreatedAt= new DateTime(2015, 08, 24), CreatedBy=4, StatusId=2 },
        //        new Samples() { SampleId=12, Barcode="193882",  CreatedAt= new DateTime(2016, 01, 23), CreatedBy=8, StatusId=1 },
        //        new Samples() { SampleId=13, Barcode="502533",  CreatedAt= new DateTime(2016, 03, 08), CreatedBy=2, StatusId=1 },
        //        new Samples() { SampleId=14, Barcode="371726",  CreatedAt= new DateTime(2015, 04, 15), CreatedBy=8, StatusId=1 },
        //        new Samples() { SampleId=15, Barcode="807891",  CreatedAt= new DateTime(2015, 05, 17), CreatedBy=2, StatusId=1 },
        //        new Samples() { SampleId=16, Barcode="845318",  CreatedAt= new DateTime(2016, 03, 22), CreatedBy=7, StatusId=1 },
        //        new Samples() { SampleId=17, Barcode="601386",  CreatedAt= new DateTime(2015, 11, 18), CreatedBy=3, StatusId=1 },
        //        new Samples() { SampleId=18, Barcode="978804",  CreatedAt= new DateTime(2015, 05, 31), CreatedBy=5, StatusId=2 },
        //        new Samples() { SampleId=19, Barcode="759456",  CreatedAt= new DateTime(2015, 09, 23), CreatedBy=8, StatusId=2 },
        //        new Samples() { SampleId=20, Barcode="949933",  CreatedAt= new DateTime(2015, 07, 04), CreatedBy=0, StatusId=3 },
        //        new Samples() { SampleId=21, Barcode="411443",  CreatedAt= new DateTime(2015, 03, 16), CreatedBy=3, StatusId=0 },
        //        new Samples() { SampleId=22, Barcode="202485",  CreatedAt= new DateTime(2015, 09, 03), CreatedBy=0, StatusId=3 },
        //        new Samples() { SampleId=23, Barcode="737715",  CreatedAt= new DateTime(2015, 10, 07), CreatedBy=0, StatusId=1 },
        //        new Samples() { SampleId=24, Barcode="106957",  CreatedAt= new DateTime(2015, 10, 03), CreatedBy=7, StatusId=1 },
        //        new Samples() { SampleId=25, Barcode="561154",  CreatedAt= new DateTime(2016, 02, 23), CreatedBy=9, StatusId=1 },
        //        new Samples() { SampleId=26, Barcode="923720",  CreatedAt= new DateTime(2015, 06, 09), CreatedBy=2, StatusId=1 },
        //        new Samples() { SampleId=27, Barcode="985114",  CreatedAt= new DateTime(2015, 04, 17), CreatedBy=4, StatusId=0 },
        //        new Samples() { SampleId=28, Barcode="544078",  CreatedAt= new DateTime(2015, 06, 16), CreatedBy=6, StatusId=3 },
        //        new Samples() { SampleId=29, Barcode="605315",  CreatedAt= new DateTime(2015, 06, 23), CreatedBy=7, StatusId=0 },
        //        new Samples() { SampleId=30, Barcode="588963",  CreatedAt= new DateTime(2015, 02, 13), CreatedBy=7, StatusId=1 },
        //        new Samples() { SampleId=31, Barcode="646434",  CreatedAt= new DateTime(2015, 08, 23), CreatedBy=0, StatusId=2 },
        //        new Samples() { SampleId=32, Barcode="819931",  CreatedAt= new DateTime(2015, 11, 10), CreatedBy=0, StatusId=2 },
        //        new Samples() { SampleId=33, Barcode="978799",  CreatedAt= new DateTime(2015, 11, 06), CreatedBy=2, StatusId=3 },
        //        new Samples() { SampleId=34, Barcode="250878",  CreatedAt= new DateTime(2016, 03, 14), CreatedBy=6, StatusId=1 },
        //        new Samples() { SampleId=35, Barcode="499463",  CreatedAt= new DateTime(2015, 10, 20), CreatedBy=5, StatusId=3 },
        //        new Samples() { SampleId=36, Barcode="261808",  CreatedAt= new DateTime(2015, 09, 25), CreatedBy=5, StatusId=3 },
        //        new Samples() { SampleId=37, Barcode="496077",  CreatedAt= new DateTime(2015, 04, 12), CreatedBy=8, StatusId=2 },
        //        new Samples() { SampleId=38, Barcode="939988",  CreatedAt= new DateTime(2015, 05, 15), CreatedBy=4, StatusId=2 },
        //        new Samples() { SampleId=39, Barcode="142598",  CreatedAt= new DateTime(2015, 06, 04), CreatedBy=7, StatusId=1 },
        //        new Samples() { SampleId=40, Barcode="648235",  CreatedAt= new DateTime(2015, 12, 26), CreatedBy=6, StatusId=2 },
        //        new Samples() { SampleId=41, Barcode="949270",  CreatedAt= new DateTime(2015, 10, 22), CreatedBy=0, StatusId=0 },
        //        new Samples() { SampleId=42, Barcode="606179",  CreatedAt= new DateTime(2015, 10, 12), CreatedBy=5, StatusId=2 },
        //        new Samples() { SampleId=43, Barcode="762654",  CreatedAt= new DateTime(2016, 03, 04), CreatedBy=2, StatusId=0 },
        //        new Samples() { SampleId=44, Barcode="230403",  CreatedAt= new DateTime(2015, 07, 20), CreatedBy=5, StatusId=1 },
        //        new Samples() { SampleId=45, Barcode="419103",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=2, StatusId=0 },
        //        new Samples() { SampleId=46, Barcode="105914",  CreatedAt= new DateTime(2016, 01, 19), CreatedBy=5, StatusId=3 },
        //        new Samples() { SampleId=47, Barcode="292591",  CreatedAt= new DateTime(2016, 04, 04), CreatedBy=0, StatusId=2 },
        //        new Samples() { SampleId=48, Barcode="460439",  CreatedAt= new DateTime(2016, 03, 25), CreatedBy=2, StatusId=3 },
        //        new Samples() { SampleId=49, Barcode="905492",  CreatedAt= new DateTime(2015, 02, 13), CreatedBy=4, StatusId=0 },
        //        new Samples() { SampleId=50, Barcode="454128",  CreatedAt= new DateTime(2015, 09, 20), CreatedBy=2, StatusId=1 },
        //        new Samples() { SampleId=51, Barcode="245743",  CreatedAt= new DateTime(2015, 04, 17), CreatedBy=2, StatusId=0 },
        //        new Samples() { SampleId=52, Barcode="127239",  CreatedAt= new DateTime(2015, 09, 24), CreatedBy=3, StatusId=3 },
        //        new Samples() { SampleId=53, Barcode="747765",  CreatedAt= new DateTime(2015, 10, 16), CreatedBy=5, StatusId=0 },
        //        new Samples() { SampleId=54, Barcode="141601",  CreatedAt= new DateTime(2015, 03, 31), CreatedBy=2, StatusId=1 },
        //        new Samples() { SampleId=55, Barcode="427192",  CreatedAt= new DateTime(2015, 03, 01), CreatedBy=3, StatusId=3 },
        //        new Samples() { SampleId=56, Barcode="779537",  CreatedAt= new DateTime(2015, 04, 25), CreatedBy=3, StatusId=0 },
        //        new Samples() { SampleId=57, Barcode="614487",  CreatedAt= new DateTime(2015, 12, 04), CreatedBy=8, StatusId=3 },
        //        new Samples() { SampleId=58, Barcode="771285",  CreatedAt= new DateTime(2015, 12, 24), CreatedBy=7, StatusId=3 },
        //        new Samples() { SampleId=59, Barcode="868108",  CreatedAt= new DateTime(2016, 01, 21), CreatedBy=5, StatusId=3 },
        //        new Samples() { SampleId=60, Barcode="586986",  CreatedAt= new DateTime(2015, 11, 07), CreatedBy=1, StatusId=3 },
        //        new Samples() { SampleId=61, Barcode="957210",  CreatedAt= new DateTime(2015, 01, 28), CreatedBy=0, StatusId=3 },
        //        new Samples() { SampleId=62, Barcode="925265",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=6, StatusId=2 },
        //        new Samples() { SampleId=63, Barcode="229746",  CreatedAt= new DateTime(2015, 08, 02), CreatedBy=1, StatusId=2 },
        //        new Samples() { SampleId=64, Barcode="329580",  CreatedAt= new DateTime(2015, 05, 07), CreatedBy=4, StatusId=0 },
        //        new Samples() { SampleId=65, Barcode="398802",  CreatedAt= new DateTime(2015, 11, 18), CreatedBy=3, StatusId=1 },
        //        new Samples() { SampleId=66, Barcode="793846",  CreatedAt= new DateTime(2016, 04, 04), CreatedBy=7, StatusId=3 },
        //        new Samples() { SampleId=67, Barcode="194543",  CreatedAt= new DateTime(2015, 01, 16), CreatedBy=0, StatusId=2 },
        //        new Samples() { SampleId=68, Barcode="699892",  CreatedAt= new DateTime(2016, 03, 06), CreatedBy=5, StatusId=2 },
        //        new Samples() { SampleId=69, Barcode="849262",  CreatedAt= new DateTime(2015, 11, 20), CreatedBy=5, StatusId=0 },
        //        new Samples() { SampleId=70, Barcode="212969",  CreatedAt= new DateTime(2016, 02, 23), CreatedBy=1, StatusId=2 },
        //        new Samples() { SampleId=71, Barcode="913224",  CreatedAt= new DateTime(2015, 08, 17), CreatedBy=6, StatusId=3 },
        //        new Samples() { SampleId=72, Barcode="283784",  CreatedAt= new DateTime(2015, 01, 23), CreatedBy=1, StatusId=3 },
        //        new Samples() { SampleId=73, Barcode="964445",  CreatedAt= new DateTime(2015, 03, 07), CreatedBy=1, StatusId=1 },
        //        new Samples() { SampleId=74, Barcode="219254",  CreatedAt= new DateTime(2015, 06, 11), CreatedBy=7, StatusId=2 },
        //        new Samples() { SampleId=75, Barcode="136235",  CreatedAt= new DateTime(2015, 03, 21), CreatedBy=4, StatusId=3 },
        //        new Samples() { SampleId=76, Barcode="371430",  CreatedAt= new DateTime(2015, 03, 19), CreatedBy=2, StatusId=2 },
        //        new Samples() { SampleId=77, Barcode="219597",  CreatedAt= new DateTime(2015, 12, 12), CreatedBy=3, StatusId=3 },
        //        new Samples() { SampleId=78, Barcode="721655",  CreatedAt= new DateTime(2016, 04, 29), CreatedBy=5, StatusId=2 },
        //        new Samples() { SampleId=79, Barcode="434154",  CreatedAt= new DateTime(2016, 02, 25), CreatedBy=8, StatusId=0 },
        //        new Samples() { SampleId=80, Barcode="290254",  CreatedAt= new DateTime(2015, 11, 02), CreatedBy=9, StatusId=2 },
        //        new Samples() { SampleId=81, Barcode="736586",  CreatedAt= new DateTime(2015, 05, 30), CreatedBy=4, StatusId=2 },
        //        new Samples() { SampleId=82, Barcode="622526",  CreatedAt= new DateTime(2015, 11, 08), CreatedBy=0, StatusId=1 },
        //        new Samples() { SampleId=83, Barcode="693936",  CreatedAt= new DateTime(2016, 03, 21), CreatedBy=1, StatusId=0 },
        //        new Samples() { SampleId=84, Barcode="529728",  CreatedAt= new DateTime(2015, 02, 25), CreatedBy=1, StatusId=2 },
        //        new Samples() { SampleId=85, Barcode="963244",  CreatedAt= new DateTime(2015, 11, 22), CreatedBy=9, StatusId=0 },
        //        new Samples() { SampleId=86, Barcode="261164",  CreatedAt= new DateTime(2015, 06, 26), CreatedBy=9, StatusId=2 },
        //        new Samples() { SampleId=87, Barcode="986536",  CreatedAt= new DateTime(2016, 01, 07), CreatedBy=6, StatusId=1 },
        //        new Samples() { SampleId=88, Barcode="572741",  CreatedAt= new DateTime(2015, 12, 01), CreatedBy=6, StatusId=1 },
        //        new Samples() { SampleId=89, Barcode="125921",  CreatedAt= new DateTime(2015, 08, 03), CreatedBy=2, StatusId=2 },
        //        new Samples() { SampleId=90, Barcode="262858",  CreatedAt= new DateTime(2015, 12, 07), CreatedBy=3, StatusId=0 },
        //        new Samples() { SampleId=91, Barcode="879489",  CreatedAt= new DateTime(2015, 09, 02), CreatedBy=7, StatusId=1 },
        //        new Samples() { SampleId=92, Barcode="105797",  CreatedAt= new DateTime(2015, 12, 26), CreatedBy=6, StatusId=1 },
        //        new Samples() { SampleId=93, Barcode="806498",  CreatedAt= new DateTime(2015, 07, 26), CreatedBy=8, StatusId=3 },
        //        new Samples() { SampleId=94, Barcode="960686",  CreatedAt= new DateTime(2016, 04, 07), CreatedBy=2, StatusId=2 },
        //        new Samples() { SampleId=95, Barcode="201332",  CreatedAt= new DateTime(2015, 09, 19), CreatedBy=4, StatusId=0 },
        //        new Samples() { SampleId=96, Barcode="405572",  CreatedAt= new DateTime(2015, 11, 04), CreatedBy=3, StatusId=0 },
        //        new Samples() { SampleId=97, Barcode="204617",  CreatedAt= new DateTime(2015, 09, 05), CreatedBy=5, StatusId=1 },
        //        new Samples() { SampleId=98, Barcode="767548",  CreatedAt= new DateTime(2016, 02, 09), CreatedBy=7, StatusId=2 },
        //        new Samples() { SampleId=99, Barcode="363492",  CreatedAt= new DateTime(2015, 12, 18), CreatedBy=6, StatusId=1 },
        //        new Samples() { SampleId=100, Barcode="541884",  CreatedAt= new DateTime(2015, 07, 07), CreatedBy=5, StatusId=1 },
        //    };
        //}

        //private static List<Statuses> GetStatuses()
        //{
        //    return new List<Statuses>()
        //    {
        //        new Statuses() { StatusId=0, Status="Received" },
        //        new Statuses() { StatusId=1, Status="Accessioning" },
        //        new Statuses() { StatusId=2, Status="In Lab" },
        //        new Statuses() { StatusId=3, Status="Report Generation" },
        //    };
        //}


    }
}
