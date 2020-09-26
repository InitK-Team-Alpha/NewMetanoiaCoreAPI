using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetanoiaCoreAPI.AppUser
{

    public enum AppUserGender
    {
        Male, Female, Gay, Bisexaul, Lesbian, Transgender, Queer, Pansexual
    }

    public enum AppUserRelationshipStatus
    {
        Single, Relationship, Married, Divorce
    }
    public class AppUserDTO
    {
        public int ID { get; set; }

        public int PsychologyCausesID {get; set;}

        public UserPsychologyCauses PsychologyCauses {get; set;}

        public int PsychologyEffectsID {get; set;}
        public UserPsychologyEffects PsychologyEffects{get; set;}
        public string UserName { get; set; }

        public string Password { get; set; }


        public int Age { get; set; }

        public AppUserGender Gender { get; set; }

        public string JobRole { get; set; }

        public AppUserRelationshipStatus RelationshipStatus { get; set; }

        //public List<string> Hobbies { get; set; }

        public string Religion {get;set;}

       // public DateTime CreatedDate {get;set;}




    }

    public class AppUserConfiguration : IEntityTypeConfiguration<AppUserDTO>
    {
        public void Configure(EntityTypeBuilder<AppUserDTO> builder)
        {
            builder.ToTable("appuser");

            builder.HasKey(p => p.ID);
            builder.HasOne(p => p.PsychologyCauses);
            builder.HasOne(p => p.PsychologyEffects);
            builder.Property(p => p.UserName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Password).HasColumnType("varchar(30)").IsRequired();
            builder.Property(p => p.Age).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.Gender).HasColumnType("varchar(12)").IsRequired();
            builder.Property(p => p.JobRole).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.RelationshipStatus).HasColumnType("varchar(14)").IsRequired();
            //builder.Property(p => p.Hobbies).HasColumnName("text[]").IsRequired();
            builder.Property(p => p.Religion).HasColumnName("varchar(30)").IsRequired();

            //builder.Property(p => p.CreatedDate).HasColumnType("date").HasDefaultValueSql("GETDATE()");


        }
    }


}