using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace S2CDataMigration.Models
{
    public partial class gentuContext : DbContext, IGentuContext
    {
        public gentuContext()
        {
        }

        public gentuContext(DbContextOptions<gentuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessEvents> AccessEvents { get; set; }
        public virtual DbSet<AccountVersions> AccountVersions { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsPatients> AccountsPatients { get; set; }
        public virtual DbSet<AddressVersions> AddressVersions { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AdminNoteVersions> AdminNoteVersions { get; set; }
        public virtual DbSet<AdminNotes> AdminNotes { get; set; }
        public virtual DbSet<AdverseReactionVersions> AdverseReactionVersions { get; set; }
        public virtual DbSet<AdverseReactions> AdverseReactions { get; set; }
        public virtual DbSet<AmaFeeVersions> AmaFeeVersions { get; set; }
        public virtual DbSet<AmaFees> AmaFees { get; set; }
        public virtual DbSet<AmaImportVersions> AmaImportVersions { get; set; }
        public virtual DbSet<AmaImports> AmaImports { get; set; }
        public virtual DbSet<AppErrors> AppErrors { get; set; }
        public virtual DbSet<AppointmentTypes> AppointmentTypes { get; set; }
        public virtual DbSet<ArInternalMetadata> ArInternalMetadata { get; set; }
        public virtual DbSet<AuthorityPrescriptionNumberGenerators> AuthorityPrescriptionNumberGenerators { get; set; }
        public virtual DbSet<BillingItems> BillingItems { get; set; }
        public virtual DbSet<BillingItemsProcedures> BillingItemsProcedures { get; set; }
        public virtual DbSet<BillingSetItems> BillingSetItems { get; set; }
        public virtual DbSet<BillingSets> BillingSets { get; set; }
        public virtual DbSet<CardVersions> CardVersions { get; set; }
        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<ClaimInvoiceNoteVersions> ClaimInvoiceNoteVersions { get; set; }
        public virtual DbSet<ClaimInvoiceNotes> ClaimInvoiceNotes { get; set; }
        public virtual DbSet<ClaimVersions> ClaimVersions { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<ClaimsInvoices> ClaimsInvoices { get; set; }
        public virtual DbSet<ClinicalHistoryAttributes> ClinicalHistoryAttributes { get; set; }
        public virtual DbSet<ClinicalInteractionSettingVersions> ClinicalInteractionSettingVersions { get; set; }
        public virtual DbSet<ClinicalInteractionSettings> ClinicalInteractionSettings { get; set; }
        public virtual DbSet<CommonPasswords> CommonPasswords { get; set; }
        public virtual DbSet<ConsultNoteVersions> ConsultNoteVersions { get; set; }
        public virtual DbSet<ConsultNotes> ConsultNotes { get; set; }
        public virtual DbSet<ContactVersions> ContactVersions { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<CustomMedicationVersions> CustomMedicationVersions { get; set; }
        public virtual DbSet<CustomMedications> CustomMedications { get; set; }
        public virtual DbSet<Diagnoses> Diagnoses { get; set; }
        public virtual DbSet<DiagnosisVersions> DiagnosisVersions { get; set; }
        public virtual DbSet<DiagnosticRequestCcs> DiagnosticRequestCcs { get; set; }
        public virtual DbSet<DiagnosticRequestVersions> DiagnosticRequestVersions { get; set; }
        public virtual DbSet<DiagnosticRequests> DiagnosticRequests { get; set; }
        public virtual DbSet<DocumentContents> DocumentContents { get; set; }
        public virtual DbSet<DocumentVersions> DocumentVersions { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DvaFeeVersions> DvaFeeVersions { get; set; }
        public virtual DbSet<DvaFees> DvaFees { get; set; }
        public virtual DbSet<DvaImportVersions> DvaImportVersions { get; set; }
        public virtual DbSet<DvaImports> DvaImports { get; set; }
        public virtual DbSet<EmergencyContactVersions> EmergencyContactVersions { get; set; }
        public virtual DbSet<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual DbSet<EventVersions> EventVersions { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<FeeSchedules> FeeSchedules { get; set; }
        public virtual DbSet<FeeSetImports> FeeSetImports { get; set; }
        public virtual DbSet<FeeSets> FeeSets { get; set; }
        public virtual DbSet<Fees> Fees { get; set; }
        public virtual DbSet<FlagVersions> FlagVersions { get; set; }
        public virtual DbSet<Flags> Flags { get; set; }
        public virtual DbSet<GenieSpecialties> GenieSpecialties { get; set; }
        public virtual DbSet<HealthFundDetails> HealthFundDetails { get; set; }
        public virtual DbSet<HealthFundFeeVersions> HealthFundFeeVersions { get; set; }
        public virtual DbSet<HealthFundFees> HealthFundFees { get; set; }
        public virtual DbSet<HealthFundImportVersions> HealthFundImportVersions { get; set; }
        public virtual DbSet<HealthFundImports> HealthFundImports { get; set; }
        public virtual DbSet<HealthFundScheduleVersions> HealthFundScheduleVersions { get; set; }
        public virtual DbSet<HealthFundSchedules> HealthFundSchedules { get; set; }
        public virtual DbSet<HealthFundVersions> HealthFundVersions { get; set; }
        public virtual DbSet<HealthFunds> HealthFunds { get; set; }
        public virtual DbSet<HealthTeamMemberVersions> HealthTeamMemberVersions { get; set; }
        public virtual DbSet<HealthTeamMembers> HealthTeamMembers { get; set; }
        public virtual DbSet<Identifiers> Identifiers { get; set; }
        public virtual DbSet<IdentifiersVersions> IdentifiersVersions { get; set; }
        public virtual DbSet<InvoiceItemTxns> InvoiceItemTxns { get; set; }
        public virtual DbSet<InvoiceItemVersions> InvoiceItemVersions { get; set; }
        public virtual DbSet<InvoiceItems> InvoiceItems { get; set; }
        public virtual DbSet<InvoiceableVersions> InvoiceableVersions { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<LetterImages> LetterImages { get; set; }
        public virtual DbSet<LetterVersions> LetterVersions { get; set; }
        public virtual DbSet<Letters> Letters { get; set; }
        public virtual DbSet<MbsFeeVersions> MbsFeeVersions { get; set; }
        public virtual DbSet<MbsFees> MbsFees { get; set; }
        public virtual DbSet<MbsImportVersions> MbsImportVersions { get; set; }
        public virtual DbSet<MbsImports> MbsImports { get; set; }
        public virtual DbSet<MedicationVersions> MedicationVersions { get; set; }
        public virtual DbSet<Medications> Medications { get; set; }
        public virtual DbSet<ObstetricsAntenatalVisitVersions> ObstetricsAntenatalVisitVersions { get; set; }
        public virtual DbSet<ObstetricsAntenatalVisits> ObstetricsAntenatalVisits { get; set; }
        public virtual DbSet<ObstetricsChildVersions> ObstetricsChildVersions { get; set; }
        public virtual DbSet<ObstetricsChildren> ObstetricsChildren { get; set; }
        public virtual DbSet<ObstetricsInvestigationVersions> ObstetricsInvestigationVersions { get; set; }
        public virtual DbSet<ObstetricsInvestigations> ObstetricsInvestigations { get; set; }
        public virtual DbSet<ObstetricsObservationVersions> ObstetricsObservationVersions { get; set; }
        public virtual DbSet<ObstetricsObservations> ObstetricsObservations { get; set; }
        public virtual DbSet<ObstetricsPostnatalVisitVersions> ObstetricsPostnatalVisitVersions { get; set; }
        public virtual DbSet<ObstetricsPostnatalVisits> ObstetricsPostnatalVisits { get; set; }
        public virtual DbSet<ObstetricsPregnancies> ObstetricsPregnancies { get; set; }
        public virtual DbSet<ObstetricsPregnancyVersions> ObstetricsPregnancyVersions { get; set; }
        public virtual DbSet<PastProcedureVersions> PastProcedureVersions { get; set; }
        public virtual DbSet<PastProcedures> PastProcedures { get; set; }
        public virtual DbSet<PatientReportLinkVersions> PatientReportLinkVersions { get; set; }
        public virtual DbSet<PatientReportLinks> PatientReportLinks { get; set; }
        public virtual DbSet<PatientVersions> PatientVersions { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<PracticeVersions> PracticeVersions { get; set; }
        public virtual DbSet<Practices> Practices { get; set; }
        public virtual DbSet<PracticesSpecialties> PracticesSpecialties { get; set; }
        public virtual DbSet<Preferences> Preferences { get; set; }
        public virtual DbSet<PrescriptionAuthorities> PrescriptionAuthorities { get; set; }
        public virtual DbSet<PrescriptionAuthorityVersions> PrescriptionAuthorityVersions { get; set; }
        public virtual DbSet<PrescriptionMedications> PrescriptionMedications { get; set; }
        public virtual DbSet<PrescriptionVersions> PrescriptionVersions { get; set; }
        public virtual DbSet<Prescriptions> Prescriptions { get; set; }
        public virtual DbSet<PrintTemplates> PrintTemplates { get; set; }
        public virtual DbSet<PrivateMbsFeeVersions> PrivateMbsFeeVersions { get; set; }
        public virtual DbSet<PrivateMbsFees> PrivateMbsFees { get; set; }
        public virtual DbSet<ProcedureCategories> ProcedureCategories { get; set; }
        public virtual DbSet<ProcedureReferenceVersions> ProcedureReferenceVersions { get; set; }
        public virtual DbSet<ProcedureReferences> ProcedureReferences { get; set; }
        public virtual DbSet<ProcedureVersions> ProcedureVersions { get; set; }
        public virtual DbSet<Procedures> Procedures { get; set; }
        public virtual DbSet<ReasonsForEncounter> ReasonsForEncounter { get; set; }
        public virtual DbSet<RecallVersions> RecallVersions { get; set; }
        public virtual DbSet<RecipientVersions> RecipientVersions { get; set; }
        public virtual DbSet<Recipients> Recipients { get; set; }
        public virtual DbSet<ReferralVersions> ReferralVersions { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<ReportLinkSuggestions> ReportLinkSuggestions { get; set; }
        public virtual DbSet<RequestLabProviders> RequestLabProviders { get; set; }
        public virtual DbSet<RequestLabs> RequestLabs { get; set; }
        public virtual DbSet<RolePermissionVersions> RolePermissionVersions { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SchemaMigrations> SchemaMigrations { get; set; }
        public virtual DbSet<ScreeningInteractions> ScreeningInteractions { get; set; }
        public virtual DbSet<ScreeningOverrideReasons> ScreeningOverrideReasons { get; set; }
        public virtual DbSet<ScreeningOverrides> ScreeningOverrides { get; set; }
        public virtual DbSet<ServiceVersions> ServiceVersions { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<SiteOfServiceVersions> SiteOfServiceVersions { get; set; }
        public virtual DbSet<SitesOfService> SitesOfService { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<TermsAcceptances> TermsAcceptances { get; set; }
        public virtual DbSet<TermsAndConditions> TermsAndConditions { get; set; }
        public virtual DbSet<ThirdPartyClaimVersions> ThirdPartyClaimVersions { get; set; }
        public virtual DbSet<ThirdPartyClaims> ThirdPartyClaims { get; set; }
        public virtual DbSet<ToDoCommentVersions> ToDoCommentVersions { get; set; }
        public virtual DbSet<ToDoComments> ToDoComments { get; set; }
        public virtual DbSet<ToDoVersions> ToDoVersions { get; set; }
        public virtual DbSet<ToDos> ToDos { get; set; }
        public virtual DbSet<Txns> Txns { get; set; }
        public virtual DbSet<UserVersions> UserVersions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersToDos> UsersToDos { get; set; }
        public virtual DbSet<VoucherVersions> VoucherVersions { get; set; }
        public virtual DbSet<Vouchers> Vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=32768;Database=gentu;Username=gentu_dev;Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("citext")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("uuid-ossp")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccessEvents>(entity =>
            {
                entity.ToTable("access_events");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Env)
                    .IsRequired()
                    .HasColumnName("env")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnName("params")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AccountVersions>(entity =>
            {
                entity.ToTable("account_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_account_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_account_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_account_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.AccountId)
                    .HasName("index_accounts_on_account_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_accounts_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_accounts_on_practice_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_accounts_on_type");

                entity.HasIndex(e => new { e.HolderType, e.HolderId })
                    .HasName("index_accounts_on_holder_type_and_holder_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.HolderId).HasColumnName("holder_id");

                entity.Property(e => e.HolderType)
                    .IsRequired()
                    .HasColumnName("holder_type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'Patient'::character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'Account'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.InverseAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fk_rails_39abb34b68");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_bb1befa454");
            });

            modelBuilder.Entity<AccountsPatients>(entity =>
            {
                entity.ToTable("accounts_patients");

                entity.HasIndex(e => e.AccountId)
                    .HasName("index_accounts_patients_on_account_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_accounts_patients_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_accounts_patients_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_accounts_patients_on_practice_id");

                entity.HasIndex(e => new { e.PatientId, e.AccountId })
                    .HasName("index_accounts_patients_on_patient_id_and_account_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.HasIndex(e => new { e.Primary, e.PatientId })
                    .HasName("index_accounts_patients_on_primary_and_patient_id")
                    .IsUnique()
                    .HasFilter("((\"primary\" = true) AND (deleted_at IS NULL))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Primary).HasColumnName("primary");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsPatients)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ee91743563");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AccountsPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_98eded4653");
            });

            modelBuilder.Entity<AddressVersions>(entity =>
            {
                entity.ToTable("address_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_address_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_address_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_address_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_addresses_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_addresses_on_practice_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("index_addresses_on_state_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Street1)
                    .HasColumnName("street_1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Street2)
                    .HasColumnName("street_2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Suburb)
                    .HasColumnName("suburb")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_84528778ae");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("fk_rails_2d87b6c11e");
            });

            modelBuilder.Entity<AdminNoteVersions>(entity =>
            {
                entity.ToTable("admin_note_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_admin_note_versions_on_item_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_admin_note_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_admin_note_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_admin_note_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AdminNotes>(entity =>
            {
                entity.ToTable("admin_notes");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_admin_notes_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_admin_notes_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_admin_notes_on_practice_id");

                entity.HasIndex(e => e.Tsv)
                    .HasName("index_admin_notes_on_tsv")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => new { e.Flagged, e.PatientId })
                    .HasName("index_admin_notes_patient_id_with_flagged")
                    .IsUnique()
                    .HasFilter("(flagged AND (deleted_at IS NULL))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Flagged).HasColumnName("flagged");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.Pinned).HasColumnName("pinned");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tsv).HasColumnName("tsv");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AdminNotes)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b6ea4b82ae");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AdminNotes)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ba86c49b99");
            });

            modelBuilder.Entity<AdverseReactionVersions>(entity =>
            {
                entity.ToTable("adverse_reaction_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_adverse_reaction_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_adverse_reaction_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_adverse_reaction_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_adverse_reaction_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AdverseReactionVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b828687743");
            });

            modelBuilder.Entity<AdverseReactions>(entity =>
            {
                entity.ToTable("adverse_reactions");

                entity.HasIndex(e => e.AgentAttributeId)
                    .HasName("index_adverse_reactions_on_agent_attribute_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_adverse_reactions_on_deleted_at");

                entity.HasIndex(e => e.Flagged)
                    .HasName("index_adverse_reactions_on_flagged");

                entity.HasIndex(e => e.ManifestationAttributeId)
                    .HasName("index_adverse_reactions_on_manifestation_attribute_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_adverse_reactions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_adverse_reactions_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasColumnType("character varying");

                entity.Property(e => e.AgentAttributeId).HasColumnName("agent_attribute_id");

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.AgentCodeSystem)
                    .HasColumnName("agent_code_system")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Flagged)
                    .HasColumnName("flagged")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Manifestation)
                    .HasColumnName("manifestation")
                    .HasColumnType("character varying");

                entity.Property(e => e.ManifestationAttributeId).HasColumnName("manifestation_attribute_id");

                entity.Property(e => e.ManifestationCode)
                    .HasColumnName("manifestation_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ManifestationCodeSystem)
                    .HasColumnName("manifestation_code_system")
                    .HasColumnType("character varying");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.AgentAttribute)
                    .WithMany(p => p.AdverseReactionsAgentAttribute)
                    .HasForeignKey(d => d.AgentAttributeId)
                    .HasConstraintName("fk_rails_ce6baf5b15");

                entity.HasOne(d => d.ManifestationAttribute)
                    .WithMany(p => p.AdverseReactionsManifestationAttribute)
                    .HasForeignKey(d => d.ManifestationAttributeId)
                    .HasConstraintName("fk_rails_3d49eca3d5");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AdverseReactions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e391857752");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AdverseReactions)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ee8d52bfd7");
            });

            modelBuilder.Entity<AmaFeeVersions>(entity =>
            {
                entity.ToTable("ama_fee_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_ama_fee_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_ama_fee_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_ama_fee_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AmaFees>(entity =>
            {
                entity.ToTable("ama_fees");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_ama_fees_on_deleted_at");

                entity.HasIndex(e => e.MbsBillingItemId)
                    .HasName("index_ama_fees_on_mbs_billing_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_ama_fees_on_practice_id");

                entity.HasIndex(e => new { e.PracticeId, e.MbsBillingItemId, e.DeletedAt })
                    .HasName("index_ama_fee_for_practice_and_billing_item")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MbsBillingItemId).HasColumnName("mbs_billing_item_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.MbsBillingItem)
                    .WithMany(p => p.AmaFees)
                    .HasForeignKey(d => d.MbsBillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9bd1798810");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AmaFees)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_19761da285");
            });

            modelBuilder.Entity<AmaImportVersions>(entity =>
            {
                entity.ToTable("ama_import_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_ama_import_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_ama_import_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_ama_import_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AmaImports>(entity =>
            {
                entity.ToTable("ama_imports");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_ama_imports_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_ama_imports_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_ama_imports_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.ImportFileContentType)
                    .HasColumnName("import_file_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportFileFileName)
                    .HasColumnName("import_file_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportFileFileSize).HasColumnName("import_file_file_size");

                entity.Property(e => e.ImportFileUpdatedAt).HasColumnName("import_file_updated_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AmaImports)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_46b5d12e56");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AmaImports)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_26473a9ffe");
            });

            modelBuilder.Entity<AppErrors>(entity =>
            {
                entity.ToTable("app_errors");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_app_errors_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_app_errors_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AppErrors)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_0138720a66");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppErrors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_f8b50658a9");
            });

            modelBuilder.Entity<AppointmentTypes>(entity =>
            {
                entity.ToTable("appointment_types");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_appointment_types_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_appointment_types_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Colour)
                    .HasColumnName("colour")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AppointmentTypes)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d90d7d94b5");
            });

            modelBuilder.Entity<ArInternalMetadata>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("ar_internal_metadata_pkey");

                entity.ToTable("ar_internal_metadata");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AuthorityPrescriptionNumberGenerators>(entity =>
            {
                entity.ToTable("authority_prescription_number_generators");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_authority_prescription_number_generators_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_authority_prescription_number_generators_on_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BaseNumber).HasColumnName("base_number");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.AuthorityPrescriptionNumberGenerators)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_79ce1c539e");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AuthorityPrescriptionNumberGenerators)
                    .HasForeignKey<AuthorityPrescriptionNumberGenerators>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_1d1a7bea1f");
            });

            modelBuilder.Entity<BillingItems>(entity =>
            {
                entity.ToTable("billing_items");

                entity.HasIndex(e => e.AmaBillingItemId)
                    .HasName("index_billing_items_on_ama_billing_item_id");

                entity.HasIndex(e => e.Category)
                    .HasName("index_billing_items_on_category");

                entity.HasIndex(e => e.Code)
                    .HasName("index_billing_items_on_code")
                    .HasFilter("((deleted_at IS NULL) AND (practice_id IS NULL))");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_billing_items_on_deleted_at");

                entity.HasIndex(e => e.Description)
                    .HasName("index_billing_items_on_description");

                entity.HasIndex(e => e.DiagnosticItemType)
                    .HasName("index_billing_items_on_diagnostic_item_type");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_billing_items_on_practice_id");

                entity.HasIndex(e => e.Tsv)
                    .HasName("index_billing_items_on_tsv")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.Type)
                    .HasName("index_billing_items_on_type");

                entity.HasIndex(e => new { e.PracticeId, e.Code })
                    .HasName("index_billing_items_code_with_practice")
                    .IsUnique()
                    .HasFilter("((deleted_at IS NULL) AND (practice_id IS NOT NULL))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AmaBillingItemId).HasColumnName("ama_billing_item_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("character varying");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("citext");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.DiagnosticItemType)
                    .HasColumnName("diagnostic_item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.GstIncluded).HasColumnName("gst_included");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrivateFee)
                    .HasColumnName("private_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Tsv).HasColumnName("tsv");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'PrivateBillingItem'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.AmaBillingItem)
                    .WithMany(p => p.InverseAmaBillingItem)
                    .HasForeignKey(d => d.AmaBillingItemId)
                    .HasConstraintName("fk_rails_8c4932b7df");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.BillingItems)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_e6d25a8d7a");
            });

            modelBuilder.Entity<BillingItemsProcedures>(entity =>
            {
                entity.ToTable("billing_items_procedures");

                entity.HasIndex(e => e.BillingItemId)
                    .HasName("index_billing_items_procedures_on_billing_item_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_billing_items_procedures_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_billing_items_procedures_on_practice_id");

                entity.HasIndex(e => e.ProcedureId)
                    .HasName("index_billing_items_procedures_on_procedure_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BillingItemId).HasColumnName("billing_item_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.BillingItem)
                    .WithMany(p => p.BillingItemsProcedures)
                    .HasForeignKey(d => d.BillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_be1459bcdc");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.BillingItemsProcedures)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6955547730");
            });

            modelBuilder.Entity<BillingSetItems>(entity =>
            {
                entity.ToTable("billing_set_items");

                entity.HasIndex(e => e.BillingItemId)
                    .HasName("index_billing_set_items_on_billing_item_id");

                entity.HasIndex(e => e.BillingSetId)
                    .HasName("index_billing_set_items_on_billing_set_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_billing_set_items_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_billing_set_items_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BillingItemId).HasColumnName("billing_item_id");

                entity.Property(e => e.BillingSetId).HasColumnName("billing_set_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.BillingItem)
                    .WithMany(p => p.BillingSetItems)
                    .HasForeignKey(d => d.BillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_4135a2ad11");

                entity.HasOne(d => d.BillingSet)
                    .WithMany(p => p.BillingSetItems)
                    .HasForeignKey(d => d.BillingSetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f616802e50");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.BillingSetItems)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_573a6e4230");
            });

            modelBuilder.Entity<BillingSets>(entity =>
            {
                entity.ToTable("billing_sets");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_billing_sets_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_billing_sets_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.BillingSets)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_319a3199e9");
            });

            modelBuilder.Entity<CardVersions>(entity =>
            {
                entity.ToTable("card_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_card_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_card_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_card_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Cards>(entity =>
            {
                entity.ToTable("cards");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_cards_on_deleted_at");

                entity.HasIndex(e => e.HealthFundId)
                    .HasName("index_cards_on_health_fund_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_cards_on_practice_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_cards_on_type");

                entity.HasIndex(e => new { e.HolderType, e.HolderId })
                    .HasName("index_cards_on_holder_type_and_holder_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Card)
                    .HasColumnName("card")
                    .HasColumnType("character varying");

                entity.Property(e => e.Condition)
                    .HasColumnName("condition")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Expiry)
                    .HasColumnName("expiry")
                    .HasColumnType("character varying");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.HealthFundId).HasColumnName("health_fund_id");

                entity.Property(e => e.HolderId).HasColumnName("holder_id");

                entity.Property(e => e.HolderType)
                    .IsRequired()
                    .HasColumnName("holder_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_bb563e45db");
            });

            modelBuilder.Entity<ClaimInvoiceNoteVersions>(entity =>
            {
                entity.ToTable("claim_invoice_note_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_claim_invoice_note_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_claim_invoice_note_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_claim_invoice_note_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimInvoiceNotes>(entity =>
            {
                entity.ToTable("claim_invoice_notes");

                entity.HasIndex(e => e.ClaimId)
                    .HasName("index_claim_invoice_notes_on_claim_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_claim_invoice_notes_on_deleted_at");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("index_claim_invoice_notes_on_invoice_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_claim_invoice_notes_on_practice_id");

                entity.HasIndex(e => new { e.Latest, e.ClaimId, e.InvoiceId })
                    .HasName("index_latest_claim_invoice_notes")
                    .IsUnique()
                    .HasFilter("(latest AND (deleted_at IS NULL))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.Latest).HasColumnName("latest");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimInvoiceNotes)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_a7a6f6156f");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.ClaimInvoiceNotes)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_cd21d24163");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ClaimInvoiceNotes)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3a909ef95d");
            });

            modelBuilder.Entity<ClaimVersions>(entity =>
            {
                entity.ToTable("claim_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_claim_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_claim_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_claim_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.ToTable("claims");

                entity.HasIndex(e => e.ClaimType)
                    .HasName("index_claims_on_claim_type");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_claims_on_created_at");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_claims_on_deleted_at");

                entity.HasIndex(e => e.EraTransactionIds)
                    .HasName("index_claims_on_era_transaction_ids")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.MedicareClaimId)
                    .HasName("index_claims_on_medicare_claim_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_claims_on_practice_id");

                entity.HasIndex(e => e.ReportError)
                    .HasName("index_claims_on_report_error");

                entity.HasIndex(e => e.SentOn)
                    .HasName("index_claims_on_sent_on");

                entity.HasIndex(e => new { e.PracticeId, e.ReferenceNumberId, e.ClaimType })
                    .HasName("claim_reference_number_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnName("additional_information")
                    .HasColumnType("jsonb");

                entity.Property(e => e.BenefitAmount)
                    .HasColumnName("benefit_amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasColumnName("claim_status")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'send_pending'::character varying");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnName("claim_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EraTransactionIds)
                    .HasColumnName("era_transaction_ids")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("error_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.FinalisedOn)
                    .HasColumnName("finalised_on")
                    .HasColumnType("date");

                entity.Property(e => e.MedicareClaimId)
                    .HasColumnName("medicare_claim_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicareTransactionId)
                    .HasColumnName("medicare_transaction_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaidAmount)
                    .HasColumnName("paid_amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.PaidOn)
                    .HasColumnName("paid_on")
                    .HasColumnType("date");

                entity.Property(e => e.PaymentReference)
                    .HasColumnName("payment_reference")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentReportContentType)
                    .HasColumnName("payment_report_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentReportFileName)
                    .HasColumnName("payment_report_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentReportFileSize).HasColumnName("payment_report_file_size");

                entity.Property(e => e.PaymentReportFingerprint)
                    .HasColumnName("payment_report_fingerprint")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentReportUpdatedAt).HasColumnName("payment_report_updated_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProcessingReportContentType)
                    .HasColumnName("processing_report_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProcessingReportFileName)
                    .HasColumnName("processing_report_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProcessingReportFileSize).HasColumnName("processing_report_file_size");

                entity.Property(e => e.ProcessingReportUpdatedAt).HasColumnName("processing_report_updated_at");

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("provider_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceNumberId).HasColumnName("reference_number_id");

                entity.Property(e => e.ReportError).HasColumnName("report_error");

                entity.Property(e => e.ReportedOn)
                    .HasColumnName("reported_on")
                    .HasColumnType("date");

                entity.Property(e => e.RequestContentType)
                    .HasColumnName("request_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestFileName)
                    .HasColumnName("request_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestFileSize).HasColumnName("request_file_size");

                entity.Property(e => e.RequestUpdatedAt).HasColumnName("request_updated_at");

                entity.Property(e => e.ResubmittedOn)
                    .HasColumnName("resubmitted_on")
                    .HasColumnType("date");

                entity.Property(e => e.Reviewed).HasColumnName("reviewed");

                entity.Property(e => e.SentCount)
                    .HasColumnName("sent_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SentOn)
                    .HasColumnName("sent_on")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8e85b7b4e9");
            });

            modelBuilder.Entity<ClaimsInvoices>(entity =>
            {
                entity.ToTable("claims_invoices");

                entity.HasIndex(e => e.ClaimId)
                    .HasName("index_claims_invoices_on_claim_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_claims_invoices_on_deleted_at");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("index_claims_invoices_on_invoice_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_claims_invoices_on_practice_id");

                entity.HasIndex(e => new { e.ClaimId, e.InvoiceId })
                    .HasName("index_claims_invoices_on_claim_id_and_invoice_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimsInvoices)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_43acb7120b");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.ClaimsInvoices)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9d7ae9b642");
            });

            modelBuilder.Entity<ClinicalHistoryAttributes>(entity =>
            {
                entity.ToTable("clinical_history_attributes");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_clinical_history_attributes_on_deleted_at");

                entity.HasIndex(e => e.SnomedCode)
                    .HasName("index_clinical_history_attributes_on_snomed_code");

                entity.HasIndex(e => e.Tsv)
                    .HasName("index_clinical_history_attributes_on_tsv")
                    .ForNpgsqlHasMethod("gin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AttrType)
                    .IsRequired()
                    .HasColumnName("attr_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.SnomedCode)
                    .HasColumnName("snomed_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tsv).HasColumnName("tsv");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ClinicalInteractionSettingVersions>(entity =>
            {
                entity.ToTable("clinical_interaction_setting_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_clinical_interaction_setting_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_clinical_interaction_setting_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_clinical_interaction_setting_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_clinical_interaction_setting_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClinicalInteractionSettings>(entity =>
            {
                entity.ToTable("clinical_interaction_settings");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_clinical_interaction_settings_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_clinical_interaction_settings_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.InteractionSeverity)
                    .IsRequired()
                    .HasColumnName("interaction_severity")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'moderate'::character varying");

                entity.Property(e => e.OverrideReason)
                    .IsRequired()
                    .HasColumnName("override_reason")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ClinicalInteractionSettings)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_aff00f5df0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClinicalInteractionSettings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_5d2cfc490d");
            });

            modelBuilder.Entity<CommonPasswords>(entity =>
            {
                entity.ToTable("common_passwords");

                entity.HasIndex(e => e.Password)
                    .HasName("index_common_passwords_on_password");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ConsultNoteVersions>(entity =>
            {
                entity.ToTable("consult_note_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_consult_note_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_consult_note_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_consult_note_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_consult_note_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultNoteVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_c50ea0ac62");
            });

            modelBuilder.Entity<ConsultNotes>(entity =>
            {
                entity.ToTable("consult_notes");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_consult_notes_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_consult_notes_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_consult_notes_on_practice_id");

                entity.HasIndex(e => e.RestrictedById)
                    .HasName("index_consult_notes_on_restricted_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ConsultAt).HasColumnName("consult_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Examination).HasColumnName("examination");

                entity.Property(e => e.History).HasColumnName("history");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.Plan).HasColumnName("plan");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.RestrictedAt).HasColumnName("restricted_at");

                entity.Property(e => e.RestrictedById).HasColumnName("restricted_by_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultNotes)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d00e6af1b2");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ConsultNotes)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3384c104f3");

                entity.HasOne(d => d.RestrictedBy)
                    .WithMany(p => p.ConsultNotes)
                    .HasForeignKey(d => d.RestrictedById)
                    .HasConstraintName("fk_rails_7285d8ef28");
            });

            modelBuilder.Entity<ContactVersions>(entity =>
            {
                entity.ToTable("contact_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_contact_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_contact_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_contact_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("contacts");

                entity.HasIndex(e => e.AddressId)
                    .HasName("index_contacts_on_address_id");

                entity.HasIndex(e => e.Assistant)
                    .HasName("index_contacts_on_assistant");

                entity.HasIndex(e => e.BillingAddressId)
                    .HasName("index_contacts_on_billing_address_id");

                entity.HasIndex(e => e.BusinessName)
                    .HasName("index_contacts_on_business_name");

                entity.HasIndex(e => e.BusinessPerformsProcedure)
                    .HasName("index_contacts_on_business_performs_procedure");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_contacts_on_deleted_at");

                entity.HasIndex(e => e.FirstName)
                    .HasName("index_contacts_on_first_name");

                entity.HasIndex(e => e.GenieSpecialtyId)
                    .HasName("index_contacts_on_genie_specialty_id");

                entity.HasIndex(e => e.HealthFundId)
                    .HasName("index_contacts_on_health_fund_id");

                entity.HasIndex(e => e.LastName)
                    .HasName("index_contacts_on_last_name");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_contacts_on_practice_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_contacts_on_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.ApplyGst).HasColumnName("apply_gst");

                entity.Property(e => e.Argus)
                    .HasColumnName("argus")
                    .HasColumnType("character varying");

                entity.Property(e => e.Assistant).HasColumnName("assistant");

                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

                entity.Property(e => e.BornOn)
                    .HasColumnName("born_on")
                    .HasColumnType("date");

                entity.Property(e => e.BusinessName)
                    .HasColumnName("business_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.BusinessPerformsProcedure).HasColumnName("business_performs_procedure");

                entity.Property(e => e.ContactMethod)
                    .HasColumnName("contact_method")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasColumnName("entity_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("character varying");

                entity.Property(e => e.FeeScheduleId).HasColumnName("fee_schedule_id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.GenieSpecialtyId).HasColumnName("genie_specialty_id");

                entity.Property(e => e.HealthFundId).HasColumnName("health_fund_id");

                entity.Property(e => e.Healthlink)
                    .HasColumnName("healthlink")
                    .HasColumnType("character varying");

                entity.Property(e => e.IssueInvoice).HasColumnName("issue_invoice");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicalObjects)
                    .HasColumnName("medical_objects")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("provider_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'GenericContact'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ContactsAddress)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_rails_69305193d8");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.ContactsBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("fk_rails_15c0466a6b");

                entity.HasOne(d => d.GenieSpecialty)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.GenieSpecialtyId)
                    .HasConstraintName("fk_rails_3a93324e5f");

                entity.HasOne(d => d.HealthFund)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.HealthFundId)
                    .HasConstraintName("fk_rails_61fb3d5b2f");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9266168a9c");
            });

            modelBuilder.Entity<CustomMedicationVersions>(entity =>
            {
                entity.ToTable("custom_medication_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_custom_medication_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_custom_medication_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_custom_medication_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_custom_medication_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<CustomMedications>(entity =>
            {
                entity.ToTable("custom_medications");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_custom_medications_on_deleted_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_custom_medications_on_name");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_custom_medications_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.FormStrength)
                    .HasColumnName("form_strength")
                    .HasColumnType("character varying");

                entity.Property(e => e.GddType)
                    .HasColumnName("gdd_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gddid).HasColumnName("gddid");

                entity.Property(e => e.GenericDrugCode)
                    .HasColumnName("generic_drug_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("character varying");

                entity.Property(e => e.Repeats).HasColumnName("repeats");

                entity.Property(e => e.Scheme)
                    .HasColumnName("scheme")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.CustomMedications)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_81786130e4");
            });

            modelBuilder.Entity<Diagnoses>(entity =>
            {
                entity.ToTable("diagnoses");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_diagnoses_on_deleted_at");

                entity.HasIndex(e => e.DiagnosisAttributeId)
                    .HasName("index_diagnoses_on_diagnosis_attribute_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_diagnoses_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_diagnoses_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DiagnosisAttributeId).HasColumnName("diagnosis_attribute_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Onset)
                    .HasColumnName("onset")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Resolved)
                    .HasColumnName("resolved")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.DiagnosisAttribute)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.DiagnosisAttributeId)
                    .HasConstraintName("fk_rails_debbe65b18");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b4ae3dea5a");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f875f0c9a2");
            });

            modelBuilder.Entity<DiagnosisVersions>(entity =>
            {
                entity.ToTable("diagnosis_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_diagnosis_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_diagnosis_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_diagnosis_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_diagnosis_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DiagnosisVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_852da7b4d4");
            });

            modelBuilder.Entity<DiagnosticRequestCcs>(entity =>
            {
                entity.ToTable("diagnostic_request_ccs");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_diagnostic_request_ccs_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_diagnostic_request_ccs_on_practice_id");

                entity.HasIndex(e => new { e.DiagnosticRequestId, e.ContactId })
                    .HasName("unique_diagnostic_request_ccs")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DiagnosticRequestId).HasColumnName("diagnostic_request_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DiagnosticRequestCcs)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_7610e97be4");

                entity.HasOne(d => d.DiagnosticRequest)
                    .WithMany(p => p.DiagnosticRequestCcs)
                    .HasForeignKey(d => d.DiagnosticRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b2f41b163f");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.DiagnosticRequestCcs)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2dc586f70a");
            });

            modelBuilder.Entity<DiagnosticRequestVersions>(entity =>
            {
                entity.ToTable("diagnostic_request_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_diagnostic_request_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_diagnostic_request_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<DiagnosticRequests>(entity =>
            {
                entity.ToTable("diagnostic_requests");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_diagnostic_requests_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_diagnostic_requests_on_practice_id");

                entity.HasIndex(e => e.Received)
                    .HasName("index_diagnostic_requests_on_received");

                entity.HasIndex(e => e.Type)
                    .HasName("index_diagnostic_requests_on_type");

                entity.HasIndex(e => new { e.Type, e.PracticeId, e.ReferenceNumber })
                    .HasName("index_diagnostic_req_on_type_and_practice_id_and_ref_number")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DeliveryMethod)
                    .HasColumnName("delivery_method")
                    .HasColumnType("character varying");

                entity.Property(e => e.DoctorCode)
                    .HasColumnName("doctor_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PreventHealthRecordUpload).HasColumnName("prevent_health_record_upload");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Received).HasColumnName("received");

                entity.Property(e => e.ReferenceNumber).HasColumnName("reference_number");

                entity.Property(e => e.RequestLabId).HasColumnName("request_lab_id");

                entity.Property(e => e.RequestLabName)
                    .HasColumnName("request_lab_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequesterId).HasColumnName("requester_id");

                entity.Property(e => e.Tests)
                    .IsRequired()
                    .HasColumnName("tests");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.Urgent).HasColumnName("urgent");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DiagnosticRequests)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8c12a305f4");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.DiagnosticRequests)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8a44cceba7");

                entity.HasOne(d => d.RequestLab)
                    .WithMany(p => p.DiagnosticRequests)
                    .HasForeignKey(d => d.RequestLabId)
                    .HasConstraintName("fk_rails_15404bbff2");

                entity.HasOne(d => d.Requester)
                    .WithMany(p => p.DiagnosticRequests)
                    .HasForeignKey(d => d.RequesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d00a68fa30");
            });

            modelBuilder.Entity<DocumentContents>(entity =>
            {
                entity.ToTable("document_contents");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_document_contents_on_deleted_at");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("index_document_contents_on_document_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_document_contents_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContentContentType)
                    .HasColumnName("content_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentFileName)
                    .HasColumnName("content_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentFileSize).HasColumnName("content_file_size");

                entity.Property(e => e.ContentUpdatedAt).HasColumnName("content_updated_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'DocumentContent'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentContents)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_5facf05360");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.DocumentContents)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9a36be00b5");
            });

            modelBuilder.Entity<DocumentVersions>(entity =>
            {
                entity.ToTable("document_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_document_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_document_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_document_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.ToTable("documents");

                entity.HasIndex(e => e.Category)
                    .HasName("index_documents_on_category");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_documents_on_created_at");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_documents_on_deleted_at");

                entity.HasIndex(e => e.DocumentType)
                    .HasName("index_documents_on_document_type");

                entity.HasIndex(e => e.MessageUuid)
                    .HasName("index_documents_on_message_uuid");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_documents_on_practice_id");

                entity.HasIndex(e => e.RestrictedById)
                    .HasName("index_documents_on_restricted_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AckUuids).HasColumnName("ack_uuids");

                entity.Property(e => e.Addressee)
                    .HasColumnName("addressee")
                    .HasColumnType("character varying");

                entity.Property(e => e.BornOn)
                    .HasColumnName("born_on")
                    .HasColumnType("date");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("character varying");

                entity.Property(e => e.CollectedOn)
                    .HasColumnName("collected_on")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasColumnName("document_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LaboratoryName)
                    .HasColumnName("laboratory_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicareNumber)
                    .HasColumnName("medicare_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageUuid)
                    .HasColumnName("message_uuid")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReferringProvider)
                    .HasColumnName("referring_provider")
                    .HasColumnType("character varying");

                entity.Property(e => e.RestrictedAt).HasColumnName("restricted_at");

                entity.Property(e => e.RestrictedById).HasColumnName("restricted_by_id");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResultStatus)
                    .HasColumnName("result_status")
                    .HasColumnType("character varying");

                entity.Property(e => e.SetOn)
                    .HasColumnName("set_on")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'unlinked'::character varying");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b398ab30e3");

                entity.HasOne(d => d.RestrictedBy)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.RestrictedById)
                    .HasConstraintName("fk_rails_8bab306b21");
            });

            modelBuilder.Entity<DvaFeeVersions>(entity =>
            {
                entity.ToTable("dva_fee_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_dva_fee_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_dva_fee_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<DvaFees>(entity =>
            {
                entity.ToTable("dva_fees");

                entity.HasIndex(e => e.DvaImportId)
                    .HasName("index_dva_fees_on_dva_import_id");

                entity.HasIndex(e => e.MbsBillingItemId)
                    .HasName("index_dva_fees_on_mbs_billing_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Derived).HasColumnName("derived");

                entity.Property(e => e.DvaImportId).HasColumnName("dva_import_id");

                entity.Property(e => e.InpatientFee)
                    .HasColumnName("inpatient_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.LmoFee)
                    .HasColumnName("lmo_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MbsBillingItemId).HasColumnName("mbs_billing_item_id");

                entity.Property(e => e.OutpatientFee)
                    .HasColumnName("outpatient_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.StartsOn)
                    .HasColumnName("starts_on")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.DvaImport)
                    .WithMany(p => p.DvaFees)
                    .HasForeignKey(d => d.DvaImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_67e01ff719");

                entity.HasOne(d => d.MbsBillingItem)
                    .WithMany(p => p.DvaFees)
                    .HasForeignKey(d => d.MbsBillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_be14558f53");
            });

            modelBuilder.Entity<DvaImportVersions>(entity =>
            {
                entity.ToTable("dva_import_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_dva_import_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_dva_import_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<DvaImports>(entity =>
            {
                entity.ToTable("dva_imports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EffectiveOn)
                    .HasColumnName("effective_on")
                    .HasColumnType("date");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<EmergencyContactVersions>(entity =>
            {
                entity.ToTable("emergency_contact_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_emergency_contact_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_emergency_contact_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_emergency_contact_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<EmergencyContacts>(entity =>
            {
                entity.ToTable("emergency_contacts");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_emergency_contacts_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_emergency_contacts_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_emergency_contacts_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.NextOfKin).HasColumnName("next_of_kin");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_7ca093b8b3");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_06859eefde");
            });

            modelBuilder.Entity<EventVersions>(entity =>
            {
                entity.ToTable("event_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_event_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_event_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_event_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_appointment_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("events");

                entity.HasIndex(e => e.AppointmentTypeId)
                    .HasName("index_events_on_appointment_type_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_events_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_events_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_events_on_practice_id");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("index_events_on_provider_id");

                entity.HasIndex(e => e.RecurrenceId)
                    .HasName("index_events_on_recurrence_id");

                entity.HasIndex(e => e.RecurringRule)
                    .HasName("index_events_on_recurring_rule")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.StartsAt)
                    .HasName("index_events_on_starts_at");

                entity.HasIndex(e => e.Type)
                    .HasName("index_events_on_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppointmentTypeId).HasColumnName("appointment_type_id");

                entity.Property(e => e.Billed).HasColumnName("billed");

                entity.Property(e => e.CancelledAt).HasColumnName("cancelled_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.InvoiceNotRequired).HasColumnName("invoice_not_required");

                entity.Property(e => e.IsScheduled).HasColumnName("is_scheduled");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.RecurrenceId).HasColumnName("recurrence_id");

                entity.Property(e => e.RecurringRule)
                    .HasColumnName("recurring_rule")
                    .HasColumnType("jsonb");

                entity.Property(e => e.SiteOfServiceId).HasColumnName("site_of_service_id");

                entity.Property(e => e.SmsStatus)
                    .IsRequired()
                    .HasColumnName("sms_status")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.StartsAt).HasColumnName("starts_at");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.UpdatingOccurrences).HasColumnName("updating_occurrences");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .HasConstraintName("fk_rails_d5cee4b933");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("fk_rails_e1899a68af");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_21685886d0");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_91010ab6b3");

                entity.HasOne(d => d.Recurrence)
                    .WithMany(p => p.InverseRecurrence)
                    .HasForeignKey(d => d.RecurrenceId)
                    .HasConstraintName("fk_rails_abe19bd7ec");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.ToTable("features");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_features_on_deleted_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_features_on_name")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<FeeSchedules>(entity =>
            {
                entity.ToTable("fee_schedules");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_fee_schedules_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_fee_schedules_on_practice_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_fee_schedules_on_type");

                entity.HasIndex(e => new { e.Name, e.Type })
                    .HasName("index_global_fee_schedule_name")
                    .IsUnique()
                    .HasFilter("(practice_id IS NULL)");

                entity.HasIndex(e => new { e.Type, e.PracticeId })
                    .HasName("index_ama_fee_schedule")
                    .IsUnique()
                    .HasFilter("(((type)::text = 'AMAFeeSchedule'::text) AND (practice_id IS NOT NULL) AND (deleted_at IS NULL))");

                entity.HasIndex(e => new { e.Name, e.Type, e.PracticeId, e.DeletedAt })
                    .HasName("index_fee_schedule_name")
                    .IsUnique()
                    .HasFilter("(practice_id IS NOT NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.FeeSchedules)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_15e2cfbec1");
            });

            modelBuilder.Entity<FeeSetImports>(entity =>
            {
                entity.ToTable("fee_set_imports");

                entity.HasIndex(e => e.FeeSetId)
                    .HasName("index_fee_set_imports_on_fee_set_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_fee_set_imports_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FeeSetId).HasColumnName("fee_set_id");

                entity.Property(e => e.ImportContentType)
                    .HasColumnName("import_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportFileName)
                    .HasColumnName("import_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportFileSize).HasColumnName("import_file_size");

                entity.Property(e => e.ImportUpdatedAt).HasColumnName("import_updated_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.FeeSet)
                    .WithMany(p => p.FeeSetImports)
                    .HasForeignKey(d => d.FeeSetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d048620c76");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.FeeSetImports)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_0a75a18a47");
            });

            modelBuilder.Entity<FeeSets>(entity =>
            {
                entity.ToTable("fee_sets");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_fee_sets_on_deleted_at");

                entity.HasIndex(e => e.EffectiveOn)
                    .HasName("index_fee_sets_on_effective_on");

                entity.HasIndex(e => e.FeeScheduleId)
                    .HasName("index_fee_sets_on_fee_schedule_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_fee_sets_on_practice_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("index_fee_sets_on_state_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_fee_sets_on_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EffectiveOn)
                    .HasColumnName("effective_on")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1970-01-01'::date");

                entity.Property(e => e.FeeScheduleId).HasColumnName("fee_schedule_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.FeeSchedule)
                    .WithMany(p => p.FeeSets)
                    .HasForeignKey(d => d.FeeScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_93e9ef72cf");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.FeeSets)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_2ed62307e2");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.FeeSets)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("fk_rails_0da6f52bed");
            });

            modelBuilder.Entity<Fees>(entity =>
            {
                entity.ToTable("fees");

                entity.HasIndex(e => e.BillingItemId)
                    .HasName("index_fees_on_billing_item_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_fees_on_deleted_at");

                entity.HasIndex(e => e.FeeSetId)
                    .HasName("index_fees_on_fee_set_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_fees_on_practice_id");

                entity.HasIndex(e => e.StartsOn)
                    .HasName("index_fees_on_starts_on");

                entity.HasIndex(e => e.Type)
                    .HasName("index_fees_on_type");

                entity.HasIndex(e => new { e.FeeSetId, e.BillingItemId })
                    .HasName("index_global_fees_on_fee_set_id_and_billing_item_id")
                    .IsUnique()
                    .HasFilter("((deleted_at IS NULL) AND (practice_id IS NULL))");

                entity.HasIndex(e => new { e.FeeSetId, e.BillingItemId, e.PracticeId })
                    .HasName("index_fees_on_fee_set_id_and_billing_item_id_and_practice_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BillingItemId).HasColumnName("billing_item_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.FeeSetId).HasColumnName("fee_set_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.StartsOn)
                    .HasColumnName("starts_on")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1970-01-01'::date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.BillingItem)
                    .WithMany(p => p.Fees)
                    .HasForeignKey(d => d.BillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_1203bb8d8c");

                entity.HasOne(d => d.FeeSet)
                    .WithMany(p => p.Fees)
                    .HasForeignKey(d => d.FeeSetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9bc938485f");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Fees)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_e185c9beb6");
            });

            modelBuilder.Entity<FlagVersions>(entity =>
            {
                entity.ToTable("flag_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_flag_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_flag_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_flag_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Flags>(entity =>
            {
                entity.ToTable("flags");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_flags_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_flags_on_practice_id");

                entity.HasIndex(e => new { e.SubjectType, e.SubjectId })
                    .HasName("index_flags_on_subject_type_and_subject_id");

                entity.HasIndex(e => new { e.PracticeId, e.SubjectType, e.SubjectId, e.Type })
                    .HasName("index_flags_practice_subject_type")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EndsAt).HasColumnName("ends_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.StartsAt).HasColumnName("starts_at");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.SubjectType)
                    .IsRequired()
                    .HasColumnName("subject_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Flags)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6e3c0c281e");
            });

            modelBuilder.Entity<GenieSpecialties>(entity =>
            {
                entity.ToTable("genie_specialties");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_genie_specialties_on_deleted_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<HealthFundDetails>(entity =>
            {
                entity.ToTable("health_fund_details");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_health_fund_details_on_deleted_at");

                entity.HasIndex(e => e.HealthFundId)
                    .HasName("index_health_fund_details_on_health_fund_id");

                entity.HasIndex(e => e.HealthFundScheduleId)
                    .HasName("index_health_fund_details_on_health_fund_schedule_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_fund_details_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_health_fund_details_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BillingType)
                    .HasColumnName("billing_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimType)
                    .HasColumnName("claim_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.HealthFundId).HasColumnName("health_fund_id");

                entity.Property(e => e.HealthFundScheduleId).HasColumnName("health_fund_schedule_id");

                entity.Property(e => e.KnownGap)
                    .HasColumnName("known_gap")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.PayeeId)
                    .HasColumnName("payee_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.HealthFund)
                    .WithMany(p => p.HealthFundDetails)
                    .HasForeignKey(d => d.HealthFundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_15cb64ac7f");

                entity.HasOne(d => d.HealthFundSchedule)
                    .WithMany(p => p.HealthFundDetails)
                    .HasForeignKey(d => d.HealthFundScheduleId)
                    .HasConstraintName("fk_rails_6094275d00");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.HealthFundDetails)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ffc3f96d66");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HealthFundDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2cfde37167");
            });

            modelBuilder.Entity<HealthFundFeeVersions>(entity =>
            {
                entity.ToTable("health_fund_fee_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_health_fund_fee_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_health_fund_fee_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<HealthFundFees>(entity =>
            {
                entity.ToTable("health_fund_fees");

                entity.HasIndex(e => e.BillingItemId)
                    .HasName("index_health_fund_fees_on_billing_item_id");

                entity.HasIndex(e => e.HealthFundImportId)
                    .HasName("index_health_fund_fees_on_health_fund_import_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BillingItemId).HasColumnName("billing_item_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.HealthFundImportId).HasColumnName("health_fund_import_id");

                entity.Property(e => e.ScheduleFee)
                    .HasColumnName("schedule_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.SchedulePercentage)
                    .HasColumnName("schedule_percentage")
                    .HasColumnType("numeric(10,6)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.BillingItem)
                    .WithMany(p => p.HealthFundFees)
                    .HasForeignKey(d => d.BillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_de8e83125d");

                entity.HasOne(d => d.HealthFundImport)
                    .WithMany(p => p.HealthFundFees)
                    .HasForeignKey(d => d.HealthFundImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3d6c81048a");
            });

            modelBuilder.Entity<HealthFundImportVersions>(entity =>
            {
                entity.ToTable("health_fund_import_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_health_fund_import_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_health_fund_import_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<HealthFundImports>(entity =>
            {
                entity.ToTable("health_fund_imports");

                entity.HasIndex(e => e.HealthFundScheduleId)
                    .HasName("index_health_fund_imports_on_health_fund_schedule_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("index_health_fund_imports_on_state_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EffectiveOn)
                    .HasColumnName("effective_on")
                    .HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.HealthFundScheduleId).HasColumnName("health_fund_schedule_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.HealthFundSchedule)
                    .WithMany(p => p.HealthFundImports)
                    .HasForeignKey(d => d.HealthFundScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_a7485e9228");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.HealthFundImports)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("fk_rails_cf152cf5b8");
            });

            modelBuilder.Entity<HealthFundScheduleVersions>(entity =>
            {
                entity.ToTable("health_fund_schedule_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_fund_schedule_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_health_fund_schedule_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_health_fund_schedule_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<HealthFundSchedules>(entity =>
            {
                entity.ToTable("health_fund_schedules");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_health_fund_schedules_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_fund_schedules_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.MbsMultiplier)
                    .HasColumnName("mbs_multiplier")
                    .HasColumnType("numeric(5,3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.HealthFundSchedules)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_993f339eee");
            });

            modelBuilder.Entity<HealthFundVersions>(entity =>
            {
                entity.ToTable("health_fund_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_fund_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_health_fund_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_health_fund_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<HealthFunds>(entity =>
            {
                entity.ToTable("health_funds");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_health_funds_on_deleted_at");

                entity.HasIndex(e => e.HealthFundScheduleId)
                    .HasName("index_health_funds_on_health_fund_schedule_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_funds_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Ahsa).HasColumnName("ahsa");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Era).HasColumnName("era");

                entity.Property(e => e.HealthFundScheduleId).HasColumnName("health_fund_schedule_id");

                entity.Property(e => e.ImcAgreements).HasColumnName("imc_agreements");

                entity.Property(e => e.ImcMedicareBenefits).HasColumnName("imc_medicare_benefits");

                entity.Property(e => e.ImcPatientClaims).HasColumnName("imc_patient_claims");

                entity.Property(e => e.ImcSchemes).HasColumnName("imc_schemes");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Opv).HasColumnName("opv");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.HealthFundSchedule)
                    .WithMany(p => p.HealthFunds)
                    .HasForeignKey(d => d.HealthFundScheduleId)
                    .HasConstraintName("fk_rails_834ed882d1");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.HealthFunds)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_462485184a");
            });

            modelBuilder.Entity<HealthTeamMemberVersions>(entity =>
            {
                entity.ToTable("health_team_member_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_team_member_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_health_team_member_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_health_team_member_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<HealthTeamMembers>(entity =>
            {
                entity.ToTable("health_team_members");

                entity.HasIndex(e => e.ContactId)
                    .HasName("index_health_team_members_on_contact_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_health_team_members_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_health_team_members_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_health_team_members_on_practice_id");

                entity.HasIndex(e => new { e.PatientId, e.ContactId, e.DeletedAt })
                    .HasName("health_team_member_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.NominatedGp).HasColumnName("nominated_gp");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.HealthTeamMembers)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3c5c6deb79");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.HealthTeamMembers)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_48cf860743");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.HealthTeamMembers)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d6459a408c");
            });

            modelBuilder.Entity<Identifiers>(entity =>
            {
                entity.ToTable("identifiers");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_identifiers_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_identifiers_on_practice_id");

                entity.HasIndex(e => new { e.PracticeId, e.Service, e.DeletedAt })
                    .HasName("index_identifiers_on_practice_id_and_service_and_deleted_at")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasColumnName("service")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Identifiers)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6e54023903");
            });

            modelBuilder.Entity<IdentifiersVersions>(entity =>
            {
                entity.ToTable("identifiers_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_identifiers_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_identifiers_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_identifiers_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<InvoiceItemTxns>(entity =>
            {
                entity.ToTable("invoice_item_txns");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("index_invoice_item_txns_on_invoice_id");

                entity.HasIndex(e => e.InvoiceItemId)
                    .HasName("index_invoice_item_txns_on_invoice_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_invoice_item_txns_on_practice_id");

                entity.HasIndex(e => e.TxnId)
                    .HasName("index_invoice_item_txns_on_txn_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Gst)
                    .HasColumnName("gst")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceItemId).HasColumnName("invoice_item_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TxnId).HasColumnName("txn_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceItemTxns)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_21501e542c");

                entity.HasOne(d => d.InvoiceItem)
                    .WithMany(p => p.InvoiceItemTxns)
                    .HasForeignKey(d => d.InvoiceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e2638fcbfe");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.InvoiceItemTxns)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b50c3c4fe3");

                entity.HasOne(d => d.Txn)
                    .WithMany(p => p.InvoiceItemTxns)
                    .HasForeignKey(d => d.TxnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_4b3ffcd2f1");
            });

            modelBuilder.Entity<InvoiceItemVersions>(entity =>
            {
                entity.ToTable("invoice_item_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_invoice_item_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_invoice_item_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_invoice_item_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<InvoiceItems>(entity =>
            {
                entity.ToTable("invoice_items");

                entity.HasIndex(e => e.BillingItemId)
                    .HasName("index_invoice_items_on_billing_item_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_invoice_items_on_deleted_at");

                entity.HasIndex(e => e.InvoiceableId)
                    .HasName("index_invoice_items_on_invoiceable_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_invoice_items_on_practice_id");

                entity.HasIndex(e => e.RequestingProviderId)
                    .HasName("index_invoice_items_on_requesting_provider_id");

                entity.HasIndex(e => e.VoucherId)
                    .HasName("index_invoice_items_on_voucher_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnName("additional_information")
                    .HasColumnType("jsonb");

                entity.Property(e => e.BillingItemId).HasColumnName("billing_item_id");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasColumnName("claim_status")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GstIncluded).HasColumnName("gst_included");

                entity.Property(e => e.InvoiceableId).HasColumnName("invoiceable_id");

                entity.Property(e => e.MultipleProcedureApplied)
                    .HasColumnName("multiple_procedure_applied")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.NoRequestReason)
                    .HasColumnName("no_request_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.NotRestrictiveOverrides)
                    .HasColumnName("not_restrictive_overrides")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'none'::character varying");

                entity.Property(e => e.Overrides).HasColumnName("overrides");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Rebate)
                    .HasColumnName("rebate")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RequestedOn)
                    .HasColumnName("requested_on")
                    .HasColumnType("date");

                entity.Property(e => e.RequestingProviderId).HasColumnName("requesting_provider_id");

                entity.Property(e => e.ServiceText)
                    .HasColumnName("service_text")
                    .HasColumnType("character varying");

                entity.Property(e => e.ServiceTime)
                    .HasColumnName("service_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.ServicedOn)
                    .HasColumnName("serviced_on")
                    .HasColumnType("date");

                entity.Property(e => e.ServicingProviderId).HasColumnName("servicing_provider_id");

                entity.Property(e => e.ServicingProviderType)
                    .HasColumnName("servicing_provider_type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'User'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.HasOne(d => d.BillingItem)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.BillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_1b91f07a2e");

                entity.HasOne(d => d.Invoiceable)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.InvoiceableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6d6a3ca1fc");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_984210bf8a");

                entity.HasOne(d => d.RequestingProvider)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.RequestingProviderId)
                    .HasConstraintName("fk_rails_473aed6c1f");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("fk_rails_9ad89dfe36");
            });

            modelBuilder.Entity<InvoiceableVersions>(entity =>
            {
                entity.ToTable("invoiceable_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_invoiceable_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_invoiceable_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_invoiceable_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("invoices");

                entity.HasIndex(e => e.AccountId)
                    .HasName("index_invoices_on_account_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_invoices_on_deleted_at");

                entity.HasIndex(e => e.FeeScheduleId)
                    .HasName("index_invoices_on_fee_schedule_id");

                entity.HasIndex(e => e.GapAssigneeId)
                    .HasName("index_invoices_on_gap_assignee_id");

                entity.HasIndex(e => e.HealthFundId)
                    .HasName("index_invoices_on_health_fund_id");

                entity.HasIndex(e => e.HospitalId)
                    .HasName("index_invoices_on_hospital_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_invoices_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_invoices_on_practice_id");

                entity.HasIndex(e => e.ReferralId)
                    .HasName("index_invoices_on_referral_id");

                entity.HasIndex(e => e.SiteOfServiceId)
                    .HasName("index_invoices_on_site_of_service_id");

                entity.HasIndex(e => e.ThirdPartyClaimId)
                    .HasName("index_invoices_on_third_party_claim_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_invoices_on_user_id");

                entity.HasIndex(e => new { e.PracticeId, e.ReferenceNumberId, e.Type })
                    .HasName("index_invoices_on_practice_id_and_reference_number_id_and_type")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'self'::character varying");

                entity.Property(e => e.BillingType)
                    .HasColumnName("billing_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasColumnName("claim_status")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'unclaimed'::character varying");

                entity.Property(e => e.Committed).HasColumnName("committed");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DistanceTravelled).HasColumnName("distance_travelled");

                entity.Property(e => e.EmailedAt).HasColumnName("emailed_at");

                entity.Property(e => e.FeeScheduleId).HasColumnName("fee_schedule_id");

                entity.Property(e => e.GapAssigneeId).HasColumnName("gap_assignee_id");

                entity.Property(e => e.HealthFundId).HasColumnName("health_fund_id");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.Property(e => e.MprType)
                    .HasColumnName("mpr_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.NoReferralReason)
                    .HasColumnName("no_referral_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.RebateType)
                    .IsRequired()
                    .HasColumnName("rebate_type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'outpatient'::character varying");

                entity.Property(e => e.ReferenceNumberId).HasColumnName("reference_number_id");

                entity.Property(e => e.ReferralId).HasColumnName("referral_id");

                entity.Property(e => e.SiteOfServiceId).HasColumnName("site_of_service_id");

                entity.Property(e => e.ThirdPartyClaimId).HasColumnName("third_party_claim_id");

                entity.Property(e => e.TreatmentLocation)
                    .HasColumnName("treatment_location")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.InvoicesAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fk_rails_afb4b1e584");

                entity.HasOne(d => d.FeeSchedule)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.FeeScheduleId)
                    .HasConstraintName("fk_rails_e1a1a46c03");

                entity.HasOne(d => d.GapAssignee)
                    .WithMany(p => p.InvoicesGapAssignee)
                    .HasForeignKey(d => d.GapAssigneeId)
                    .HasConstraintName("fk_rails_aae441840b");

                entity.HasOne(d => d.HealthFund)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.HealthFundId)
                    .HasConstraintName("fk_rails_dd9ddb91b0");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("fk_rails_4db33cff2b");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_cc9f5c45d4");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f5e2601cc8");

                entity.HasOne(d => d.Referral)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ReferralId)
                    .HasConstraintName("fk_rails_182b4b7690");

                entity.HasOne(d => d.SiteOfService)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.SiteOfServiceId)
                    .HasConstraintName("fk_rails_8054488357");

                entity.HasOne(d => d.ThirdPartyClaim)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ThirdPartyClaimId)
                    .HasConstraintName("fk_rails_5940079989");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_3d1522a0d8");
            });

            modelBuilder.Entity<LetterImages>(entity =>
            {
                entity.ToTable("letter_images");

                entity.HasIndex(e => e.ContentFingerprint)
                    .HasName("index_letter_images_on_content_fingerprint");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_letter_images_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_letter_images_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContentContentType)
                    .HasColumnName("content_content_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentFileName)
                    .HasColumnName("content_file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentFileSize).HasColumnName("content_file_size");

                entity.Property(e => e.ContentFingerprint)
                    .HasColumnName("content_fingerprint")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentUpdatedAt).HasColumnName("content_updated_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.LetterImages)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_38098634ab");
            });

            modelBuilder.Entity<LetterVersions>(entity =>
            {
                entity.ToTable("letter_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_letter_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_letter_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_letter_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_letter_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.LetterVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_dac77607fb");
            });

            modelBuilder.Entity<Letters>(entity =>
            {
                entity.ToTable("letters");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_letters_on_created_at");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_letters_on_deleted_at");

                entity.HasIndex(e => e.DeliveredTo)
                    .HasName("index_letters_on_delivered_to");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_letters_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_letters_on_practice_id");

                entity.HasIndex(e => e.RestrictedById)
                    .HasName("index_letters_on_restricted_by_id");

                entity.HasIndex(e => e.SenderId)
                    .HasName("index_letters_on_sender_id");

                entity.HasIndex(e => e.Status)
                    .HasName("index_letters_on_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AddresseeName)
                    .HasColumnName("addressee_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CcNames)
                    .HasColumnName("cc_names")
                    .HasColumnType("character varying");

                entity.Property(e => e.CcPatient).HasColumnName("cc_patient");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DeliveredTo)
                    .IsRequired()
                    .HasColumnName("delivered_to")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'\"{}\"'::jsonb");

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.Header).HasColumnName("header");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrintedAt).HasColumnName("printed_at");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("character varying");

                entity.Property(e => e.RestrictedAt).HasColumnName("restricted_at");

                entity.Property(e => e.RestrictedById).HasColumnName("restricted_by_id");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.SentAt).HasColumnName("sent_at");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'draft'::character varying");

                entity.Property(e => e.TemplateConfig)
                    .HasColumnName("template_config")
                    .HasColumnType("jsonb");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Letters)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_c0bfa31690");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Letters)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_aa7966302a");

                entity.HasOne(d => d.RestrictedBy)
                    .WithMany(p => p.LettersRestrictedBy)
                    .HasForeignKey(d => d.RestrictedById)
                    .HasConstraintName("fk_rails_2ec31d386c");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.LettersSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_a4a4c1d37f");
            });

            modelBuilder.Entity<MbsFeeVersions>(entity =>
            {
                entity.ToTable("mbs_fee_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_mbs_fee_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_mbs_fee_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<MbsFees>(entity =>
            {
                entity.ToTable("mbs_fees");

                entity.HasIndex(e => e.MbsBillingItemId)
                    .HasName("index_mbs_fees_on_mbs_billing_item_id");

                entity.HasIndex(e => e.MbsImportId)
                    .HasName("index_mbs_fees_on_mbs_import_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Assist).HasColumnName("assist");

                entity.Property(e => e.Benefit100)
                    .HasColumnName("benefit_100")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Benefit75)
                    .HasColumnName("benefit_75")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Benefit85)
                    .HasColumnName("benefit_85")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.BenefitType)
                    .IsRequired()
                    .HasColumnName("benefit_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EndsOn)
                    .HasColumnName("ends_on")
                    .HasColumnType("date");

                entity.Property(e => e.FeeType)
                    .IsRequired()
                    .HasColumnName("fee_type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnName("group")
                    .HasColumnType("character varying");

                entity.Property(e => e.MbsBillingItemId).HasColumnName("mbs_billing_item_id");

                entity.Property(e => e.MbsImportId).HasColumnName("mbs_import_id");

                entity.Property(e => e.ScheduleFee)
                    .HasColumnName("schedule_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.StartsOn)
                    .HasColumnName("starts_on")
                    .HasColumnType("date");

                entity.Property(e => e.Subgroup)
                    .IsRequired()
                    .HasColumnName("subgroup")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.MbsBillingItem)
                    .WithMany(p => p.MbsFees)
                    .HasForeignKey(d => d.MbsBillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f4a8be5957");

                entity.HasOne(d => d.MbsImport)
                    .WithMany(p => p.MbsFees)
                    .HasForeignKey(d => d.MbsImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_20cb4d6b7c");
            });

            modelBuilder.Entity<MbsImportVersions>(entity =>
            {
                entity.ToTable("mbs_import_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_mbs_import_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_mbs_import_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<MbsImports>(entity =>
            {
                entity.ToTable("mbs_imports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AssistThreshold)
                    .HasColumnName("assist_threshold")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EffectiveOn)
                    .HasColumnName("effective_on")
                    .HasColumnType("date");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<MedicationVersions>(entity =>
            {
                entity.ToTable("medication_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_medication_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_medication_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_medication_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_medication_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MedicationVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e17cdf9a2f");
            });

            modelBuilder.Entity<Medications>(entity =>
            {
                entity.ToTable("medications");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_medications_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_medications_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_medications_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AuthorityCode)
                    .HasColumnName("authority_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.AuthorityFormNumber).HasColumnName("authority_form_number");

                entity.Property(e => e.BrandSubstitutionNotAllowed).HasColumnName("brand_substitution_not_allowed");

                entity.Property(e => e.ClinicalReason)
                    .HasColumnName("clinical_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.CustomMedicationId).HasColumnName("custom_medication_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmergencyCallAt).HasColumnName("emergency_call_at");

                entity.Property(e => e.FinishedOn)
                    .HasColumnName("finished_on")
                    .HasColumnType("date");

                entity.Property(e => e.FormStrength)
                    .HasColumnName("form_strength")
                    .HasColumnType("character varying");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasColumnType("character varying");

                entity.Property(e => e.GddType)
                    .HasColumnName("gdd_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gddid).HasColumnName("gddid");

                entity.Property(e => e.GenericDrugCode)
                    .HasColumnName("generic_drug_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Instructions)
                    .HasColumnName("instructions")
                    .HasColumnType("character varying");

                entity.Property(e => e.MppId)
                    .HasColumnName("mpp_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OtherRestrictionType)
                    .HasColumnName("other_restriction_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.OtherScheme)
                    .HasColumnName("other_scheme")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PbsItemCode)
                    .HasColumnName("pbs_item_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Repeats).HasColumnName("repeats");

                entity.Property(e => e.RestrictionCode)
                    .HasColumnName("restriction_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.RestrictionType)
                    .HasColumnName("restriction_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasColumnType("character varying");

                entity.Property(e => e.Scheme)
                    .HasColumnName("scheme")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartedOn)
                    .HasColumnName("started_on")
                    .HasColumnType("date");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("character varying");

                entity.Property(e => e.TppId)
                    .HasColumnName("tpp_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_827f19d76a");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e5ab267a7c");
            });

            modelBuilder.Entity<ObstetricsAntenatalVisitVersions>(entity =>
            {
                entity.ToTable("obstetrics_antenatal_visit_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_antenatal_visit_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_antenatal_visit_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_antenatal_visit_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_antenatal_visit_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ObstetricsAntenatalVisits>(entity =>
            {
                entity.ToTable("obstetrics_antenatal_visits");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_antenatal_visits_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_antenatal_visits_on_practice_id");

                entity.HasIndex(e => e.PregnancyId)
                    .HasName("index_obstetrics_antenatal_visits_on_pregnancy_id");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("index_obstetrics_antenatal_visits_on_provider_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BloodPressure)
                    .HasColumnName("blood_pressure")
                    .HasColumnType("character varying");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.FetalHeartRate)
                    .HasColumnName("fetal_heart_rate")
                    .HasColumnType("character varying");

                entity.Property(e => e.FetalMovement)
                    .HasColumnName("fetal_movement")
                    .HasColumnType("character varying");

                entity.Property(e => e.FundalHeight)
                    .HasColumnName("fundal_height")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.LiquorVolume)
                    .HasColumnName("liquor_volume")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocalId).HasColumnName("local_id");

                entity.Property(e => e.Oedema)
                    .HasColumnName("oedema")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyId).HasColumnName("pregnancy_id");

                entity.Property(e => e.Presentation)
                    .HasColumnName("presentation")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.Station)
                    .HasColumnName("station")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Urine)
                    .HasColumnName("urine")
                    .HasColumnType("character varying");

                entity.Property(e => e.VisitedOn)
                    .HasColumnName("visited_on")
                    .HasColumnType("date");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(10,3)");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsAntenatalVisits)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d80c525eae");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.ObstetricsAntenatalVisits)
                    .HasForeignKey(d => d.PregnancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f330502014");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ObstetricsAntenatalVisits)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d53e30d2fb");
            });

            modelBuilder.Entity<ObstetricsChildVersions>(entity =>
            {
                entity.ToTable("obstetrics_child_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_child_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_child_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_child_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_child_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ObstetricsChildren>(entity =>
            {
                entity.ToTable("obstetrics_children");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_children_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_children_on_practice_id");

                entity.HasIndex(e => e.PregnancyId)
                    .HasName("index_obstetrics_children_on_pregnancy_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Apgar1).HasColumnName("apgar1");

                entity.Property(e => e.Apgar5).HasColumnName("apgar5");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyId).HasColumnName("pregnancy_id");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(10,3)");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsChildren)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2a66bf9fcd");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.ObstetricsChildren)
                    .HasForeignKey(d => d.PregnancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_551c933428");
            });

            modelBuilder.Entity<ObstetricsInvestigationVersions>(entity =>
            {
                entity.ToTable("obstetrics_investigation_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_investigation_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_investigation_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_investigation_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_investigation_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ObstetricsInvestigations>(entity =>
            {
                entity.ToTable("obstetrics_investigations");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_investigations_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_investigations_on_practice_id");

                entity.HasIndex(e => e.PregnancyId)
                    .HasName("index_obstetrics_investigations_on_pregnancy_id");

                entity.HasIndex(e => new { e.PregnancyId, e.Type, e.Group, e.Name })
                    .HasName("idx_unique_obstetrics_investigation_pi_type_group_name")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocalId).HasColumnName("local_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyId).HasColumnName("pregnancy_id");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsInvestigations)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_7b0051e140");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.ObstetricsInvestigations)
                    .HasForeignKey(d => d.PregnancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e43cbc7115");
            });

            modelBuilder.Entity<ObstetricsObservationVersions>(entity =>
            {
                entity.ToTable("obstetrics_observation_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_observation_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_observation_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_observation_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_observation_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ObstetricsObservations>(entity =>
            {
                entity.ToTable("obstetrics_observations");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_observations_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_observations_on_practice_id");

                entity.HasIndex(e => e.PregnancyId)
                    .HasName("index_obstetrics_observations_on_pregnancy_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.LocalId).HasColumnName("local_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OccurredOn)
                    .HasColumnName("occurred_on")
                    .HasColumnType("date");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyId).HasColumnName("pregnancy_id");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsObservations)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_028231b204");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.ObstetricsObservations)
                    .HasForeignKey(d => d.PregnancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_a711b34483");
            });

            modelBuilder.Entity<ObstetricsPostnatalVisitVersions>(entity =>
            {
                entity.ToTable("obstetrics_postnatal_visit_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_postnatal_visit_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_postnatal_visit_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_postnatal_visit_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_postnatal_visit_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ObstetricsPostnatalVisits>(entity =>
            {
                entity.ToTable("obstetrics_postnatal_visits");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_postnatal_visits_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_postnatal_visits_on_practice_id");

                entity.HasIndex(e => e.PregnancyId)
                    .HasName("index_obstetrics_postnatal_visits_on_pregnancy_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BloodPressure)
                    .HasColumnName("blood_pressure")
                    .HasColumnType("character varying");

                entity.Property(e => e.BreastFeeding).HasColumnName("breast_feeding");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Contraception)
                    .HasColumnName("contraception")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.ExamAbdomen)
                    .HasColumnName("exam_abdomen")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExamBreasts)
                    .HasColumnName("exam_breasts")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExamPerineum)
                    .HasColumnName("exam_perineum")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExamPv)
                    .HasColumnName("exam_pv")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExamSpeculum)
                    .HasColumnName("exam_speculum")
                    .HasColumnType("character varying");

                entity.Property(e => e.HistoryBladder)
                    .HasColumnName("history_bladder")
                    .HasColumnType("character varying");

                entity.Property(e => e.HistoryBowels)
                    .HasColumnName("history_bowels")
                    .HasColumnType("character varying");

                entity.Property(e => e.HistoryBreasts)
                    .HasColumnName("history_breasts")
                    .HasColumnType("character varying");

                entity.Property(e => e.HistoryLochia)
                    .HasColumnName("history_lochia")
                    .HasColumnType("character varying");

                entity.Property(e => e.HistoryPerineum)
                    .HasColumnName("history_perineum")
                    .HasColumnType("character varying");

                entity.Property(e => e.NeonatalExamination)
                    .HasColumnName("neonatal_examination")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyId).HasColumnName("pregnancy_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VisitedOn)
                    .HasColumnName("visited_on")
                    .HasColumnType("date");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsPostnatalVisits)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8b46e03344");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.ObstetricsPostnatalVisits)
                    .HasForeignKey(d => d.PregnancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2a612bea9d");
            });

            modelBuilder.Entity<ObstetricsPregnancies>(entity =>
            {
                entity.ToTable("obstetrics_pregnancies");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_obstetrics_pregnancies_on_deleted_at");

                entity.HasIndex(e => e.HospitalId)
                    .HasName("index_obstetrics_pregnancies_on_hospital_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_obstetrics_pregnancies_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_pregnancies_on_practice_id");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("index_obstetrics_pregnancies_on_provider_id");

                entity.HasIndex(e => new { e.PatientId, e.Current })
                    .HasName("index_obstetrics_pregnancies_patient_id_with_current")
                    .IsUnique()
                    .HasFilter("(current AND (deleted_at IS NULL))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Accoucher)
                    .HasColumnName("accoucher")
                    .HasColumnType("character varying");

                entity.Property(e => e.AdditionalComments).HasColumnName("additional_comments");

                entity.Property(e => e.AgreedEddBasis)
                    .HasColumnName("agreed_edd_basis")
                    .HasColumnType("character varying");

                entity.Property(e => e.AgreedEddOn)
                    .HasColumnName("agreed_edd_on")
                    .HasColumnType("date");

                entity.Property(e => e.Anaesthetist)
                    .HasColumnName("anaesthetist")
                    .HasColumnType("character varying");

                entity.Property(e => e.Analgesia)
                    .HasColumnName("analgesia")
                    .HasColumnType("character varying");

                entity.Property(e => e.AsHistory).HasColumnName("as_history");

                entity.Property(e => e.BloodGroup)
                    .HasColumnName("blood_group")
                    .HasColumnType("character varying");

                entity.Property(e => e.BreastFed).HasColumnName("breast_fed");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.ConceptionType)
                    .HasColumnName("conception_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DeliveredOn)
                    .HasColumnName("delivered_on")
                    .HasColumnType("date");

                entity.Property(e => e.DeliveryMethod)
                    .HasColumnName("delivery_method")
                    .HasColumnType("character varying");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.Property(e => e.HospitalName)
                    .HasColumnName("hospital_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Induction)
                    .HasColumnName("induction")
                    .HasColumnType("character varying");

                entity.Property(e => e.LabourProblems).HasColumnName("labour_problems");

                entity.Property(e => e.LengthOfLabour)
                    .HasColumnName("length_of_labour")
                    .HasColumnType("character varying");

                entity.Property(e => e.LmpOn)
                    .HasColumnName("lmp_on")
                    .HasColumnType("date");

                entity.Property(e => e.LocalId).HasColumnName("local_id");

                entity.Property(e => e.Paediatrician)
                    .HasColumnName("paediatrician")
                    .HasColumnType("character varying");

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PlaceOfBirth)
                    .HasColumnName("place_of_birth")
                    .HasColumnType("character varying");

                entity.Property(e => e.PostBirth)
                    .HasColumnName("post_birth")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PregnancyProblems).HasColumnName("pregnancy_problems");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.TimeOfBirth)
                    .HasColumnName("time_of_birth")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.ObstetricsPregnancies)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("fk_rails_4588abcaea");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ObstetricsPregnancies)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_0db941b1c1");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ObstetricsPregnancies)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ca87b2f842");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ObstetricsPregnancies)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_rails_4bf5f87cd9");
            });

            modelBuilder.Entity<ObstetricsPregnancyVersions>(entity =>
            {
                entity.ToTable("obstetrics_pregnancy_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_obstetrics_pregnancy_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_obstetrics_pregnancy_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_obstetrics_pregnancy_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_obstetrics_pregnancy_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PastProcedureVersions>(entity =>
            {
                entity.ToTable("past_procedure_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_past_procedure_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_past_procedure_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_past_procedure_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_past_procedure_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PastProcedureVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_739a09673b");
            });

            modelBuilder.Entity<PastProcedures>(entity =>
            {
                entity.ToTable("past_procedures");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_past_procedures_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_past_procedures_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_past_procedures_on_practice_id");

                entity.HasIndex(e => e.ProcedureAttributeId)
                    .HasName("index_past_procedures_on_procedure_attribute_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("character varying");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProcedureAttributeId).HasColumnName("procedure_attribute_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PastProcedures)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_fdcb52cabe");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PastProcedures)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_740c1819c3");

                entity.HasOne(d => d.ProcedureAttribute)
                    .WithMany(p => p.PastProcedures)
                    .HasForeignKey(d => d.ProcedureAttributeId)
                    .HasConstraintName("fk_rails_2aac6e0be1");
            });

            modelBuilder.Entity<PatientReportLinkVersions>(entity =>
            {
                entity.ToTable("patient_report_link_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_patient_report_link_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_patient_report_link_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_patient_report_link_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_patient_report_link_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReportLinkVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_aae968973e");
            });

            modelBuilder.Entity<PatientReportLinks>(entity =>
            {
                entity.ToTable("patient_report_links");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_patient_report_links_on_deleted_at");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("index_patient_report_links_on_document_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_patient_report_links_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_patient_report_links_on_practice_id");

                entity.HasIndex(e => e.ReferralId)
                    .HasName("index_patient_report_links_on_referral_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReferralId).HasColumnName("referral_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.PatientReportLinks)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_55cc5164d6");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReportLinks)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_967a6b1ab8");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PatientReportLinks)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ff9ea79390");

                entity.HasOne(d => d.Referral)
                    .WithMany(p => p.PatientReportLinks)
                    .HasForeignKey(d => d.ReferralId)
                    .HasConstraintName("fk_rails_e070544297");
            });

            modelBuilder.Entity<PatientVersions>(entity =>
            {
                entity.ToTable("patient_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_patient_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_patient_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_patient_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.ToTable("patients");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_patients_on_deleted_at");

                entity.HasIndex(e => e.LastName)
                    .HasName("index_patients_on_last_name");

                entity.HasIndex(e => e.PostalAddressId)
                    .HasName("index_patients_on_postal_address_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_patients_on_practice_id");

                entity.HasIndex(e => e.ResidentialAddressId)
                    .HasName("index_patients_on_residential_address_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BornOn)
                    .HasColumnName("born_on")
                    .HasColumnType("date");

                entity.Property(e => e.ChartNumber)
                    .HasColumnName("chart_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Deceased).HasColumnName("deceased");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DiedOn)
                    .HasColumnName("died_on")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailAttachmentPassword)
                    .HasColumnName("email_attachment_password")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailDisabled).HasColumnName("email_disabled");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.HomePhone)
                    .HasColumnName("home_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.IndigenousStatus).HasColumnName("indigenous_status");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MaidenName)
                    .HasColumnName("maiden_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasColumnType("character varying");

                entity.Property(e => e.PostalAddressId).HasColumnName("postal_address_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PreferredName)
                    .HasColumnName("preferred_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResidentialAddressId).HasColumnName("residential_address_id");

                entity.Property(e => e.SmsDisabled).HasColumnName("sms_disabled");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UseResidentialAddress)
                    .IsRequired()
                    .HasColumnName("use_residential_address")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.PostalAddress)
                    .WithMany(p => p.PatientsPostalAddress)
                    .HasForeignKey(d => d.PostalAddressId)
                    .HasConstraintName("fk_rails_036ace2616");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_1ca2824dd9");

                entity.HasOne(d => d.ResidentialAddress)
                    .WithMany(p => p.PatientsResidentialAddress)
                    .HasForeignKey(d => d.ResidentialAddressId)
                    .HasConstraintName("fk_rails_ee2142bf1c");
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.ToTable("permissions");

                entity.HasIndex(e => e.Name)
                    .HasName("index_permissions_on_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PracticeVersions>(entity =>
            {
                entity.ToTable("practice_versions");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_practice_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_practice_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Practices>(entity =>
            {
                entity.ToTable("practices");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_practices_on_deleted_at");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("index_practices_on_location_code")
                    .IsUnique();

                entity.HasIndex(e => e.StateId)
                    .HasName("index_practices_on_state_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Abn)
                    .HasColumnName("abn")
                    .HasColumnType("character varying");

                entity.Property(e => e.BillingAgentId)
                    .HasColumnName("billing_agent_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.CapricornUrl)
                    .HasColumnName("capricorn_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentSoftware)
                    .HasColumnName("current_software")
                    .HasColumnType("character varying");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DvaAccountId).HasColumnName("dva_account_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailEnabled).HasColumnName("email_enabled");

                entity.Property(e => e.EmailReplyAddress)
                    .HasColumnName("email_reply_address")
                    .HasColumnType("character varying");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("character varying");

                entity.Property(e => e.HealthlinkIdentifier)
                    .HasColumnName("healthlink_identifier")
                    .HasColumnType("character varying");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("location_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicalObjectsDeliveryReportUrl)
                    .HasColumnName("medical_objects_delivery_report_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicalObjectsIdentifier)
                    .HasColumnName("medical_objects_identifier")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicareAccountId).HasColumnName("medicare_account_id");

                entity.Property(e => e.Modules).HasColumnName("modules");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeType)
                    .HasColumnName("practice_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RtacNumber)
                    .HasColumnName("rtac_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.SmsAlerts).HasColumnName("sms_alerts");

                entity.Property(e => e.SmsEnabled).HasColumnName("sms_enabled");

                entity.Property(e => e.SmsPlatformServiceEnabledAt).HasColumnName("sms_platform_service_enabled_at");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Street1)
                    .HasColumnName("street_1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Street2)
                    .HasColumnName("street_2")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubscriptionCount)
                    .HasColumnName("subscription_count")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Suburb)
                    .HasColumnName("suburb")
                    .HasColumnType("character varying");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasColumnName("timezone")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.DvaAccount)
                    .WithMany(p => p.PracticesDvaAccount)
                    .HasForeignKey(d => d.DvaAccountId)
                    .HasConstraintName("fk_rails_f4d2019ca5");

                entity.HasOne(d => d.MedicareAccount)
                    .WithMany(p => p.PracticesMedicareAccount)
                    .HasForeignKey(d => d.MedicareAccountId)
                    .HasConstraintName("fk_rails_3e309bdc9e");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Practices)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ab64445772");
            });

            modelBuilder.Entity<PracticesSpecialties>(entity =>
            {
                entity.ToTable("practices_specialties");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_practices_specialties_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_practices_specialties_on_practice_id");

                entity.HasIndex(e => e.SpecialtyId)
                    .HasName("index_practices_specialties_on_specialty_id");

                entity.HasIndex(e => new { e.PracticeId, e.SpecialtyId })
                    .HasName("index_practices_specialties_on_practice_id_and_specialty_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.SpecialtyId).HasColumnName("specialty_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticesSpecialties)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_7f6c44d0e1");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.PracticesSpecialties)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_d5ce5916ac");
            });

            modelBuilder.Entity<Preferences>(entity =>
            {
                entity.ToTable("preferences");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_preferences_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_preferences_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppointmentDuration)
                    .HasColumnName("appointment_duration")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.AppointmentReminderSchedule)
                    .IsRequired()
                    .HasColumnName("appointment_reminder_schedule")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'3_working_days_prior'::character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DayEndTime)
                    .IsRequired()
                    .HasColumnName("day_end_time")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'17:00'::character varying");

                entity.Property(e => e.DayStartTime)
                    .IsRequired()
                    .HasColumnName("day_start_time")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'08:30'::character varying");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3e99e19044");
            });

            modelBuilder.Entity<PrescriptionAuthorities>(entity =>
            {
                entity.ToTable("prescription_authorities");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_prescription_authorities_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_prescription_authorities_on_practice_id");

                entity.HasIndex(e => e.PrescriptionId)
                    .HasName("index_prescription_authorities_on_prescription_id");

                entity.HasIndex(e => new { e.PracticeId, e.PrescriptionId, e.DeletedAt })
                    .HasName("idx_unique_prescription_authority_prescription")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.AuthorityCode)
                    .HasColumnName("authority_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.AuthorityFormNumberId).HasColumnName("authority_form_number_id");

                entity.Property(e => e.ClinicalReason)
                    .HasColumnName("clinical_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EmergencyCallAt).HasColumnName("emergency_call_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrescriptionId).HasColumnName("prescription_id");

                entity.Property(e => e.RestrictionCode)
                    .IsRequired()
                    .HasColumnName("restriction_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PrescriptionAuthorities)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_aa335607cc");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionAuthorities)
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3d972f107a");
            });

            modelBuilder.Entity<PrescriptionAuthorityVersions>(entity =>
            {
                entity.ToTable("prescription_authority_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_prescription_authority_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_prescription_authority_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_prescription_authority_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PrescriptionMedications>(entity =>
            {
                entity.ToTable("prescription_medications");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_prescription_medications_on_deleted_at");

                entity.HasIndex(e => e.MedicationId)
                    .HasName("index_prescription_medications_on_medication_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_prescription_medications_on_practice_id");

                entity.HasIndex(e => e.PrescriptionId)
                    .HasName("index_prescription_medications_on_prescription_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.MedicationId).HasColumnName("medication_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrescriptionId).HasColumnName("prescription_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PrescriptionMedications)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b3e2ca21f0");
            });

            modelBuilder.Entity<PrescriptionVersions>(entity =>
            {
                entity.ToTable("prescription_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_prescription_versions_on_item_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_prescription_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_prescription_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_prescription_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PrescriptionVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6a28991f3f");
            });

            modelBuilder.Entity<Prescriptions>(entity =>
            {
                entity.ToTable("prescriptions");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_prescriptions_on_deleted_at");

                entity.HasIndex(e => e.FirstScriptId)
                    .HasName("index_prescriptions_on_first_script_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_prescriptions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_prescriptions_on_practice_id");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("index_prescriptions_on_provider_id");

                entity.HasIndex(e => new { e.PracticeId, e.NumberId })
                    .HasName("idx_unique_prescription_number")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.FirstScriptId).HasColumnName("first_script_id");

                entity.Property(e => e.NumberId).HasColumnName("number_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrescriberName)
                    .HasColumnName("prescriber_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PrescriberNumber)
                    .HasColumnName("prescriber_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PrescriberType)
                    .HasColumnName("prescriber_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_bede94f0a0");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_93e9209d8b");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_fa80e708be");
            });

            modelBuilder.Entity<PrintTemplates>(entity =>
            {
                entity.ToTable("print_templates");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_print_templates_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_print_templates_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.LetterheadId).HasColumnName("letterhead_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TemplateConfig)
                    .HasColumnName("template_config")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'LetterBodyTemplate'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PrintTemplates)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_1c71dbe20a");
            });

            modelBuilder.Entity<PrivateMbsFeeVersions>(entity =>
            {
                entity.ToTable("private_mbs_fee_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_private_mbs_fee_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_private_mbs_fee_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_private_mbs_fee_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PrivateMbsFees>(entity =>
            {
                entity.ToTable("private_mbs_fees");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_private_mbs_fees_on_deleted_at");

                entity.HasIndex(e => e.MbsBillingItemId)
                    .HasName("index_private_mbs_fees_on_mbs_billing_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_private_mbs_fees_on_practice_id");

                entity.HasIndex(e => new { e.PracticeId, e.MbsBillingItemId })
                    .HasName("index_private_mbs_fees_on_practice_id_and_mbs_billing_item_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MbsBillingItemId).HasColumnName("mbs_billing_item_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.MbsBillingItem)
                    .WithMany(p => p.PrivateMbsFees)
                    .HasForeignKey(d => d.MbsBillingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_5d777d5f70");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PrivateMbsFees)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_6916bd079e");
            });

            modelBuilder.Entity<ProcedureCategories>(entity =>
            {
                entity.ToTable("procedure_categories");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_procedure_categories_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_procedure_categories_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ProcedureCategories)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8c63319432");
            });

            modelBuilder.Entity<ProcedureReferenceVersions>(entity =>
            {
                entity.ToTable("procedure_reference_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_procedure_reference_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_procedure_reference_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_procedure_reference_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ProcedureReferences>(entity =>
            {
                entity.ToTable("procedure_references");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_procedure_references_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_procedure_references_on_practice_id");

                entity.HasIndex(e => e.ProcedureAttributeId)
                    .HasName("index_procedure_references_on_procedure_attribute_id");

                entity.HasIndex(e => e.ProcedureId)
                    .HasName("index_procedure_references_on_procedure_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Optional).HasColumnName("optional");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProcedureAttributeId).HasColumnName("procedure_attribute_id");

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ProcedureReferences)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_796d4f236a");

                entity.HasOne(d => d.ProcedureAttribute)
                    .WithMany(p => p.ProcedureReferences)
                    .HasForeignKey(d => d.ProcedureAttributeId)
                    .HasConstraintName("fk_rails_9a57831815");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureReferences)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_80d5d420bb");
            });

            modelBuilder.Entity<ProcedureVersions>(entity =>
            {
                entity.ToTable("procedure_versions");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_procedure_versions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_procedure_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_procedure_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_procedure_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ProcedureVersions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_66c48a8770");
            });

            modelBuilder.Entity<Procedures>(entity =>
            {
                entity.ToTable("procedures");

                entity.HasIndex(e => e.AnaesthetistContactId)
                    .HasName("index_procedures_on_anaesthetist_contact_id");

                entity.HasIndex(e => e.AssistantContactId)
                    .HasName("index_procedures_on_assistant_contact_id");

                entity.HasIndex(e => e.BusinessContactId)
                    .HasName("index_procedures_on_business_contact_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_procedures_on_deleted_at");

                entity.HasIndex(e => e.PaediatricianContactId)
                    .HasName("index_procedures_on_paediatrician_contact_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_procedures_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_procedures_on_practice_id");

                entity.HasIndex(e => e.RestrictedById)
                    .HasName("index_procedures_on_restricted_by_id");

                entity.HasIndex(e => e.StartsAt)
                    .HasName("index_procedures_on_starts_at");

                entity.HasIndex(e => e.ThirdPartyClaimId)
                    .HasName("index_procedures_on_third_party_claim_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_procedures_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AdmittedOn)
                    .HasColumnName("admitted_on")
                    .HasColumnType("date");

                entity.Property(e => e.Anaesthetic)
                    .HasColumnName("anaesthetic")
                    .HasColumnType("character varying");

                entity.Property(e => e.AnaesthetistContactId).HasColumnName("anaesthetist_contact_id");

                entity.Property(e => e.Asa).HasColumnName("asa");

                entity.Property(e => e.AssistantContactId).HasColumnName("assistant_contact_id");

                entity.Property(e => e.Billed).HasColumnName("billed");

                entity.Property(e => e.BloodLoss)
                    .HasColumnName("blood_loss")
                    .HasColumnType("character varying");

                entity.Property(e => e.BusinessContactId).HasColumnName("business_contact_id");

                entity.Property(e => e.ConsentSigned).HasColumnName("consent_signed");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Findings).HasColumnName("findings");

                entity.Property(e => e.FollowedUpOn)
                    .HasColumnName("followed_up_on")
                    .HasColumnType("date");

                entity.Property(e => e.InfectionRisk)
                    .HasColumnName("infection_risk")
                    .HasColumnType("character varying");

                entity.Property(e => e.InpatientNights).HasColumnName("inpatient_nights");

                entity.Property(e => e.InvoiceNotRequired).HasColumnName("invoice_not_required");

                entity.Property(e => e.Left).HasColumnName("left");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Outcomes).HasColumnName("outcomes");

                entity.Property(e => e.PaediatricianContactId).HasColumnName("paediatrician_contact_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PostOpNotes).HasColumnName("post_op_notes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PreOpNotes).HasColumnName("pre_op_notes");

                entity.Property(e => e.ProcedureCategoryId).HasColumnName("procedure_category_id");

                entity.Property(e => e.ProcedureType)
                    .HasColumnName("procedure_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Prosthetic)
                    .HasColumnName("prosthetic")
                    .HasColumnType("character varying");

                entity.Property(e => e.RestrictedAt).HasColumnName("restricted_at");

                entity.Property(e => e.RestrictedById).HasColumnName("restricted_by_id");

                entity.Property(e => e.Right).HasColumnName("right");

                entity.Property(e => e.SpecificOutcomes).HasColumnName("specific_outcomes");

                entity.Property(e => e.StartsAt).HasColumnName("starts_at");

                entity.Property(e => e.Technique).HasColumnName("technique");

                entity.Property(e => e.ThirdPartyClaimId).HasColumnName("third_party_claim_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.Urgency)
                    .HasColumnName("urgency")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AnaesthetistContact)
                    .WithMany(p => p.ProceduresAnaesthetistContact)
                    .HasForeignKey(d => d.AnaesthetistContactId)
                    .HasConstraintName("fk_rails_de4d431634");

                entity.HasOne(d => d.AssistantContact)
                    .WithMany(p => p.ProceduresAssistantContact)
                    .HasForeignKey(d => d.AssistantContactId)
                    .HasConstraintName("fk_rails_ac6eb84909");

                entity.HasOne(d => d.BusinessContact)
                    .WithMany(p => p.ProceduresBusinessContact)
                    .HasForeignKey(d => d.BusinessContactId)
                    .HasConstraintName("fk_rails_85c841b9dd");

                entity.HasOne(d => d.PaediatricianContact)
                    .WithMany(p => p.ProceduresPaediatricianContact)
                    .HasForeignKey(d => d.PaediatricianContactId)
                    .HasConstraintName("fk_rails_a73d99b976");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e348695adf");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ce1bbbb5e8");

                entity.HasOne(d => d.ProcedureCategory)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.ProcedureCategoryId)
                    .HasConstraintName("fk_rails_75ba713562");

                entity.HasOne(d => d.RestrictedBy)
                    .WithMany(p => p.ProceduresRestrictedBy)
                    .HasForeignKey(d => d.RestrictedById)
                    .HasConstraintName("fk_rails_0f4da2a8d1");

                entity.HasOne(d => d.ThirdPartyClaim)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.ThirdPartyClaimId)
                    .HasConstraintName("fk_rails_63b68563f1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProceduresUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3bdefac50f");
            });

            modelBuilder.Entity<ReasonsForEncounter>(entity =>
            {
                entity.ToTable("reasons_for_encounter");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_reasons_for_encounter_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_reasons_for_encounter_on_practice_id");

                entity.HasIndex(e => new { e.Reason, e.PracticeId, e.DeletedAt })
                    .HasName("index_reasons_for_encounter_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ReasonsForEncounter)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_c84113c1e2");
            });

            modelBuilder.Entity<RecallVersions>(entity =>
            {
                entity.ToTable("recall_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_recall_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_recall_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RecipientVersions>(entity =>
            {
                entity.ToTable("recipient_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_recipient_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_recipient_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_recipient_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Recipients>(entity =>
            {
                entity.ToTable("recipients");

                entity.HasIndex(e => e.ContactableId)
                    .HasName("index_recipients_on_contactable_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_recipients_on_deleted_at");

                entity.HasIndex(e => e.LetterId)
                    .HasName("index_recipients_on_letter_id");

                entity.HasIndex(e => e.MessageUuid)
                    .HasName("index_recipients_on_message_uuid")
                    .IsUnique();

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_recipients_on_practice_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_recipients_on_type");

                entity.HasIndex(e => new { e.ContactableId, e.ContactableType })
                    .HasName("index_recipients_on_contactable_id_and_contactable_type");

                entity.HasIndex(e => new { e.PracticeId, e.MessageId })
                    .HasName("index_recipients_on_practice_id_and_message_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AckAt).HasColumnName("ack_at");

                entity.Property(e => e.AckError)
                    .HasColumnName("ack_error")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.AckType)
                    .HasColumnName("ack_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.AckUuids).HasColumnName("ack_uuids");

                entity.Property(e => e.AckedBy)
                    .HasColumnName("acked_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactMethod)
                    .IsRequired()
                    .HasColumnName("contact_method")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactableId).HasColumnName("contactable_id");

                entity.Property(e => e.ContactableType)
                    .IsRequired()
                    .HasColumnName("contactable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.LetterId).HasColumnName("letter_id");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageUuid)
                    .HasColumnName("message_uuid")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrintedAt).HasColumnName("printed_at");

                entity.Property(e => e.SentAt).HasColumnName("sent_at");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'Addressee'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Letter)
                    .WithMany(p => p.Recipients)
                    .HasForeignKey(d => d.LetterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_4722933229");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Recipients)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e1aa27c7a6");
            });

            modelBuilder.Entity<ReferralVersions>(entity =>
            {
                entity.ToTable("referral_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_referral_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_referral_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_referral_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Referrals>(entity =>
            {
                entity.ToTable("referrals");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_referrals_on_deleted_at");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_referrals_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_referrals_on_practice_id");

                entity.HasIndex(e => e.ReferringDoctorId)
                    .HasName("index_referrals_on_referring_doctor_id");

                entity.HasIndex(e => e.StartedOn)
                    .HasName("index_referrals_on_started_on");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Indefinite).HasColumnName("indefinite");

                entity.Property(e => e.IssuedOn)
                    .HasColumnName("issued_on")
                    .HasColumnType("date");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReferringDoctorId).HasColumnName("referring_doctor_id");

                entity.Property(e => e.StartedOn)
                    .HasColumnName("started_on")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.UploadFile)
                    .HasColumnName("upload_file")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_dfe2ea70f8");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_22e78f4aa0");

                entity.HasOne(d => d.ReferringDoctor)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.ReferringDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ee369baa0c");
            });

            modelBuilder.Entity<ReportLinkSuggestions>(entity =>
            {
                entity.ToTable("report_link_suggestions");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_report_link_suggestions_on_deleted_at");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("index_report_link_suggestions_on_document_id");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_report_link_suggestions_on_patient_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_report_link_suggestions_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.ReportLinkSuggestions)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_85afce94db");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ReportLinkSuggestions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ade5de6995");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ReportLinkSuggestions)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_574aa9cc73");
            });

            modelBuilder.Entity<RequestLabProviders>(entity =>
            {
                entity.ToTable("request_lab_providers");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_request_lab_providers_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_request_lab_providers_on_practice_id");

                entity.HasIndex(e => e.RequestLabId)
                    .HasName("index_request_lab_providers_on_request_lab_id");

                entity.HasIndex(e => new { e.RequestLabId, e.UserId })
                    .HasName("index_request_lab_providers_on_request_lab_id_and_user_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DoctorCode)
                    .HasColumnName("doctor_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.RequestLabId).HasColumnName("request_lab_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.RequestLabProviders)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3c83151d20");

                entity.HasOne(d => d.RequestLab)
                    .WithMany(p => p.RequestLabProviders)
                    .HasForeignKey(d => d.RequestLabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_654b76adaa");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestLabProviders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_fb4f20a710");
            });

            modelBuilder.Entity<RequestLabs>(entity =>
            {
                entity.ToTable("request_labs");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_request_labs_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_request_labs_on_practice_id");

                entity.HasIndex(e => new { e.Name, e.PracticeId, e.DeletedAt })
                    .HasName("index_request_labs_on_name_and_practice_id_and_deleted_at")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("contact_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("citext");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.RequestLabs)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_56d4a341a5");
            });

            modelBuilder.Entity<RolePermissionVersions>(entity =>
            {
                entity.ToTable("role_permission_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_role_permission_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_role_permission_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.ToTable("role_permissions");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_role_permissions_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_role_permissions_on_practice_id");

                entity.HasIndex(e => new { e.PracticeId, e.RoleId, e.PermissionId })
                    .HasName("index_role_permissions_on_practice_id_role_id_permission_id")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_439e640a3f");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_10ffaa6725");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_60126080bd");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_roles_on_deleted_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_roles_on_name");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_roles_on_practice_id");

                entity.HasIndex(e => new { e.PracticeId, e.Name })
                    .HasName("index_roles_on_practice_id_and_name")
                    .IsUnique()
                    .HasFilter("(deleted_at IS NULL)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_50099adac5");
            });

            modelBuilder.Entity<SchemaMigrations>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("schema_migrations_pkey");

                entity.ToTable("schema_migrations");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("character varying")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ScreeningInteractions>(entity =>
            {
                entity.ToTable("screening_interactions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_screening_interactions_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'unknown'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ScreeningInteractions)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_328a4de613");
            });

            modelBuilder.Entity<ScreeningOverrideReasons>(entity =>
            {
                entity.ToTable("screening_override_reasons");

                entity.HasIndex(e => e.Position)
                    .HasName("index_screening_override_reasons_on_position");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ScreeningOverrides>(entity =>
            {
                entity.ToTable("screening_overrides");

                entity.HasIndex(e => e.InteractionId)
                    .HasName("index_screening_overrides_on_interaction_id");

                entity.HasIndex(e => e.MedicationId)
                    .HasName("index_screening_overrides_on_medication_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_screening_overrides_on_practice_id");

                entity.HasIndex(e => e.ReasonId)
                    .HasName("index_screening_overrides_on_reason_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.AdditionalText)
                    .HasColumnName("additional_text")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.InteractionId).HasColumnName("interaction_id");

                entity.Property(e => e.MedicationId).HasColumnName("medication_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReasonId).HasColumnName("reason_id");

                entity.Property(e => e.ReasonText)
                    .HasColumnName("reason_text")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Interaction)
                    .WithMany(p => p.ScreeningOverrides)
                    .HasForeignKey(d => d.InteractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2b5d901708");

                entity.HasOne(d => d.Medication)
                    .WithMany(p => p.ScreeningOverrides)
                    .HasForeignKey(d => d.MedicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_cfa3c3667c");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ScreeningOverrides)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ea00f982b0");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.ScreeningOverrides)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("fk_rails_5d8416afa4");
            });

            modelBuilder.Entity<ServiceVersions>(entity =>
            {
                entity.ToTable("service_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_service_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_service_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_service_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.ToTable("services");

                entity.HasIndex(e => e.ClaimId)
                    .HasName("index_services_on_claim_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_services_on_deleted_at");

                entity.HasIndex(e => e.InvoiceItemId)
                    .HasName("index_services_on_invoice_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_services_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BenefitAmount)
                    .HasColumnName("benefit_amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ChargeAmount)
                    .HasColumnName("charge_amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.ExplanationCode)
                    .HasColumnName("explanation_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.HealthFundExplanation)
                    .HasColumnName("health_fund_explanation")
                    .HasColumnType("jsonb");

                entity.Property(e => e.InvoiceItemId).HasColumnName("invoice_item_id");

                entity.Property(e => e.MedicareServiceId)
                    .IsRequired()
                    .HasColumnName("medicare_service_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.MedicareVoucherId)
                    .IsRequired()
                    .HasColumnName("medicare_voucher_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Resolved)
                    .HasColumnName("resolved")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ed410cb2a4");

                entity.HasOne(d => d.InvoiceItem)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.InvoiceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_94c1c0d8c3");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_73ac98bfd1");
            });

            modelBuilder.Entity<SiteOfServiceVersions>(entity =>
            {
                entity.ToTable("site_of_service_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_site_of_service_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_site_of_service_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_site_of_service_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SitesOfService>(entity =>
            {
                entity.ToTable("sites_of_service");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_sites_of_service_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_sites_of_service_on_practice_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_sites_of_service_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EquipmentNumber)
                    .HasColumnName("equipment_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.Lspn)
                    .HasColumnName("lspn")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("provider_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.SitesOfService)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_bc9ab55183");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SitesOfService)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_890798869b");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.ToTable("states");

                entity.HasIndex(e => e.Code)
                    .HasName("index_states_on_code")
                    .IsUnique();

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_states_on_deleted_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TermsAcceptances>(entity =>
            {
                entity.ToTable("terms_acceptances");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_terms_acceptances_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_terms_acceptances_on_practice_id");

                entity.HasIndex(e => e.TermsAndConditionId)
                    .HasName("index_terms_acceptances_on_terms_and_condition_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_terms_acceptances_on_user_id");

                entity.HasIndex(e => new { e.UserId, e.TermsAndConditionId })
                    .HasName("index_terms_acceptances_on_user_id_and_terms_and_condition_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TermsAndConditionId).HasColumnName("terms_and_condition_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.TermsAcceptances)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_004670fce6");

                entity.HasOne(d => d.TermsAndCondition)
                    .WithMany(p => p.TermsAcceptances)
                    .HasForeignKey(d => d.TermsAndConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_8ba9e6071e");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TermsAcceptances)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_fd06c20803");
            });

            modelBuilder.Entity<TermsAndConditions>(entity =>
            {
                entity.ToTable("terms_and_conditions");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_terms_and_conditions_on_deleted_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_terms_and_conditions_on_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ThirdPartyClaimVersions>(entity =>
            {
                entity.ToTable("third_party_claim_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_third_party_claim_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_third_party_claim_versions_on_transaction_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ThirdPartyClaims>(entity =>
            {
                entity.ToTable("third_party_claims");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_third_party_claims_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_third_party_claims_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CaseManager)
                    .HasColumnName("case_manager")
                    .HasColumnType("character varying");

                entity.Property(e => e.CaseManagerEmail)
                    .HasColumnName("case_manager_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.CaseManagerFax)
                    .HasColumnName("case_manager_fax")
                    .HasColumnType("character varying");

                entity.Property(e => e.CaseManagerPhone)
                    .HasColumnName("case_manager_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimNumber)
                    .HasColumnName("claim_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EmployerId).HasColumnName("employer_id");

                entity.Property(e => e.InjuredOn)
                    .HasColumnName("injured_on")
                    .HasColumnType("date");

                entity.Property(e => e.Injury)
                    .IsRequired()
                    .HasColumnName("injury")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.ThirdPartyClaimsEmployer)
                    .HasForeignKey(d => d.EmployerId)
                    .HasConstraintName("fk_rails_10c3222b94");

                entity.HasOne(d => d.Insurer)
                    .WithMany(p => p.ThirdPartyClaimsInsurer)
                    .HasForeignKey(d => d.InsurerId)
                    .HasConstraintName("fk_rails_588737d3d6");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ThirdPartyClaims)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_51eb083a17");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ThirdPartyClaims)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_cce7e4fa09");
            });

            modelBuilder.Entity<ToDoCommentVersions>(entity =>
            {
                entity.ToTable("to_do_comment_versions");

                entity.HasIndex(e => e.ItemId)
                    .HasName("index_to_do_comment_versions_on_item_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_to_do_comment_versions_on_practice_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ToDoComments>(entity =>
            {
                entity.ToTable("to_do_comments");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_to_do_comments_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_to_do_comments_on_practice_id");

                entity.HasIndex(e => e.ToDoId)
                    .HasName("index_to_do_comments_on_to_do_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_to_do_comments_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ToDoId).HasColumnName("to_do_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ToDoComments)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_85efbde16c");

                entity.HasOne(d => d.ToDo)
                    .WithMany(p => p.ToDoComments)
                    .HasForeignKey(d => d.ToDoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_82b09e80f6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ToDoComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_707ee33d95");
            });

            modelBuilder.Entity<ToDoVersions>(entity =>
            {
                entity.ToTable("to_do_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_to_do_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_to_do_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_to_do_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ToDos>(entity =>
            {
                entity.ToTable("to_dos");

                entity.HasIndex(e => e.CompletedAt)
                    .HasName("index_to_dos_on_completed_at");

                entity.HasIndex(e => e.CompleterId)
                    .HasName("index_to_dos_on_completer_id");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_to_dos_on_deleted_at");

                entity.HasIndex(e => e.DueOn)
                    .HasName("index_to_dos_on_due_on");

                entity.HasIndex(e => e.PatientId)
                    .HasName("index_to_dos_on_patient_id");

                entity.HasIndex(e => e.PatientReportLinkId)
                    .HasName("index_to_dos_on_patient_report_link_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_to_dos_on_practice_id");

                entity.HasIndex(e => e.RemindOn)
                    .HasName("index_to_dos_on_remind_on");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasColumnName("action_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CompletedAt).HasColumnName("completed_at");

                entity.Property(e => e.CompleterId).HasColumnName("completer_id");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DueOn)
                    .HasColumnName("due_on")
                    .HasColumnType("date");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.EntityType)
                    .HasColumnName("entity_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Important).HasColumnName("important");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("character varying");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PatientReportLinkId).HasColumnName("patient_report_link_id");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.RemindOn)
                    .HasColumnName("remind_on")
                    .HasColumnType("date");

                entity.Property(e => e.ReminderSettings)
                    .HasColumnName("reminder_settings")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'ToDo'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.HasOne(d => d.Completer)
                    .WithMany(p => p.ToDos)
                    .HasForeignKey(d => d.CompleterId)
                    .HasConstraintName("fk_rails_39364e23ea");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ToDos)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("fk_rails_5bcbeede29");

                entity.HasOne(d => d.PatientReportLink)
                    .WithMany(p => p.ToDos)
                    .HasForeignKey(d => d.PatientReportLinkId)
                    .HasConstraintName("fk_rails_0f7ee13f32");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.ToDos)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_2d73879bba");
            });

            modelBuilder.Entity<Txns>(entity =>
            {
                entity.ToTable("txns");

                entity.HasIndex(e => e.AccountId)
                    .HasName("index_txns_on_account_id");

                entity.HasIndex(e => e.IsPayment)
                    .HasName("index_txns_on_is_payment");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_txns_on_practice_id");

                entity.HasIndex(e => e.ReversedPaymentId)
                    .HasName("index_txns_on_reversed_payment_id");

                entity.HasIndex(e => e.TransactedAt)
                    .HasName("index_txns_on_transacted_at");

                entity.HasIndex(e => e.TxnType)
                    .HasName("index_txns_on_txn_type");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_txns_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailedAt).HasColumnName("emailed_at");

                entity.Property(e => e.Gst)
                    .HasColumnName("gst")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.IsPayment).HasColumnName("is_payment");

                entity.Property(e => e.PaymentReference)
                    .HasColumnName("payment_reference")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReversedPaymentId).HasColumnName("reversed_payment_id");

                entity.Property(e => e.TransactedAt).HasColumnName("transacted_at");

                entity.Property(e => e.TxnType)
                    .IsRequired()
                    .HasColumnName("txn_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdaterId).HasColumnName("updater_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Txns)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_e0c5568969");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Txns)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_f9051fe065");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Txns)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_da4e89bd76");
            });

            modelBuilder.Entity<UserVersions>(entity =>
            {
                entity.ToTable("user_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_user_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_user_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_user_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.ConfirmationToken)
                    .HasName("index_users_on_confirmation_token")
                    .IsUnique();

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_users_on_deleted_at");

                entity.HasIndex(e => e.Email)
                    .HasName("index_users_on_email")
                    .IsUnique();

                entity.HasIndex(e => e.InvitationToken)
                    .HasName("index_users_on_invitation_token")
                    .IsUnique();

                entity.HasIndex(e => e.InvitationsCount)
                    .HasName("index_users_on_invitations_count");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_users_on_practice_id");

                entity.HasIndex(e => e.ResetPasswordToken)
                    .HasName("index_users_on_reset_password_token")
                    .IsUnique();

                entity.HasIndex(e => e.RoleId)
                    .HasName("index_users_on_role_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_users_unique_system_user")
                    .IsUnique()
                    .HasFilter("((type)::text = 'SystemUser'::text)");

                entity.HasIndex(e => e.UnlockToken)
                    .HasName("index_users_on_unlock_token")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Abn)
                    .HasColumnName("abn")
                    .HasColumnType("character varying");

                entity.Property(e => e.AllowNotifications).HasColumnName("allow_notifications");

                entity.Property(e => e.ClinicalInteractionsEnabled).HasColumnName("clinical_interactions_enabled");

                entity.Property(e => e.ConfirmationSentAt).HasColumnName("confirmation_sent_at");

                entity.Property(e => e.ConfirmationToken)
                    .HasColumnName("confirmation_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ConfirmedAt).HasColumnName("confirmed_at");

                entity.Property(e => e.ConsumedTimestep).HasColumnName("consumed_timestep");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentSignInAt).HasColumnName("current_sign_in_at");

                entity.Property(e => e.CurrentSignInIp).HasColumnName("current_sign_in_ip");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedOtpSecret)
                    .HasColumnName("encrypted_otp_secret")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedOtpSecretIv)
                    .HasColumnName("encrypted_otp_secret_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedOtpSecretSalt)
                    .HasColumnName("encrypted_otp_secret_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedPassword)
                    .HasColumnName("encrypted_password")
                    .HasColumnType("character varying");

                entity.Property(e => e.FailedAttempts).HasColumnName("failed_attempts");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InvitationAcceptedAt).HasColumnName("invitation_accepted_at");

                entity.Property(e => e.InvitationCreatedAt).HasColumnName("invitation_created_at");

                entity.Property(e => e.InvitationLimit).HasColumnName("invitation_limit");

                entity.Property(e => e.InvitationSentAt).HasColumnName("invitation_sent_at");

                entity.Property(e => e.InvitationToken)
                    .HasColumnName("invitation_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.InvitationsCount)
                    .HasColumnName("invitations_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvitedById).HasColumnName("invited_by_id");

                entity.Property(e => e.InvitedByType)
                    .HasColumnName("invited_by_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");

                entity.Property(e => e.LastSignInIp).HasColumnName("last_sign_in_ip");

                entity.Property(e => e.LockedAt).HasColumnName("locked_at");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.OtpBackupCodes)
                    .HasColumnName("otp_backup_codes")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.OtpRequiredForLogin).HasColumnName("otp_required_for_login");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.PrescriberNumber)
                    .HasColumnName("prescriber_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PrescriberType)
                    .HasColumnName("prescriber_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RememberCreatedAt).HasColumnName("remember_created_at");

                entity.Property(e => e.ResetPasswordSentAt).HasColumnName("reset_password_sent_at");

                entity.Property(e => e.ResetPasswordToken)
                    .HasColumnName("reset_password_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.ShowInAppts).HasColumnName("show_in_appts");

                entity.Property(e => e.SignInCount).HasColumnName("sign_in_count");

                entity.Property(e => e.TimeoutDuration).HasColumnName("timeout_duration");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'User'::character varying");

                entity.Property(e => e.UnconfirmedEmail)
                    .HasColumnName("unconfirmed_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.UnlockToken)
                    .HasColumnName("unlock_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_8be9b4f78d");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("fk_rails_642f17018b");
            });

            modelBuilder.Entity<UsersToDos>(entity =>
            {
                entity.ToTable("users_to_dos");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_users_to_dos_on_deleted_at");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_users_to_dos_on_practice_id");

                entity.HasIndex(e => e.ToDoId)
                    .HasName("index_users_to_dos_on_to_do_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_users_to_dos_on_user_id");

                entity.HasIndex(e => new { e.UserId, e.ToDoId, e.DeletedAt })
                    .HasName("index_users_to_dos_on_user_id_and_to_do_id_and_deleted_at")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ToDoId).HasColumnName("to_do_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.UsersToDos)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_9d41e922a1");

                entity.HasOne(d => d.ToDo)
                    .WithMany(p => p.UsersToDos)
                    .HasForeignKey(d => d.ToDoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3a4d0dcea2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersToDos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_4141bfbef5");
            });

            modelBuilder.Entity<VoucherVersions>(entity =>
            {
                entity.ToTable("voucher_versions");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_voucher_versions_on_practice_id");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("index_voucher_versions_on_transaction_id");

                entity.HasIndex(e => new { e.ItemType, e.ItemId })
                    .HasName("idx_voucher_ver_it_ii");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasColumnType("jsonb");

                entity.Property(e => e.ObjectChanges)
                    .HasColumnName("object_changes")
                    .HasColumnType("jsonb");

                entity.Property(e => e.OldObject).HasColumnName("old_object");

                entity.Property(e => e.OldObjectChanges).HasColumnName("old_object_changes");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Whodunnit)
                    .HasColumnName("whodunnit")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Vouchers>(entity =>
            {
                entity.ToTable("vouchers");

                entity.HasIndex(e => e.DeletedAt)
                    .HasName("index_vouchers_on_deleted_at");

                entity.HasIndex(e => e.InvoiceItemsCount)
                    .HasName("index_vouchers_on_invoice_items_count");

                entity.HasIndex(e => e.InvoiceableId)
                    .HasName("index_vouchers_on_invoiceable_id");

                entity.HasIndex(e => e.PracticeId)
                    .HasName("index_vouchers_on_practice_id");

                entity.HasIndex(e => e.ReferralId)
                    .HasName("index_vouchers_on_referral_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DistanceTravelled).HasColumnName("distance_travelled");

                entity.Property(e => e.InvoiceItemsCount).HasColumnName("invoice_items_count");

                entity.Property(e => e.InvoiceableId).HasColumnName("invoiceable_id");

                entity.Property(e => e.NoReferralReason)
                    .HasColumnName("no_referral_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.PracticeId).HasColumnName("practice_id");

                entity.Property(e => e.ReferralId).HasColumnName("referral_id");

                entity.Property(e => e.ServiceTime)
                    .HasColumnName("service_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.ServicedOn)
                    .HasColumnName("serviced_on")
                    .HasColumnType("date");

                entity.Property(e => e.ServicingProviderId).HasColumnName("servicing_provider_id");

                entity.Property(e => e.ServicingProviderType)
                    .IsRequired()
                    .HasColumnName("servicing_provider_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.TreatmentLocation)
                    .HasColumnName("treatment_location")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Invoiceable)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.InvoiceableId)
                    .HasConstraintName("fk_rails_c891f69306");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_3b254e711f");

                entity.HasOne(d => d.Referral)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.ReferralId)
                    .HasConstraintName("fk_rails_b8305fea09");
            });
        }
    }
}
