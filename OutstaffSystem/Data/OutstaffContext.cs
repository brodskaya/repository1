using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OutstaffSystem.Models;

namespace OutstaffSystem.Data;

public partial class OutstaffContext : DbContext
{
    public OutstaffContext()
    {
    }

    public OutstaffContext(DbContextOptions<OutstaffContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Contractor> Contractors { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Rate> Rates { get; set; }

    public virtual DbSet<Reportperiod> Reportperiods { get; set; }

    public virtual DbSet<Specialist> Specialists { get; set; }

    public virtual DbSet<Worklog> Worklogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=outstaffdb;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("agreements_pkey");

            entity.ToTable("agreements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementdate).HasColumnName("agreementdate");
            entity.Property(e => e.Contractid).HasColumnName("contractid");

            entity.HasOne(d => d.Contract).WithMany(p => p.Agreements)
                .HasForeignKey(d => d.Contractid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("agreements_contractid_fkey");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contracts_pkey");

            entity.ToTable("contracts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contractdate).HasColumnName("contractdate");
            entity.Property(e => e.Contractnumber).HasColumnName("contractnumber");
            entity.Property(e => e.Contractorid).HasColumnName("contractorid");

            entity.HasOne(d => d.Contractor).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.Contractorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contracts_contractorid_fkey");
        });

        modelBuilder.Entity<Contractor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contractors_pkey");

            entity.ToTable("contractors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("projects_pkey");

            entity.ToTable("projects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Projectcode).HasColumnName("projectcode");
        });

        modelBuilder.Entity<Rate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rates_pkey");

            entity.ToTable("rates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(10, 2)
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Startdate).HasColumnName("startdate");

            entity.HasOne(d => d.Agreement).WithMany(p => p.Rates)
                .HasForeignKey(d => d.Agreementid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rates_agreementid_fkey");
        });

        modelBuilder.Entity<Reportperiod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reportperiods_pkey");

            entity.ToTable("reportperiods");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
        });

        modelBuilder.Entity<Specialist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("specialists_pkey");

            entity.ToTable("specialists");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contractorid).HasColumnName("contractorid");
            entity.Property(e => e.Currentrateid).HasColumnName("currentrateid");
            entity.Property(e => e.Employmenttype).HasColumnName("employmenttype");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Workagreementend).HasColumnName("workagreementend");

            entity.HasOne(d => d.Contractor).WithMany(p => p.Specialists)
                .HasForeignKey(d => d.Contractorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("specialists_contractorid_fkey");

            entity.HasOne(d => d.Currentrate).WithMany(p => p.Specialists)
                .HasForeignKey(d => d.Currentrateid)
                .HasConstraintName("specialists_currentrateid_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.Specialists)
                .HasForeignKey(d => d.Projectid)
                .HasConstraintName("specialists_projectid_fkey");
        });

        modelBuilder.Entity<Worklog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("worklogs_pkey");

            entity.ToTable("worklogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hoursworked)
                .HasPrecision(5, 2)
                .HasColumnName("hoursworked");
            entity.Property(e => e.Specialistid).HasColumnName("specialistid");
            entity.Property(e => e.Taskdescription).HasColumnName("taskdescription");
            entity.Property(e => e.Workdate).HasColumnName("workdate");

            entity.HasOne(d => d.Specialist).WithMany(p => p.Worklogs)
                .HasForeignKey(d => d.Specialistid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("worklogs_specialistid_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
