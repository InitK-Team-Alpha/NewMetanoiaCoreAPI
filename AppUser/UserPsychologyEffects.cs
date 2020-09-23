using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetanoiaCoreAPI.AppUser
{
        public class UserPsychologyEffects
    {
        public int ID {get;set;}

        

        public bool SleepProblem {get;set;}

        public bool LossofAppetite {get; set;}

        public bool WeightLossORWeightGain {get; set;}

        public bool FocusProblem {get; set;}

        public bool AngerProblem {get; set;}
        
        public bool ConstantWorry {get;set;}

        public bool LonelinessORIsolation {get; set;}

        public bool FeelingOverWhelmed {get; set;}

        public bool Unhappiness {get; set;}

        public bool SuicidalThoughts {get;set;}

        public bool NoJoy {get; set;}

        public bool FeelingSadORDown {get;set;}

        public bool OveruseOfAlcholAndDrugs {get;set;}

        public bool WithdrawFromFriendsORActivities {get; set;}

        public bool SexDriveChange {get;set;}

        public bool MoodSwing {get; set;}

    }


     public class UserPsychologyEffectsConfiguration : IEntityTypeConfiguration<UserPsychologyEffects>
    {
        public void Configure(EntityTypeBuilder<UserPsychologyEffects> builder)
        {
            builder.ToTable("appuser");

            builder.HasKey(p => p.ID);
            builder.Property(p => p.SleepProblem).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.LossofAppetite).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.WeightLossORWeightGain).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.FocusProblem).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.AngerProblem).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.ConstantWorry).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.LonelinessORIsolation).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.FeelingOverWhelmed).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.Unhappiness).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.SuicidalThoughts).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.NoJoy).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.FeelingSadORDown).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.OveruseOfAlcholAndDrugs).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.WithdrawFromFriendsORActivities).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.SexDriveChange).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.MoodSwing).HasColumnType("varchar(10)").IsRequired();
            
        }
    }
}