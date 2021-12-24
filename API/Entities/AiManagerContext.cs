using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public partial class AiManagerContext : IdentityDbContext<User>
    {
        public AiManagerContext()
        {
        }

        public AiManagerContext(DbContextOptions<AiManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbpAuditLog> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJob> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpDynamicEntityProperty> AbpDynamicEntityProperties { get; set; }
        public virtual DbSet<AbpDynamicEntityPropertyValue> AbpDynamicEntityPropertyValues { get; set; }
        public virtual DbSet<AbpDynamicProperty> AbpDynamicProperties { get; set; }
        public virtual DbSet<AbpDynamicPropertyValue> AbpDynamicPropertyValues { get; set; }
        public virtual DbSet<AbpEdition> AbpEditions { get; set; }
        public virtual DbSet<AbpEntityChange> AbpEntityChanges { get; set; }
        public virtual DbSet<AbpEntityChangeSet> AbpEntityChangeSets { get; set; }
        public virtual DbSet<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }
        public virtual DbSet<AbpFeature> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguage> AbpLanguages { get; set; }
        public virtual DbSet<AbpLanguageText> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpNotification> AbpNotifications { get; set; }
        public virtual DbSet<AbpNotificationSubscription> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpOrganizationUnit> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }
        public virtual DbSet<AbpPermission> AbpPermissions { get; set; }
        public virtual DbSet<AbpPersistedGrant> AbpPersistedGrants { get; set; }
        public virtual DbSet<AbpRole> AbpRoles { get; set; }
        public virtual DbSet<AbpRoleClaim> AbpRoleClaims { get; set; }
        public virtual DbSet<AbpSetting> AbpSettings { get; set; }
        public virtual DbSet<AbpTenant> AbpTenants { get; set; }
        public virtual DbSet<AbpTenantNotification> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpUser> AbpUsers { get; set; }
        public virtual DbSet<AbpUserAccount> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserClaim> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserLoginAttempt> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserNotification> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRole> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUserToken> AbpUserTokens { get; set; }
        public virtual DbSet<AbpWebhookEvent> AbpWebhookEvents { get; set; }
        public virtual DbSet<AbpWebhookSendAttempt> AbpWebhookSendAttempts { get; set; }
        public virtual DbSet<AbpWebhookSubscription> AbpWebhookSubscriptions { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AlembicVersion> AlembicVersions { get; set; }
        public virtual DbSet<AppBinaryObject> AppBinaryObjects { get; set; }
        public virtual DbSet<AppChatMessage> AppChatMessages { get; set; }
        public virtual DbSet<AppFriendship> AppFriendships { get; set; }
        public virtual DbSet<AppInvoice> AppInvoices { get; set; }
        public virtual DbSet<AppSubscriptionPayment> AppSubscriptionPayments { get; set; }
        public virtual DbSet<AppSubscriptionPaymentsExtensionDatum> AppSubscriptionPaymentsExtensionData { get; set; }
        public virtual DbSet<AppUserDelegation> AppUserDelegations { get; set; }
        public virtual DbSet<AverageSentimentByDataSource> AverageSentimentByDataSources { get; set; }
        public virtual DbSet<AverageSentimentByProduct> AverageSentimentByProducts { get; set; }
        public virtual DbSet<AvgSentimentTopicLevel1> AvgSentimentTopicLevel1s { get; set; }
        public virtual DbSet<AvgSentimentTopicLevel2> AvgSentimentTopicLevel2s { get; set; }
        public virtual DbSet<AvgSentimentTopicLevel3> AvgSentimentTopicLevel3s { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<DataSource> DataSources { get; set; }
        public virtual DbSet<GrowthLevel1> GrowthLevel1s { get; set; }
        public virtual DbSet<GrowthLevel2> GrowthLevel2s { get; set; }
        public virtual DbSet<GrowthLevel3> GrowthLevel3s { get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<Mention> Mentions { get; set; }
        public virtual DbSet<MostSearchedLevel2Topic> MostSearchedLevel2Topics { get; set; }
        public virtual DbSet<MostSearchedLevel3Topic> MostSearchedLevel3Topics { get; set; }
        public virtual DbSet<MostSearchedTopicLevel1> MostSearchedTopicLevel1s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductClassification> ProductClassifications { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductsAmazonReview> ProductsAmazonReviews { get; set; }
        public virtual DbSet<ProductsAmazonSearch> ProductsAmazonSearches { get; set; }
        public virtual DbSet<ProductsBbbReview> ProductsBbbReviews { get; set; }
        public virtual DbSet<ProductsBbbSearch> ProductsBbbSearches { get; set; }
        public virtual DbSet<ProductsBk> ProductsBks { get; set; }
        public virtual DbSet<ProductsFacebookSearch> ProductsFacebookSearches { get; set; }
        public virtual DbSet<ProductsFoursquareReview> ProductsFoursquareReviews { get; set; }
        public virtual DbSet<ProductsFoursquareSearch> ProductsFoursquareSearches { get; set; }
        public virtual DbSet<ProductsImdbReview> ProductsImdbReviews { get; set; }
        public virtual DbSet<ProductsImdbSearch> ProductsImdbSearches { get; set; }
        public virtual DbSet<ProductsMantaReview> ProductsMantaReviews { get; set; }
        public virtual DbSet<ProductsMantaSearch> ProductsMantaSearches { get; set; }
        public virtual DbSet<ProductsTripAdvisorReview> ProductsTripAdvisorReviews { get; set; }
        public virtual DbSet<ProductsTripAdvisorSearch> ProductsTripAdvisorSearches { get; set; }
        public virtual DbSet<ProductsTrustPilotReview> ProductsTrustPilotReviews { get; set; }
        public virtual DbSet<ProductsTrustPilotSearch> ProductsTrustPilotSearches { get; set; }
        public virtual DbSet<ProductsTwitterSearch> ProductsTwitterSearches { get; set; }
        public virtual DbSet<ProductsYellowPagesReview> ProductsYellowPagesReviews { get; set; }
        public virtual DbSet<ProductsYellowPagesSearch> ProductsYellowPagesSearches { get; set; }
        public virtual DbSet<ProductsYelpReview> ProductsYelpReviews { get; set; }
        public virtual DbSet<ProductsYelpSearch> ProductsYelpSearches { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Search> Searches { get; set; }
        public virtual DbSet<SearchVolumeByMonth> SearchVolumeByMonths { get; set; }
        public virtual DbSet<SentimentDecreaseLevel1> SentimentDecreaseLevel1s { get; set; }
        public virtual DbSet<SentimentDecreaseLevel2> SentimentDecreaseLevel2s { get; set; }
        public virtual DbSet<SentimentDecreaseLevel3> SentimentDecreaseLevel3s { get; set; }
        public virtual DbSet<TimePeriod> TimePeriods { get; set; }
        public virtual DbSet<TopicCategory> TopicCategories { get; set; }
        public virtual DbSet<TopicLevel1> TopicLevel1s { get; set; }
        public virtual DbSet<TopicLevel1Mention> TopicLevel1Mentions { get; set; }
        public virtual DbSet<TopicLevel2> TopicLevel2s { get; set; }
        public virtual DbSet<TopicLevel2Mention> TopicLevel2Mentions { get; set; }
        public virtual DbSet<TopicLevel3> TopicLevel3s { get; set; }
        public virtual DbSet<TopicLevel3Mention> TopicLevel3Mentions { get; set; }
        public virtual DbSet<TotalSearchVolumeTopicLevel1> TotalSearchVolumeTopicLevel1s { get; set; }
        public virtual DbSet<TotalSearchVolumeTopicLevel2> TotalSearchVolumeTopicLevel2s { get; set; }
        public virtual DbSet<TotalSearchVolumeTopicLevel3> TotalSearchVolumeTopicLevel3s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                 optionsBuilder.UseSqlServer("Server=.\\;Database=AiManager;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>()
                       .HasData(
                           new IdentityRole{Name = "Member", NormalizedName = "MEMBER"},
                           new IdentityRole{Name = "Admin", NormalizedName = "ADMIN"}
                       );

            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AbpAuditLog>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ExecutionDuration }, "IX_AbpAuditLogs_TenantId_ExecutionDuration");

                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_ExecutionTime");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpAuditLogs_TenantId_UserId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.ExceptionMessage).HasMaxLength(1024);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJob>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime }, "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<AbpDynamicEntityProperty>(entity =>
            {
                entity.HasIndex(e => e.DynamicPropertyId, "IX_AbpDynamicEntityProperties_DynamicPropertyId");

                entity.HasIndex(e => new { e.EntityFullName, e.DynamicPropertyId, e.TenantId }, "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId")
                    .IsUnique()
                    .HasFilter("([EntityFullName] IS NOT NULL AND [TenantId] IS NOT NULL)");

                entity.Property(e => e.EntityFullName).HasMaxLength(256);

                entity.HasOne(d => d.DynamicProperty)
                    .WithMany(p => p.AbpDynamicEntityProperties)
                    .HasForeignKey(d => d.DynamicPropertyId);
            });

            modelBuilder.Entity<AbpDynamicEntityPropertyValue>(entity =>
            {
                entity.HasIndex(e => e.DynamicEntityPropertyId, "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.DynamicEntityProperty)
                    .WithMany(p => p.AbpDynamicEntityPropertyValues)
                    .HasForeignKey(d => d.DynamicEntityPropertyId);
            });

            modelBuilder.Entity<AbpDynamicProperty>(entity =>
            {
                entity.HasIndex(e => new { e.PropertyName, e.TenantId }, "IX_AbpDynamicProperties_PropertyName_TenantId")
                    .IsUnique()
                    .HasFilter("([PropertyName] IS NOT NULL AND [TenantId] IS NOT NULL)");

                entity.Property(e => e.PropertyName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpDynamicPropertyValue>(entity =>
            {
                entity.HasIndex(e => e.DynamicPropertyId, "IX_AbpDynamicPropertyValues_DynamicPropertyId");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.DynamicProperty)
                    .WithMany(p => p.AbpDynamicPropertyValues)
                    .HasForeignKey(d => d.DynamicPropertyId);
            });

            modelBuilder.Entity<AbpEdition>(entity =>
            {
                entity.Property(e => e.AnnualPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DailyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MonthlyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.WeeklyPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AbpEntityChange>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeSetId, "IX_AbpEntityChanges_EntityChangeSetId");

                entity.HasIndex(e => new { e.EntityTypeFullName, e.EntityId }, "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

                entity.Property(e => e.EntityId).HasMaxLength(48);

                entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.EntityChangeSetId);
            });

            modelBuilder.Entity<AbpEntityChangeSet>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.CreationTime }, "IX_AbpEntityChangeSets_TenantId_CreationTime");

                entity.HasIndex(e => new { e.TenantId, e.Reason }, "IX_AbpEntityChangeSets_TenantId_Reason");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpEntityChangeSets_TenantId_UserId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Reason).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpEntityPropertyChange>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeId, "IX_AbpEntityPropertyChanges_EntityChangeId");

                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName).HasMaxLength(96);

                entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeature>(entity =>
            {
                entity.HasIndex(e => new { e.EditionId, e.Name }, "IX_AbpFeatures_EditionId_Name");

                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpFeatures_TenantId_Name");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpLanguages_TenantId_Name");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.IsDisabled)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<AbpLanguageText>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Source, e.LanguageName, e.Key }, "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotificationSubscription>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId }, "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId }, "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnit>(entity =>
            {
                entity.HasIndex(e => e.ParentId, "IX_AbpOrganizationUnits_ParentId");

                entity.HasIndex(e => new { e.TenantId, e.Code }, "IX_AbpOrganizationUnits_TenantId_Code");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(95);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpOrganizationUnitRole>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId }, "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.RoleId }, "IX_AbpOrganizationUnitRoles_TenantId_RoleId");
            });

            modelBuilder.Entity<AbpPermission>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AbpPermissions_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpPermissions_TenantId_Name");

                entity.HasIndex(e => e.UserId, "IX_AbpPermissions_UserId");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpPersistedGrant>(entity =>
            {
                entity.HasIndex(e => e.Expiration, "IX_AbpPersistedGrants_Expiration");

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_AbpPersistedGrants_SubjectId_ClientId_Type");

                entity.HasIndex(e => new { e.SubjectId, e.SessionId, e.Type }, "IX_AbpPersistedGrants_SubjectId_SessionId_Type");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.SessionId).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AbpRole>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId, "IX_AbpRoles_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpRoles_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpRoles_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedName }, "IX_AbpRoles_TenantId_NormalizedName");

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRoleCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRoleDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRoleLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AbpRoleClaims_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_AbpRoleClaims_TenantId_ClaimType");

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpSetting>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name, e.UserId }, "IX_AbpSettings_TenantId_Name_UserId")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "IX_AbpSettings_UserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpTenant>(entity =>
            {
                entity.HasIndex(e => e.CreationTime, "IX_AbpTenants_CreationTime");

                entity.HasIndex(e => e.CreatorUserId, "IX_AbpTenants_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpTenants_DeleterUserId");

                entity.HasIndex(e => e.EditionId, "IX_AbpTenants_EditionId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpTenants_LastModifierUserId");

                entity.HasIndex(e => e.SubscriptionEndDateUtc, "IX_AbpTenants_SubscriptionEndDateUtc");

                entity.HasIndex(e => e.TenancyName, "IX_AbpTenants_TenancyName");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.IsInTrialPeriod)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LogoFileType).HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpTenantNotification>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_AbpTenantNotifications_TenantId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpUser>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId, "IX_AbpUsers_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpUsers_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpUsers_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedEmailAddress }, "IX_AbpUsers_TenantId_NormalizedEmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedUserName }, "IX_AbpUsers_TenantId_NormalizedUserName");

                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.NormalizedEmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.SecurityStamp).HasMaxLength(128);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpUserAccount>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress, "IX_AbpUserAccounts_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.EmailAddress }, "IX_AbpUserAccounts_TenantId_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserAccounts_TenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.UserName }, "IX_AbpUserAccounts_TenantId_UserName");

                entity.HasIndex(e => e.UserName, "IX_AbpUserAccounts_UserName");

                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaim>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_AbpUserClaims_TenantId_ClaimType");

                entity.HasIndex(e => e.UserId, "IX_AbpUserClaims_UserId");

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLogin>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.LoginProvider, e.ProviderKey }, "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserLogins_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLoginAttempt>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result }, "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

                entity.HasIndex(e => new { e.UserId, e.TenantId }, "IX_AbpUserLoginAttempts_UserId_TenantId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserNotification>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime }, "IX_AbpUserNotifications_UserId_State_CreationTime");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpUserOrganizationUnit>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId }, "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserOrganizationUnits_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserOrganizationUnits_UserId");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserOrganizationUnits)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserRole>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.RoleId }, "IX_AbpUserRoles_TenantId_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserRoles_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserRoles_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserToken>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserTokens_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserTokens_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpWebhookEvent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.WebhookName).IsRequired();
            });

            modelBuilder.Entity<AbpWebhookSendAttempt>(entity =>
            {
                entity.HasIndex(e => e.WebhookEventId, "IX_AbpWebhookSendAttempts_WebhookEventId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.WebhookEvent)
                    .WithMany(p => p.AbpWebhookSendAttempts)
                    .HasForeignKey(d => d.WebhookEventId);
            });

            modelBuilder.Entity<AbpWebhookSubscription>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Secret).IsRequired();

                entity.Property(e => e.WebhookUri).IsRequired();
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.Name, "uq_accounts_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_on");
            });

            modelBuilder.Entity<AlembicVersion>(entity =>
            {
                entity.HasKey(e => e.VersionNum)
                    .HasName("alembic_version_pkc");

                entity.ToTable("alembic_version");

                entity.Property(e => e.VersionNum)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("version_num");
            });

            modelBuilder.Entity<AppBinaryObject>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_AppBinaryObjects_TenantId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bytes).IsRequired();
            });

            modelBuilder.Entity<AppChatMessage>(entity =>
            {
                entity.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_TargetUserId_ReadState");

                entity.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_UserId_ReadState");

                entity.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TenantId_TargetUserId_ReadState");

                entity.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TenantId_UserId_ReadState");

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<AppFriendship>(entity =>
            {
                entity.HasIndex(e => new { e.FriendTenantId, e.FriendUserId }, "IX_AppFriendships_FriendTenantId_FriendUserId");

                entity.HasIndex(e => new { e.FriendTenantId, e.UserId }, "IX_AppFriendships_FriendTenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.FriendUserId }, "IX_AppFriendships_TenantId_FriendUserId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AppFriendships_TenantId_UserId");

                entity.Property(e => e.FriendUserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AppSubscriptionPayment>(entity =>
            {
                entity.HasIndex(e => e.EditionId, "IX_AppSubscriptionPayments_EditionId");

                entity.HasIndex(e => new { e.ExternalPaymentId, e.Gateway }, "IX_AppSubscriptionPayments_ExternalPaymentId_Gateway");

                entity.HasIndex(e => new { e.Status, e.CreationTime }, "IX_AppSubscriptionPayments_Status_CreationTime");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsRecurring)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AppSubscriptionPayments)
                    .HasForeignKey(d => d.EditionId);
            });

            modelBuilder.Entity<AppSubscriptionPaymentsExtensionDatum>(entity =>
            {
                entity.HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted }, "IX_AppSubscriptionPaymentsExtensionData_SubscriptionPaymentId_Key_IsDeleted")
                    .IsUnique()
                    .HasFilter("([Key] IS NOT NULL)");
            });

            modelBuilder.Entity<AppUserDelegation>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.SourceUserId }, "IX_AppUserDelegations_TenantId_SourceUserId");

                entity.HasIndex(e => new { e.TenantId, e.TargetUserId }, "IX_AppUserDelegations_TenantId_TargetUserId");
            });

            modelBuilder.Entity<AverageSentimentByDataSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AverageSentimentByDataSource");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AverageSentimentByProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AverageSentimentByProducts");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AvgSentimentTopicLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvgSentimentTopicLevel1");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AvgSentimentTopicLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvgSentimentTopicLevel2");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AvgSentimentTopicLevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvgSentimentTopicLevel3");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Brands_TenantId");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Competitions_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DataSource>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_DataSources_TenantId");

                entity.Property(e => e.SourceDescription).HasMaxLength(200);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GrowthLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GrowthLevel1");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GrowthLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GrowthLevel2");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GrowthLevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GrowthLevel3");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Markets_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Mention>(entity =>
            {
                entity.HasIndex(e => e.DataSourceId, "IX_Mentions_DataSourceId");

                entity.HasIndex(e => e.DateKey, "IX_Mentions_DateKey");

                entity.HasIndex(e => e.LanguageId, "IX_Mentions_LanguageId");

                entity.HasIndex(e => e.MarketId, "IX_Mentions_MarketId");

                entity.HasIndex(e => e.ProductId, "IX_Mentions_ProductId");

                entity.HasIndex(e => e.RegionId, "IX_Mentions_RegionId");

                entity.HasIndex(e => e.TopicLevel1Id, "IX_Mentions_TopicLevel1Id");

                entity.HasIndex(e => e.TopicLevel2Id, "IX_Mentions_TopicLevel2Id");

                entity.HasIndex(e => e.TopicLevel3Id, "IX_Mentions_TopicLevel3Id");

                entity.Property(e => e.KeyTerms).HasMaxLength(500);

                entity.Property(e => e.RawSource)
                    .IsRequired(false)
                    .HasMaxLength(4000);

                entity.Property(e => e.Recommendation).HasMaxLength(500);

                entity.Property(e => e.SourceUserId).HasMaxLength(1000);

                entity.HasOne(d => d.DataSource)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.DataSourceId);

                entity.HasOne(d => d.DateKeyNavigation)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.DateKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mention_TimePeriod");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.LanguageId);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.MarketId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.RegionId);

                entity.HasOne(d => d.TopicLevel1)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.TopicLevel1Id);

                entity.HasOne(d => d.TopicLevel2)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.TopicLevel2Id);

                entity.HasOne(d => d.TopicLevel3)
                    .WithMany(p => p.Mentions)
                    .HasForeignKey(d => d.TopicLevel3Id);
            });

            modelBuilder.Entity<MostSearchedLevel2Topic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MostSearchedLevel2Topic");

                entity.Property(e => e.KeyTerms).HasMaxLength(500);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MostSearchedLevel3Topic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MostSearchedLevel3Topic");

                entity.Property(e => e.KeyTerms).HasMaxLength(500);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MostSearchedTopicLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MostSearchedTopicLevel1");

                entity.Property(e => e.KeyTerms).HasMaxLength(500);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.BrandId, "IX_Products_BrandId");

                entity.HasIndex(e => e.CompetitionId, "IX_Products_CompetitionId");

                entity.HasIndex(e => e.ProductClassificationId, "IX_Products_ProductClassificationId");

                entity.HasIndex(e => e.ProductTypeId, "IX_Products_ProductTypeId");

                entity.HasIndex(e => e.TenantId, "IX_Products_TenantId");

                entity.HasIndex(e => e.TopicCategoryId, "IX_Products_TopicCategoryId");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CompetitionId);

                entity.HasOne(d => d.ProductClassification)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductClassificationId);

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId);

                entity.HasOne(d => d.TopicCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TopicCategoryId);
            });

            modelBuilder.Entity<ProductClassification>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_ProductClassifications_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_ProductTypes_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductsAmazonReview>(entity =>
            {
                entity.ToTable("products_amazon_reviews");

                entity.HasIndex(e => e.AmazonId, "IX_products_amazon_reviews_amazon_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmazonId).HasColumnName("amazon_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Reaction).HasColumnName("reaction");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.Amazon)
                    .WithMany(p => p.ProductsAmazonReviews)
                    .HasForeignKey(d => d.AmazonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_amazon_reviews_amazon_id_products_amazon_search");
            });

            modelBuilder.Entity<ProductsAmazonSearch>(entity =>
            {
                entity.ToTable("products_amazon_search");

                entity.HasIndex(e => e.ItemId, "uq_products_amazon_search_item_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CreatedOn1).HasColumnName("CreatedOn");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkToAllReviews).HasColumnName("link_to_all_reviews");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumberOfRating).HasColumnName("number_of_rating");

                entity.Property(e => e.NumberOfReviews).HasColumnName("number_of_reviews");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductDescription).HasColumnName("product_description");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.ProductInformation).HasColumnName("product_information");

                entity.Property(e => e.ProductVariants).HasColumnName("product_variants");

                entity.Property(e => e.ReviewsByComments).HasColumnName("reviews_by_comments");

                entity.Property(e => e.ReviewsByRating).HasColumnName("reviews_by_rating");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.ShortDescription).HasColumnName("short_description");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.UpdatedOn1).HasColumnName("UpdatedOn");
            });

            modelBuilder.Entity<ProductsBbbReview>(entity =>
            {
                entity.ToTable("products_bbb_reviews");

                entity.HasIndex(e => e.BbbId, "IX_products_bbb_reviews_bbb_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BbbId).HasColumnName("bbb_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Reaction).HasColumnName("reaction");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.Bbb)
                    .WithMany(p => p.ProductsBbbReviews)
                    .HasForeignKey(d => d.BbbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_bbb_reviews_bbb_id_products_bbb_search");
            });

            modelBuilder.Entity<ProductsBbbSearch>(entity =>
            {
                entity.ToTable("products_bbb_search");

                entity.HasIndex(e => e.BusId, "uq_products_bbb_search_bus_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accredited).HasColumnName("accredited");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.BbbFileOpened).HasColumnName("bbbFileOpened");

                entity.Property(e => e.BbbRating).HasColumnName("bbbRating");

                entity.Property(e => e.BusId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bus_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessStart).HasColumnName("businessStart");

                entity.Property(e => e.Categories).HasColumnName("categories");

                entity.Property(e => e.ComplaintTypes).HasColumnName("complaintTypes");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Incorporated).HasColumnName("incorporated");

                entity.Property(e => e.IsAccredited).HasColumnName("isAccredited");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumOfReviews).HasColumnName("num_of_reviews");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.TypeOfEntity).HasColumnName("typeOfEntity");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.YearsInBusiness).HasColumnName("yearsInBusiness");
            });

            modelBuilder.Entity<ProductsBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Products_bk");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductsFacebookSearch>(entity =>
            {
                entity.ToTable("products_facebook_search");

                entity.HasIndex(e => e.PostId, "uq_products_facebook_search_post_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CommentsFull).HasColumnName("comments_full");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CreatedOn1).HasColumnName("CreatedOn");

                entity.Property(e => e.Factcheck).HasColumnName("factcheck");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.ImagesLowquality).HasColumnName("images_lowquality");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsLive).HasColumnName("is_live");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("post_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostText).HasColumnName("post_text");

                entity.Property(e => e.PostUrl).HasColumnName("post_url");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.Reactions).HasColumnName("reactions");

                entity.Property(e => e.Reactors).HasColumnName("reactors");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.SharedPostId).HasColumnName("shared_post_id");

                entity.Property(e => e.SharedPostUrl).HasColumnName("shared_post_url");

                entity.Property(e => e.SharedText).HasColumnName("shared_text");

                entity.Property(e => e.SharedTime).HasColumnName("shared_time");

                entity.Property(e => e.SharedUserId).HasColumnName("shared_user_id");

                entity.Property(e => e.SharedUsername).HasColumnName("shared_username");

                entity.Property(e => e.Shares).HasColumnName("shares");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.UpdatedOn1).HasColumnName("UpdatedOn");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserUrl).HasColumnName("user_url");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.Video).HasColumnName("video");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.VideoThumbnail).HasColumnName("video_thumbnail");

                entity.Property(e => e.W3FbUrl).HasColumnName("w3_fb_url");
            });

            modelBuilder.Entity<ProductsFoursquareReview>(entity =>
            {
                entity.ToTable("products_foursquare_reviews");

                entity.HasIndex(e => e.FoursquareId, "IX_products_foursquare_reviews_foursquare_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DownVote).HasColumnName("down_vote");

                entity.Property(e => e.FoursquareId).HasColumnName("foursquare_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.UpVote).HasColumnName("up_vote");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.Property(e => e.UserJustification).HasColumnName("user_justification");

                entity.HasOne(d => d.Foursquare)
                    .WithMany(p => p.ProductsFoursquareReviews)
                    .HasForeignKey(d => d.FoursquareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_foursquare_reviews_foursquare_id_products_foursquare_search");
            });

            modelBuilder.Entity<ProductsFoursquareSearch>(entity =>
            {
                entity.ToTable("products_foursquare_search");

                entity.HasIndex(e => e.BusId, "uq_products_foursquare_search_bus_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.BusId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bus_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.Descrption).HasColumnName("descrption");

                entity.Property(e => e.Features).HasColumnName("features");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Justification).HasColumnName("justification");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumOfReviews).HasColumnName("num_of_reviews");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Tippets).HasColumnName("tippets");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.Varieties).HasColumnName("varieties");
            });

            modelBuilder.Entity<ProductsImdbReview>(entity =>
            {
                entity.ToTable("products_imdb_reviews");

                entity.HasIndex(e => e.ImdbId, "IX_products_imdb_reviews_imdb_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Helpful).HasColumnName("helpful");

                entity.Property(e => e.ImdbId).HasColumnName("imdb_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Reactions).HasColumnName("reactions");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.Imdb)
                    .WithMany(p => p.ProductsImdbReviews)
                    .HasForeignKey(d => d.ImdbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_imdb_reviews_imdb_id_products_imdb_search");
            });

            modelBuilder.Entity<ProductsImdbSearch>(entity =>
            {
                entity.ToTable("products_imdb_search");

                entity.HasIndex(e => e.Title, "uq_products_imdb_search_title")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.BestRating).HasColumnName("bestRating");

                entity.Property(e => e.Cast).HasColumnName("cast");

                entity.Property(e => e.ContentRating).HasColumnName("content_rating");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.DatePublished).HasColumnName("date_published");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Director).HasColumnName("director");

                entity.Property(e => e.Genre).HasColumnName("genre");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Keywords).HasColumnName("keywords");

                entity.Property(e => e.MovieDuration).HasColumnName("movie_duration");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.NumOfRevies).HasColumnName("num_of_revies");

                entity.Property(e => e.NumberOfCritics).HasColumnName("number_of_critics");

                entity.Property(e => e.NumberOfReviews).HasColumnName("number_of_reviews");

                entity.Property(e => e.Popularity).HasColumnName("popularity");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.Storyline).HasColumnName("storyline");

                entity.Property(e => e.Summary).HasColumnName("summary");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.WorstRating).HasColumnName("worstRating");

                entity.Property(e => e.Writer).HasColumnName("writer");
            });

            modelBuilder.Entity<ProductsMantaReview>(entity =>
            {
                entity.ToTable("products_manta_reviews");

                entity.HasIndex(e => e.MantaId, "IX_products_manta_reviews_manta_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.MantaId).HasColumnName("manta_id");

                entity.Property(e => e.Reaction).HasColumnName("reaction");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.Manta)
                    .WithMany(p => p.ProductsMantaReviews)
                    .HasForeignKey(d => d.MantaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_manta_reviews_manta_id_products_manta_search");
            });

            modelBuilder.Entity<ProductsMantaSearch>(entity =>
            {
                entity.ToTable("products_manta_search");

                entity.HasIndex(e => e.Title, "uq_products_manta_search_title")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.Cast).HasColumnName("cast");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CreatedOn1).HasColumnName("CreatedOn");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.MovieDuration).HasColumnName("movie_duration");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.MovieInfo).HasColumnName("movie_info");

                entity.Property(e => e.NumOfRevies).HasColumnName("num_of_revies");

                entity.Property(e => e.NumberOfCritics).HasColumnName("number_of_critics");

                entity.Property(e => e.NumberOfReviews).HasColumnName("number_of_reviews");

                entity.Property(e => e.PlotKeywords).HasColumnName("plot_keywords");

                entity.Property(e => e.Popularity).HasColumnName("popularity");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductId1).HasColumnName("ProductId");

                entity.Property(e => e.ReviewLink).HasColumnName("review_link");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Storyline).HasColumnName("storyline");

                entity.Property(e => e.Summary).HasColumnName("summary");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.UpdatedOn1).HasColumnName("UpdatedOn");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ProductsTripAdvisorReview>(entity =>
            {
                entity.ToTable("products_trip_advisor_reviews");

                entity.HasIndex(e => e.TripAdvisorId, "IX_products_trip_advisor_reviews_trip_advisor_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Reaction).HasColumnName("reaction");

                entity.Property(e => e.TripAdvisorId).HasColumnName("trip_advisor_id");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.TripAdvisor)
                    .WithMany(p => p.ProductsTripAdvisorReviews)
                    .HasForeignKey(d => d.TripAdvisorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_trip_advisor_reviews_trip_advisor_id_products_trip_advisor_search");
            });

            modelBuilder.Entity<ProductsTripAdvisorSearch>(entity =>
            {
                entity.ToTable("products_trip_advisor_search");

                entity.HasIndex(e => e.BizId, "uq_products_trip_advisor_search_bizId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressCountry).HasColumnName("addressCountry");

                entity.Property(e => e.AddressLocality).HasColumnName("addressLocality");

                entity.Property(e => e.AddressRegion).HasColumnName("addressRegion");

                entity.Property(e => e.AggregateRatingValue).HasColumnName("aggregate_rating_value");

                entity.Property(e => e.AggregateReviewCount).HasColumnName("aggregate_review_count");

                entity.Property(e => e.BizId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bizId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessUrl).HasColumnName("businessUrl");

                entity.Property(e => e.Categories).HasColumnName("categories");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CreatedOn1).HasColumnName("CreatedOn");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Faq).HasColumnName("faq");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Neighborhoods).HasColumnName("neighborhoods");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.PostalCode).HasColumnName("postalCode");

                entity.Property(e => e.PriceRange).HasColumnName("priceRange");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductId1).HasColumnName("ProductId");

                entity.Property(e => e.Review).HasColumnName("review");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.StreetAddress).HasColumnName("streetAddress");

                entity.Property(e => e.Tags).HasColumnName("tags");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.UpdatedOn1).HasColumnName("UpdatedOn");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ProductsTrustPilotReview>(entity =>
            {
                entity.ToTable("products_trust_pilot_reviews");

                entity.HasIndex(e => e.TrustPilotId, "IX_products_trust_pilot_reviews_trust_pilot_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.TrustPilotId).HasColumnName("trust_pilot_id");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.TrustPilot)
                    .WithMany(p => p.ProductsTrustPilotReviews)
                    .HasForeignKey(d => d.TrustPilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_trust_pilot_reviews_trust_pilot_id_products_trust_pilot_search");
            });

            modelBuilder.Entity<ProductsTrustPilotSearch>(entity =>
            {
                entity.ToTable("products_trust_pilot_search");

                entity.HasIndex(e => e.BusId, "uq_products_trust_pilot_search_bus_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressCountry).HasColumnName("addressCountry");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.BestRating).HasColumnName("bestRating");

                entity.Property(e => e.BusId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bus_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumberOfRatings).HasColumnName("number_of_ratings");

                entity.Property(e => e.NumberOfReviews).HasColumnName("number_of_reviews");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.ReviewSummary).HasColumnName("review_summary");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.WorstRating).HasColumnName("worstRating");
            });

            modelBuilder.Entity<ProductsTwitterSearch>(entity =>
            {
                entity.ToTable("products_twitter_search");

                entity.HasIndex(e => e.TweetId, "uq_products_twitter_search_tweet_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cashtags).HasColumnName("cashtags");

                entity.Property(e => e.ConversationId)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("conversation_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Geo).HasColumnName("geo");

                entity.Property(e => e.Hashtags).HasColumnName("hashtags");

                entity.Property(e => e.Hour).HasColumnName("hour");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Language).HasColumnName("language");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Near).HasColumnName("near");

                entity.Property(e => e.Nlikes).HasColumnName("nlikes");

                entity.Property(e => e.Nreplies).HasColumnName("nreplies");

                entity.Property(e => e.Nretweets).HasColumnName("nretweets");

                entity.Property(e => e.Photos).HasColumnName("photos");

                entity.Property(e => e.Place).HasColumnName("place");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.QuoteUrl).HasColumnName("quote_url");

                entity.Property(e => e.ReplyTo).HasColumnName("reply_to");

                entity.Property(e => e.Retweet).HasColumnName("retweet");

                entity.Property(e => e.RetweetDate).HasColumnName("retweet_date");

                entity.Property(e => e.RetweetId).HasColumnName("retweet_id");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.Thumbnail).HasColumnName("thumbnail");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.TransDest).HasColumnName("trans_dest");

                entity.Property(e => e.TransSrc).HasColumnName("trans_src");

                entity.Property(e => e.Translate).HasColumnName("translate");

                entity.Property(e => e.Tweet).HasColumnName("tweet");

                entity.Property(e => e.TweetId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tweet_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Urls).HasColumnName("urls");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIdStr).HasColumnName("user_id_str");

                entity.Property(e => e.UserRt).HasColumnName("user_rt");

                entity.Property(e => e.UserRtId).HasColumnName("user_rt_id");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.Video).HasColumnName("video");
            });

            modelBuilder.Entity<ProductsYellowPagesReview>(entity =>
            {
                entity.ToTable("products_yellow_pages_reviews");

                entity.HasIndex(e => e.YellowPagesId, "IX_products_yellow_pages_reviews_yellow_pages_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Helpful).HasColumnName("helpful");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.Property(e => e.YellowPagesId).HasColumnName("yellow_pages_id");

                entity.HasOne(d => d.YellowPages)
                    .WithMany(p => p.ProductsYellowPagesReviews)
                    .HasForeignKey(d => d.YellowPagesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_yellow_pages_reviews_yellow_pages_id_products_yellow_pages_search");
            });

            modelBuilder.Entity<ProductsYellowPagesSearch>(entity =>
            {
                entity.ToTable("products_yellow_pages_search");

                entity.HasIndex(e => e.PostId, "uq_products_yellow_pages_search_post_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.BusinessInfo).HasColumnName("business_info");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("business_name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessPage).HasColumnName("business_page");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedOn1).HasColumnName("created_on");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ListingUrl).HasColumnName("listing_url");

                entity.Property(e => e.Locality).HasColumnName("locality");

                entity.Property(e => e.NumberOfRatings).HasColumnName("number_of_ratings");

                entity.Property(e => e.NumberOfReviews).HasColumnName("number_of_reviews");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("post_id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductId1).HasColumnName("product_id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Reviews).HasColumnName("reviews");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.Property(e => e.UpdatedOn1).HasColumnName("updated_on");

                entity.Property(e => e.Website).HasColumnName("website");

                entity.Property(e => e.YearsInBusiness).HasColumnName("years_in_business");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            modelBuilder.Entity<ProductsYelpReview>(entity =>
            {
                entity.ToTable("products_yelp_reviews");

                entity.HasIndex(e => e.YelpId, "IX_products_yelp_reviews_yelp_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentRating).HasColumnName("comment_rating");

                entity.Property(e => e.Cool).HasColumnName("cool");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Funny).HasColumnName("funny");

                entity.Property(e => e.Helpful).HasColumnName("helpful");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.Property(e => e.YelpId).HasColumnName("yelp_id");

                entity.HasOne(d => d.Yelp)
                    .WithMany(p => p.ProductsYelpReviews)
                    .HasForeignKey(d => d.YelpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_products_yelp_reviews_yelp_id_products_yelp_search");
            });

            modelBuilder.Entity<ProductsYelpSearch>(entity =>
            {
                entity.ToTable("products_yelp_search");

                entity.HasIndex(e => e.BizId, "uq_products_yelp_search_bizId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressCountry).HasColumnName("addressCountry");

                entity.Property(e => e.AddressLocality).HasColumnName("addressLocality");

                entity.Property(e => e.AddressRegion).HasColumnName("addressRegion");

                entity.Property(e => e.AggregateRatingValue).HasColumnName("aggregate_rating_value");

                entity.Property(e => e.AggregateReviewCount).HasColumnName("aggregate_review_count");

                entity.Property(e => e.BizId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bizId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessUrl).HasColumnName("businessUrl");

                entity.Property(e => e.Categories).HasColumnName("categories");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.CreatedOn1).HasColumnName("CreatedOn");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Faq).HasColumnName("faq");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Neighborhoods).HasColumnName("neighborhoods");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.PostalCode).HasColumnName("postalCode");

                entity.Property(e => e.PriceRange).HasColumnName("priceRange");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductId1).HasColumnName("ProductId");

                entity.Property(e => e.Review).HasColumnName("review");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.StreetAddress).HasColumnName("streetAddress");

                entity.Property(e => e.Tags).HasColumnName("tags");

                entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

                entity.Property(e => e.UpdatedOn1).HasColumnName("UpdatedOn");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Regions_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Search>(entity =>
            {
                entity.HasIndex(e => e.DataSourceId, "IX_Searches_DataSourceId");

                entity.HasIndex(e => e.DateKey, "IX_Searches_DateKey");

                entity.HasIndex(e => e.LanguageId, "IX_Searches_LanguageId");

                entity.HasIndex(e => e.MarketId, "IX_Searches_MarketId");

                entity.HasIndex(e => e.ProductId, "IX_Searches_ProductId");

                entity.HasIndex(e => e.RegionId, "IX_Searches_RegionId");

                entity.HasIndex(e => e.TopicLevel1Id, "IX_Searches_TopicLevel1Id");

                entity.HasIndex(e => e.TopicLevel2Id, "IX_Searches_TopicLevel2Id");

                entity.HasIndex(e => e.TopicLevel3Id, "IX_Searches_TopicLevel3Id");

                entity.Property(e => e.KeyTerms).HasMaxLength(500);

                entity.Property(e => e.SearchTerm)
                    .IsRequired(false)
                    .HasMaxLength(500);

                entity.HasOne(d => d.DataSource)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.DataSourceId);

                entity.HasOne(d => d.DateKeyNavigation)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.DateKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Search_TimePeriod");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.LanguageId);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.MarketId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.RegionId);

                entity.HasOne(d => d.TopicLevel1)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.TopicLevel1Id);

                entity.HasOne(d => d.TopicLevel2)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.TopicLevel2Id);

                entity.HasOne(d => d.TopicLevel3)
                    .WithMany(p => p.Searches)
                    .HasForeignKey(d => d.TopicLevel3Id);
            });

            modelBuilder.Entity<SearchVolumeByMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SearchVolumeByMonth");

                entity.Property(e => e.EnglishMonthName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SentimentDecreaseLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SentimentDecreaseLevel1");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SentimentDecreaseLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SentimentDecreaseLevel2");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SentimentDecreaseLevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SentimentDecreaseLevel3");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimePeriod>(entity =>
            {
                entity.HasKey(e => e.DateKey)
                    .HasName("PK_TimePeriod_DateKey");

                entity.HasIndex(e => e.FullDateAlternateKey, "AK_TimePeriod_FullDateAlternateKey")
                    .IsUnique();

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.EnglishDayNameOfWeek)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EnglishMonthName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FrenchDayNameOfWeek)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FrenchMonthName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FullDateAlternateKey).HasColumnType("date");

                entity.Property(e => e.SpanishDayNameOfWeek)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SpanishMonthName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TopicCategory>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_TopicCategories_TenantId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TopicLevel1>(entity =>
            {
                entity.ToTable("TopicLevel1");

                entity.HasIndex(e => e.TenantId, "IX_TopicLevel1_TenantId");

                entity.HasIndex(e => e.TopicCategoryId, "IX_TopicLevel1_TopicCategoryId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.TopicLevelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TopicCategory)
                    .WithMany(p => p.TopicLevel1s)
                    .HasForeignKey(d => d.TopicCategoryId);
            });

            modelBuilder.Entity<TopicLevel1Mention>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TopicLevel1Mentions");

                entity.Property(e => e.RawSource)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TopicLevel2>(entity =>
            {
                entity.ToTable("TopicLevel2");

                entity.HasIndex(e => e.TenantId, "IX_TopicLevel2_TenantId");

                entity.HasIndex(e => e.TopicCategoryId, "IX_TopicLevel2_TopicCategoryId");

                entity.HasIndex(e => e.TopicLevel1Id, "IX_TopicLevel2_TopicLevel1Id");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.TopicLevelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TopicCategory)
                    .WithMany(p => p.TopicLevel2s)
                    .HasForeignKey(d => d.TopicCategoryId);

                entity.HasOne(d => d.TopicLevel1)
                    .WithMany(p => p.TopicLevel2s)
                    .HasForeignKey(d => d.TopicLevel1Id);
            });

            modelBuilder.Entity<TopicLevel2Mention>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TopicLevel2Mentions");

                entity.Property(e => e.RawSource)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TopicLevel3>(entity =>
            {
                entity.ToTable("TopicLevel3");

                entity.HasIndex(e => e.TenantId, "IX_TopicLevel3_TenantId");

                entity.HasIndex(e => e.TopicCategoryId, "IX_TopicLevel3_TopicCategoryId");

                entity.HasIndex(e => e.TopicLevel2Id, "IX_TopicLevel3_TopicLevel2Id");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.TopicLevelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TopicCategory)
                    .WithMany(p => p.TopicLevel3s)
                    .HasForeignKey(d => d.TopicCategoryId);

                entity.HasOne(d => d.TopicLevel2)
                    .WithMany(p => p.TopicLevel3s)
                    .HasForeignKey(d => d.TopicLevel2Id);
            });

            modelBuilder.Entity<TopicLevel3Mention>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TopicLevel3Mentions");

                entity.Property(e => e.RawSource)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TotalSearchVolumeTopicLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TotalSearchVolumeTopicLevel1");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TotalSearchVolumeTopicLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TotalSearchVolumeTopicLevel2");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TotalSearchVolumeTopicLevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TotalSearchVolumeTopicLevel3");

                entity.Property(e => e.TopicLevelTerm)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
