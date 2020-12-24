using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KombniyApp.Core;

namespace KombiyApp.Data
{
	class UserConfig : IEntityTypeConfiguration<User>
	{
		public UserConfig()
		{

		}

		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder
				   .HasKey(a => a.UserId);

			builder
				.Property(m => m.UserId)
				.IsRequired();

			builder
				.Property(m => m.Name)
				.IsRequired()
				.HasMaxLength(50);

			builder
				.HasOne("Users");
				//.ToTable("User");

		}
	}
}
