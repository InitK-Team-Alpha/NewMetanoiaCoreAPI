using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetanoiaCoreAPI.AdminUser
{


    public enum AdminRole
    {
        Admin, Editor, Viewer
    }

    public class AdminUserDTO
    {

        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public AdminRole Role { get; set; }

        internal static List<AdminUserDTO> ToList()
        {
            throw new NotImplementedException();
        }
    }

    public class AdminUserConfiguration : IEntityTypeConfiguration<AdminUserDTO>
    {
        public void Configure(EntityTypeBuilder<AdminUserDTO> builder)
        {
            builder.ToTable("admins");

            builder.HasKey(p => p.ID);

            builder.Property(p => p.UserName).HasColumnType("varchar(50)").IsRequired();

            builder.Property(p => p.Password).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Role).HasColumnType("varchar(10)").IsRequired();
        }
    }


}