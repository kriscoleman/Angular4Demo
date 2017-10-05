using System.Collections.Generic;
using ComicBookStoreAPI.Models;

namespace ComicBookStoreAPI.Logic
{
    /// <summary>
    /// The Comic Logic.
    /// Normally this would probably be interfaced out and pulled in via DI.  
    /// </summary>
    public class ComicLogic
    {
        /// <summary>
        /// Gets the comics. (The current store inventory)
        /// </summary>
        /// <returns></returns>
        public List<Comic> GetComics() => new List<Comic>
        {
            // spider-man
            new Comic
            {
                Id = 1,
                Title = "The Amazing Spider-Man",
                Cost = 5.99m,
                Issue = 54,
                Publisher = "Marvel",
                Quantity = 4
            },
            new Comic
            {
                Id = 2,
                Title = "The Amazing Spider-Man",
                Cost = 7.99m,
                Issue = 32,
                Publisher = "Marvel",
                Quantity = 2
            },
            new Comic
            {
                Id = 3,
                Title = "Spider-Man",
                Cost = 4.99m,
                Issue = 115,
                Publisher = "Marvel",
                Quantity = 7
            },
            // batman 
            new Comic
            {
                Id = 4,
                Title = "Batman",
                Cost = 15.99m,
                Issue = 68,
                Publisher = "DC",
                Quantity = 7
            },
            new Comic
            {
                Id = 5,
                Title = "Batman",
                Cost = 5.99m,
                Issue = 315,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 6,
                Title = "Batman",
                Cost = 5.99m,
                Issue = 315,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 7,
                Title = "Batman",
                Cost = 8.99m,
                Issue = 415,
                Publisher = "DC",
                Quantity = 14
            },
            // superman
            new Comic
            {
                Id = 8,
                Title = "Superman",
                Cost = 15.99m,
                Issue = 48,
                Publisher = "DC",
                Quantity = 7
            },
            new Comic
            {
                Id = 9,
                Title = "Superman",
                Cost = 4.99m,
                Issue = 315,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 10,
                Title = "Superman",
                Cost = 6.99m,
                Issue = 211,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 11,
                Title = "Superman",
                Cost = 4.99m,
                Issue = 336,
                Publisher = "DC",
                Quantity = 14
            },
            // lobo
            new Comic
            {
                Id = 12,
                Title = "Lobo",
                Cost = 15.99m,
                Issue = 48,
                Publisher = "DC",
                Quantity = 7
            },
            new Comic
            {
                Id = 13,
                Title = "Lobo",
                Cost = 4.99m,
                Issue = 315,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 14,
                Title = "Lobo",
                Cost = 6.99m,
                Issue = 211,
                Publisher = "DC",
                Quantity = 14
            },
            new Comic
            {
                Id = 15,
                Title = "Lobo",
                Cost = 4.99m,
                Issue = 336,
                Publisher = "DC",
                Quantity = 14
            },

            // spawn
            new Comic
            {
                Id = 16,
                Title = "Spawn",
                Cost = 15.99m,
                Issue = 48,
                Publisher = "Image",
                Quantity = 7
            },
            new Comic
            {
                Id = 17,
                Title = "Spawn",
                Cost = 4.99m,
                Issue = 15,
                Publisher = "Image",
                Quantity = 14
            },
            new Comic
            {
                Id = 18,
                Title = "Spawn",
                Cost = 6.99m,
                Issue = 11,
                Publisher = "Image",
                Quantity = 14
            },
            new Comic
            {
                Id = 19,
                Title = "Spawn",
                Cost = 4.99m,
                Issue = 36,
                Publisher = "Image",
                Quantity = 14
            },
        };
    }
}