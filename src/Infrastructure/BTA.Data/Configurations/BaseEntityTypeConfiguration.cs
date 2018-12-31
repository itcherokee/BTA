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
            builder.Property<string>("CreatedBy")
                .IsRequired();
            builder.Property<DateTime>("UpdatedOn")
                .IsRequired()
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .ValueGeneratedOnAdd();
            builder.Property<string>("UpdatedBy")
                .IsRequired();
            //TODO: Add authenticated user that is changing the fields. Decide which value to use: ApplicationUserId or employeeId? https://stackoverflow.com/questions/48554480/ef-core-get-authenticated-username-in-shadow-properties or https://stackoverflow.com/questions/52900865/how-do-i-get-the-current-logged-in-user-id-in-the-applicationdbcontext-using-ide or simply pass the registered user value as additioanl parameter to each Repository's method and store it it DbContext property which than is saved in DB via SaveChanges()?!?!
        }
    }
}