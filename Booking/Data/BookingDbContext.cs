using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Models;

namespace Booking.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext (DbContextOptions<BookingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Booking.Models.Book> Book { get; set; } = default!;
    }
}
