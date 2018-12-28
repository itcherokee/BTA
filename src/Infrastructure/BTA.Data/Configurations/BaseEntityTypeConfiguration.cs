namespace BTA.Data.Configurations
{
    using System;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T>
        where T : class
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property<bool>("IsDeleted")
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property<DateTime>("CreatedOn")
                .IsRequired()
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("UpdatedOn")
                .IsRequired()
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .ValueGeneratedOnAdd();
        }
    }
}