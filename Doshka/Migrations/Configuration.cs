using Doshka.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Doshka.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Doshka.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Doshka.Models.ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(new IdentityRole()
            {
                Id = "Admin",
                Name = "Admin"
            });

            context.Categories.AddOrUpdate(new Category()
            {
                CategoryId = 1,
                Name = "All categories"
            }, new Category()
            {
                CategoryId = 2,
                Name = "Fashion & Style"
            }, new Category()
            {
                CategoryId = 3,
                Name = "Housing"
            }, new Category()
            {
                CategoryId = 4,
                Name = "Realty"
            }, new Category()
            {
                CategoryId = 5,
                Name = "All for moms & babies"
            }, new Category()
            {
                CategoryId = 6,
                Name = "Auto & transport"
            }, new Category()
            {
                CategoryId = 7,
                Name = "Hobbies, sports & tourism"
            }, new Category()
            {
                CategoryId = 8,
                Name = "Repair and construction"
            }, new Category()
            {
                CategoryId = 9,
                Name = "Electronics"
            }, new Category()
            {
                CategoryId = 10,
                Name = "Garden"
            }, new Category()
            {
                CategoryId = 11,
                Name = "Entertainment & Wedding"
            }, new Category()
            {
                CategoryId = 12,
                Name = "Work, business and study"
            }, new Category()
            {
                CategoryId = 13,
                Name = "Service"
            });

            context.SubCategories.AddOrUpdate(new SubCategory()
            {
                SubCategoryId = 1,                    
                Name = "All subcategories",           
                CategoryId = 1                          //No category
            }, new SubCategory()
            {
                SubCategoryId = 2,                    
                Name = "Men's Clothing",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 3,
                Name = "Women's clothing",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 4,
                Name = "Men's shoes",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 5,
                Name = "Women's shoes",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 6,
                Name = "Accessories and watches",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 7,
                Name = "Cosmetics and perfumery",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 8,
                Name = "Repair of clothes, sewing, dry cleaning",
                CategoryId = 1
            }, new SubCategory()
            {
                SubCategoryId = 9,
                Name = "Clothes for pregnant women",
                CategoryId = 1
                //----------------------------------------------Housing--------------------------
            }, new SubCategory()
            {
                SubCategoryId = 10,
                Name = "Furniture and interior",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 11,
                Name = "Household goods",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 12,
                Name = "Crockery and cutlery",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 13,
                Name = "Houseplants",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 14,
                Name = "Appliances",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 15,
                Name = "Domestic services",
                CategoryId = 2
            }, new SubCategory()
            {
                SubCategoryId = 16,
                Name = "Repair of furniture",
                CategoryId = 2
                //----------------------------------------------Realty-----------------------------------
            }, new SubCategory()
            {
                SubCategoryId = 17,
                Name = "Apartments",
                CategoryId = 3
            }, new SubCategory()
            {
                SubCategoryId = 18,
                Name = "Rooms",
                CategoryId = 3
            }, new SubCategory()
            {
                SubCategoryId = 19,
                Name = "Houses, cottages, cottages",
                CategoryId = 3
            }, new SubCategory()
            {
                SubCategoryId = 20,
                Name = "Garages and parking",
                CategoryId = 3
                //--------------------------------------------All for moms & babies------------------------------
                /*Clothes up to 1 year old
Clothing for girls
Clothes for boys
Cribs, playpen, stools
Walkers, chaise lounges, swings
Carriages
Feeding and care
Toys and books
Goods for moms
Clothes for pregnant women*/
            }, new SubCategory()
            {
                SubCategoryId = 21,
                Name = "Clothes up to 1 year old",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 22,
                Name = "Clothing for girls",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 23,
                Name = "Clothes for boys",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 24,
                Name = "Cribs, playpen, stools",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 25,
                Name = "Walkers, chaise lounges, swings",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 26,
                Name = "Carriages",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 27,
                Name = "Feeding and care",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 28,
                Name = "Toys and books",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 29,
                Name = "Goods for moms",
                CategoryId = 4
            }, new SubCategory()
            {
                SubCategoryId = 30,
                Name = "Clothes for pregnant women",
                CategoryId = 4
                //--------------------------------------------------Auto & transport---------------
            }, new SubCategory()
            {
                SubCategoryId = 31,
                Name = "Cars",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 32,
                Name = "Trucks and buses",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 33,
                Name = "Motorcycles and Motorcycles",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 34,
                Name = "Tractors and agricultural machinery",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 35,
                Name = "Special machinery",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 36,
                Name = "Trailers and semitrailers",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 37,
                Name = "Water transport",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 38,
                Name = "Car Seats and Boosters",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 39,
                Name = "Tires and wheels",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 40,
                Name = "Spare parts, consumables, chemistry",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 41,
                Name = "Other for cars and vehicles",
                CategoryId = 5
            }, new SubCategory()
            {
                SubCategoryId = 42,
                Name = "Accessories",
                CategoryId = 5
                //------------------------------------------------Hobbies, sports & tourism-------------------
            }, new SubCategory()
            {
                SubCategoryId = 43,
                Name = "CD, DVD, records",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 44,
                Name = "Antiques and Collections",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 45,
                Name = "Books and magazines",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 46,
                Name = "Musical instruments",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 47,
                Name = "Hunting and fishing",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 48,
                Name = "Tourist goods",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 49,
                Name = "Needlework",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 50,
                Name = "Sports goods",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 51,
                Name = "Bicycles",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 52,
                Name = "Tourist services",
                CategoryId = 6
            }, new SubCategory()
            {
                SubCategoryId = 53,
                Name = "Other hobbies, sports and tourism",
                CategoryId = 6
                //-----------------------------------------------Repair and construction-------------------------
            }, new SubCategory()
            {
                SubCategoryId = 54,
                Name = "Building tools",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 55,
                Name = "Plumbing",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 56,
                Name = "Building materials",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 57,
                Name = "Decoration Materials",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 58,
                Name = "Windows and doors",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 59,
                Name = "Other for repair and construction",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 60,
                Name = "Services in construction and repair",
                CategoryId = 7
                //---------------------------------------------------------Electronics------------------------
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Audio equipment",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Computers and accessories",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "TV and video equipment",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Photography and optics",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Games and consoles",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Phones",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Office equipment",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Tablets and e-books",
                CategoryId = 7
            }, new SubCategory()
            {
                SubCategoryId = 61,
                Name = "Appliances",
                CategoryId = 7
                //---------------------------------------------------------Garden---------------------------
            }, new SubCategory()
            {
                SubCategoryId = 63,
                Name = "Garden furniture and barbecues",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 64,
                Name = "Garden plants, seedlings and seeds",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 65,
                Name = "Gardening equipment and tools",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 66,
                Name = "Greenhouses",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 67,
                Name = "Garden Accessories",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 68,
                Name = "Fertilizers and agrochemistry",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 69,
                Name = "Everything for the beekeeper",
                CategoryId = 8
            }, new SubCategory()
            {
                SubCategoryId = 70,
                Name = "Other for the garden",
                CategoryId = 8
                //----------------------------------------------------------Wedding-----------------------
            }, new SubCategory()
            {
                SubCategoryId = 71,
                Name = "Wedding Dresses",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 72,
                Name = "Wedding Costumes",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 73,
                Name = "Wedding shoes",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 74,
                Name = "Wedding accessories",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 75,
                Name = "Gifts and Holiday Goods",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 76,
                Name = "Carnival costumes",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 77,
                Name = "Services for celebrations",
                CategoryId = 9
                //------------------------------------------------------Work, business and study--------------
            }, new SubCategory()
            {
                SubCategoryId = 78,
                Name = "Careers",
                CategoryId = 10
            }, new SubCategory()
            {
                SubCategoryId = 79,
                Name = "Workmanship",
                CategoryId = 10
            }, new SubCategory()
            {
                SubCategoryId = 80,
                Name = "Machines and equipment",
                CategoryId = 10
            }, new SubCategory()
            {
                SubCategoryId = 81,
                Name = "Education",
                CategoryId = 10
            }, new SubCategory()
            {
                SubCategoryId = 82,
                Name = "Stationery",
                CategoryId = 9
            }, new SubCategory()
            {
                SubCategoryId = 83,
                Name = "School Costumes",
                CategoryId = 10
            }, new SubCategory()
            {
                SubCategoryId = 84,
                Name = "Appliances",
                CategoryId = 11
            });
        }
    }
}
