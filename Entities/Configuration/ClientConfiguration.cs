using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData
            (
            new Client
            {
                Id = 1,
                Name = "Петров Пётр Петрович",
                Address = "ул Пушкина"
            },
            new Client
            {
                Id = 2,
                Name = "Снигёрев Сергей Сергеевич",
                Address = "ул Колотушкина"
            }
            );
        }
    }
}
