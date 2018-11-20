using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReadMyLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadMyLife.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ReadMyLifeContext(
                serviceProvider.GetRequiredService<DbContextOptions<ReadMyLifeContext>>()))
            {
                // Look for any movies.
                if (context.StoryItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.StoryItem.AddRange(
                    new StoryItem
                    {
                        StoryID = 1,
                        Title = "I like dogs",
                        AuthorName = "Dinith Wannigama",
                        AuthorID = "dinithwannigama",
                        Description = "A story about a dog",
                        Contents = "The quick brown fox jumped over the lazy dog. The dog then chased the fox.",
                        Rating = "5",
                        NumRatings = 1,
                        Tag = "funny",
                        Date = "07-10-18 4:20T18:25:43.511Z",
                        ImageURL = "https://i.kym-cdn.com/photos/images/original/001/371/723/be6.jpg"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}