using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Websockettorest.DataAccess;

namespace Websockettorest.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20170625124011_AddEvent")]
    partial class AddEvent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Websockettorest.DataAccess.Event", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("MachineId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });
        }
    }
}
