﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorBlog_.NetCore.Models;

namespace RazorBlog_.NetCore.Mapping
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Tb_Projects"); // name of the table 
            builder.HasKey(x => x.Id); // set the primary key 
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(); //
            builder.Property(x => x.ShortDisciption).HasMaxLength(255).IsRequired(); //
            builder.Property(x => x.PictureTitle).HasMaxLength(255); //
            builder.Property(x => x.PictureAlt).HasMaxLength(255);//
            builder.Property(x => x.Client).HasMaxLength(255);  //
            builder.Property(x => x.Image).HasMaxLength(255).IsRequired(); //

        }
    }

}