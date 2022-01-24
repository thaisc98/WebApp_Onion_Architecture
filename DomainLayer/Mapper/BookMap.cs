using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Mapper
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_BookId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("Id").HasColumnType("INT");
            builder.Property(x => x.BookName).HasColumnName("Book_Name").HasColumnType("Varchar(100)").IsRequired();
            builder.Property(x => x.AutorName).HasColumnName("Autor_Name").HasColumnType("Varchar(100)");
            builder.Property(x => x.Synopsis).HasColumnName("Synopsis").HasColumnType("Varchar(200)");
            builder.Property(x => x.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime");
            builder.Property(x => x.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime");
            builder.Property(x => x.Status).HasColumnName("Status").HasColumnType("Varchar(100)");
        }
    }
}
