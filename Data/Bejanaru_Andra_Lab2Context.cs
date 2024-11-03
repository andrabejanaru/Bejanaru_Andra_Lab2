using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bejanaru_Andra_Lab2.Models;

namespace Bejanaru_Andra_Lab2.Data
{
    public class Bejanaru_Andra_Lab2Context : DbContext
    {
        public Bejanaru_Andra_Lab2Context (DbContextOptions<Bejanaru_Andra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bejanaru_Andra_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bejanaru_Andra_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
