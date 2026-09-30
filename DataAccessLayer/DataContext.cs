using DataAccessLayer.Persistence;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    /// <summary>
    /// EF-контекст
    /// </summary>
    public class DataContext : DbContext
    {
        private readonly string connectionString;

        /// <summary> Справочник серий. </summary>
        internal DbSet<SeriesRow> Series { get; set; } = null!;

        /// <summary> Справочник типов. </summary>
        internal DbSet<TypeRow> Types { get; set; } = null!;

        /// <summary> Справочник критериев (1..10). </summary>
        internal DbSet<CriterionRow> Criteria { get; set; } = null!;

        /// <summary> Основная таблица роботов. </summary>
        internal DbSet<RobotRow> Robots { get; set; } = null!;

        /// <summary> Nаблица связи роботов и критериев. </summary>
        internal DbSet<RobotCriterionRow> RobotCriteria { get; set; } = null!;

        /// <summary>
        /// Создаёт контекст с указанной строкой подключения.
        /// При первом обращении создаёт БД и таблицы EnsureCreated.
        /// </summary>
        /// <param name="connectionString"> Строка подключения к SQL Server. </param>
        /// <exception cref="ArgumentNullException"> Если строка подключения null. </exception>
        public DataContext(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));

            Database.EnsureCreated();
        }

        /// <summary>
        /// Конфигурирует провайдер SQL Server.
        /// </summary>
        /// <param name="optionsBuilder">  </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(connectionString);

        /// <summary>
        /// Описывает схему: таблицы, ключи, FK, уникальные индексы,
        /// Cвязь и сидирование справочника критериев из CriteriaLegend
        /// </summary>
        /// <param name="mb"> Модель </param>
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // ---------- Series ----------
            mb.Entity<SeriesRow>(e =>
            {
                e.ToTable("Series");
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.HasIndex(x => x.Name).IsUnique();
            });

            // ---------- Types ----------
            mb.Entity<TypeRow>(e =>
            {
                e.ToTable("Types");
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.HasIndex(x => x.Name).IsUnique();
            });

            // ---------- Criteria (справочник 1..10) ----------
            mb.Entity<CriterionRow>(e =>
            {
                e.ToTable("Criteria");
                e.HasKey(x => x.Code);
                e.Property(x => x.Description).IsRequired().HasMaxLength(500);
            });

            // ---------- Robots ----------
            mb.Entity<RobotRow>(e =>
            {
                e.ToTable("Robots");
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(200);
                e.Property(x => x.Goal).HasMaxLength(2000);
                e.Property(x => x.Details).HasMaxLength(2000);
                e.Property(x => x.Appearance).HasMaxLength(2000);
                e.Property(x => x.PriceRub).HasColumnType("decimal(18,2)");

                e.HasOne(x => x.Series).WithMany()
                    .HasForeignKey(x => x.SeriesId)
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Type).WithMany()
                    .HasForeignKey(x => x.TypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ---------- RobotCriteria (M:N) ----------
            mb.Entity<RobotCriterionRow>(e =>
            {
                e.ToTable("RobotCriteria");
                e.HasKey(x => new { x.RobotId, x.CriterionCode });

                e.HasOne(x => x.Robot).WithMany(r => r.Criteria)
                    .HasForeignKey(x => x.RobotId)
                    .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(x => x.Criterion).WithMany()
                    .HasForeignKey(x => x.CriterionCode)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ---------- Сидирование Criteria из Model.CriteriaLegend ----------
            mb.Entity<CriterionRow>().HasData(
                CriteriaLegend.Legend
                    .Select(kv => new CriterionRow { Code = kv.Key, Description = kv.Value })
                    .ToArray());
        }
    }
}
