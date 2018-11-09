using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreDbFirst.Models
{
    public partial class rensanqianContext : DbContext
    {
        public rensanqianContext()
        {
        }

        public rensanqianContext(DbContextOptions<rensanqianContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleContent> ArticleContent { get; set; }
        public virtual DbSet<ArticleContentIllustration> ArticleContentIllustration { get; set; }
        public virtual DbSet<DictionaryArticleUsetype> DictionaryArticleUsetype { get; set; }
        public virtual DbSet<DictionaryGlobalArea> DictionaryGlobalArea { get; set; }
        public virtual DbSet<DictionaryGlobalBanktype> DictionaryGlobalBanktype { get; set; }
        public virtual DbSet<DictionaryOrderStatustype> DictionaryOrderStatustype { get; set; }
        public virtual DbSet<DictionarySysShortmessagetype> DictionarySysShortmessagetype { get; set; }
        public virtual DbSet<DictionaryTaskProcesstype> DictionaryTaskProcesstype { get; set; }
        public virtual DbSet<DictionaryTaskResourcetype> DictionaryTaskResourcetype { get; set; }
        public virtual DbSet<DictionaryTaskTagtype> DictionaryTaskTagtype { get; set; }
        public virtual DbSet<DictionaryUserAccounttype> DictionaryUserAccounttype { get; set; }
        public virtual DbSet<DictionaryUserGradetype> DictionaryUserGradetype { get; set; }
        public virtual DbSet<DictionaryUserOrigintype> DictionaryUserOrigintype { get; set; }
        public virtual DbSet<DictionaryUserThirdaccounttype> DictionaryUserThirdaccounttype { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderGradeBonus> OrderGradeBonus { get; set; }
        public virtual DbSet<OrderResourceSubmit> OrderResourceSubmit { get; set; }
        public virtual DbSet<OrderStatusDetail> OrderStatusDetail { get; set; }
        public virtual DbSet<OrderTaskDetail> OrderTaskDetail { get; set; }
        public virtual DbSet<PlatformErrorcollect> PlatformErrorcollect { get; set; }
        public virtual DbSet<PlatformFaq> PlatformFaq { get; set; }
        public virtual DbSet<PlatformIncomeStatistics> PlatformIncomeStatistics { get; set; }
        public virtual DbSet<PlatformNotice> PlatformNotice { get; set; }
        public virtual DbSet<PlatformOrderStatistics> PlatformOrderStatistics { get; set; }
        public virtual DbSet<PlatformTaskDetailStatistics> PlatformTaskDetailStatistics { get; set; }
        public virtual DbSet<PlatformTaskStatistics> PlatformTaskStatistics { get; set; }
        public virtual DbSet<PlatformUserFeedback> PlatformUserFeedback { get; set; }
        public virtual DbSet<PlatformUserStatistics> PlatformUserStatistics { get; set; }
        public virtual DbSet<PlatformVersion> PlatformVersion { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskProcessTitle> TaskProcessTitle { get; set; }
        public virtual DbSet<TaskProcessTitleIllustration> TaskProcessTitleIllustration { get; set; }
        public virtual DbSet<TaskResourceSubmitrequest> TaskResourceSubmitrequest { get; set; }
        public virtual DbSet<TaskStock> TaskStock { get; set; }
        public virtual DbSet<TaskTag> TaskTag { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User2> User2 { get; set; }
        public virtual DbSet<UserBank> UserBank { get; set; }
        public virtual DbSet<UserFansStatistics> UserFansStatistics { get; set; }
        public virtual DbSet<UserIncome> UserIncome { get; set; }
        public virtual DbSet<UserIncomeApplyforcash> UserIncomeApplyforcash { get; set; }
        public virtual DbSet<UserMsgbox> UserMsgbox { get; set; }
        public virtual DbSet<UserShortmessage> UserShortmessage { get; set; }
        public virtual DbSet<UserThirdaccountid> UserThirdaccountid { get; set; }
        public virtual DbSet<Version> Version { get; set; }

        // Unable to generate entity type for table 'user_sharerecords'. Please see the warning messages.
        // Unable to generate entity type for table 'user_sharerecords_browserecord'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=39.104.;User Id=x;Password=x;Database=x");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("article");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArticleDesc)
                    .HasColumnName("Article_Desc")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ArticleIsShow)
                    .HasColumnName("Article_IsShow")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ArticleNavigateToUrl)
                    .HasColumnName("Article_NavigateToUrl")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ArticleTitle)
                    .HasColumnName("Article_Title")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArticleTypeCode)
                    .HasColumnName("ArticleType_Code")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ArticleContent>(entity =>
            {
                entity.ToTable("article_content");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContentContent)
                    .HasColumnName("Content_Content")
                    .HasColumnType("text");

                entity.Property(e => e.ContentNavigateToUrl)
                    .HasColumnName("Content_NavigateToUrl")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ContentOrder)
                    .HasColumnName("Content_Order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentTitle)
                    .HasColumnName("Content_Title")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ArticleContentIllustration>(entity =>
            {
                entity.ToTable("article_content_illustration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleContentId)
                    .HasColumnName("Article_Content_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IllustrationDesc)
                    .HasColumnName("Illustration_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IllustrationNavigateToUrl)
                    .HasColumnName("Illustration_NavigateToUrl")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.IllustrationOrder)
                    .HasColumnName("Illustration_Order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IllustrationTitle)
                    .HasColumnName("Illustration_Title")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IllustrationUrl)
                    .HasColumnName("Illustration_URL")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<DictionaryArticleUsetype>(entity =>
            {
                entity.ToTable("dictionary_article_usetype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.ArticleTypeCode)
                    .HasColumnName("ArticleType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArticleTypeDesc)
                    .HasColumnName("ArticleType_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArticleTypeName)
                    .HasColumnName("ArticleType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryGlobalArea>(entity =>
            {
                entity.ToTable("dictionary_global_area");

                entity.HasIndex(e => e.Aid)
                    .HasName("AID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.OrderNumber).HasColumnType("int(11)");

                entity.Property(e => e.Paid)
                    .HasColumnName("PAID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Precode).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryGlobalBanktype>(entity =>
            {
                entity.ToTable("dictionary_global_banktype");

                entity.HasIndex(e => e.BankTypeCode)
                    .HasName("BankType_Code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.BankTypeCode)
                    .HasColumnName("BankType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BankTypeDesc)
                    .HasColumnName("BankType_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BankTypeName)
                    .HasColumnName("BankType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryOrderStatustype>(entity =>
            {
                entity.ToTable("dictionary_order_statustype");

                entity.HasIndex(e => e.StatusTypeCode)
                    .HasName("OrderStateType_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.StatusTypeCode)
                    .HasColumnName("StatusType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.StatusTypeDesc)
                    .HasColumnName("StatusType_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StatusTypeName)
                    .HasColumnName("StatusType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionarySysShortmessagetype>(entity =>
            {
                entity.ToTable("dictionary_sys_shortmessagetype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.Desc).HasColumnType("varchar(50)");

                entity.Property(e => e.ShortMessageTypeCode)
                    .HasColumnName("ShortMessageType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ShortMessageTypeName)
                    .HasColumnName("ShortMessageType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryTaskProcesstype>(entity =>
            {
                entity.ToTable("dictionary_task_processtype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.Desc).HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessTypeCode)
                    .HasColumnName("ProcessType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ProcessTypeName)
                    .HasColumnName("ProcessType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryTaskResourcetype>(entity =>
            {
                entity.ToTable("dictionary_task_resourcetype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.ResourceTypeCode)
                    .HasColumnName("ResourceType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ResourceTypeDesc)
                    .HasColumnName("ResourceType_Desc")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ResourceTypeName)
                    .HasColumnName("ResourceType_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ResourceTypeRemark)
                    .HasColumnName("ResourceType_Remark")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryTaskTagtype>(entity =>
            {
                entity.ToTable("dictionary_task_tagtype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.TagTypeCode)
                    .HasColumnName("TagType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TagTypeDesc)
                    .HasColumnName("TagType_Desc")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TagTypeName)
                    .HasColumnName("TagType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryUserAccounttype>(entity =>
            {
                entity.ToTable("dictionary_user_accounttype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountTypeCode)
                    .HasColumnName("AccountType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AccountTypeDesc)
                    .HasColumnName("AccountType_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AccountTypeName)
                    .HasColumnName("AccountType_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AddDate).HasColumnType("date");
            });

            modelBuilder.Entity<DictionaryUserGradetype>(entity =>
            {
                entity.ToTable("dictionary_user_gradetype");

                entity.HasIndex(e => e.GradeTypeCode)
                    .HasName("GradeType_Code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GradeTypeBaseCondition)
                    .HasColumnName("GradeType_BaseCondition")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GradeTypeCode)
                    .HasColumnName("GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.GradeTypeDesc)
                    .HasColumnName("GradeType_Desc")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GradeTypeName)
                    .HasColumnName("GradeType_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GradeTypeNextGradeCode)
                    .HasColumnName("GradeType_NextGradeCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.GradeTypeNextGradeCondition)
                    .HasColumnName("GradeType_NextGradeCondition")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DictionaryUserOrigintype>(entity =>
            {
                entity.ToTable("dictionary_user_origintype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Desc).HasColumnType("varchar(50)");

                entity.Property(e => e.OriginTypeCode)
                    .HasColumnName("OriginType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.OriginTypeName)
                    .HasColumnName("OriginType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<DictionaryUserThirdaccounttype>(entity =>
            {
                entity.ToTable("dictionary_user_thirdaccounttype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.Desc).HasColumnType("varchar(50)");

                entity.Property(e => e.ThirdAccountTypeCode)
                    .HasColumnName("ThirdAccountType_Code")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ThirdAccountTypeName)
                    .HasColumnName("ThirdAccountType_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.Oid)
                    .HasName("OID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.EffectiveEndTime).HasColumnType("datetime");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.StatusTypeCode)
                    .HasColumnName("StatusType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<OrderGradeBonus>(entity =>
            {
                entity.ToTable("order_grade_bonus");

                entity.HasIndex(e => e.Oid)
                    .HasName("OID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidBonus)
                    .HasColumnName("UID_Bonus")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidExtraBonus)
                    .HasColumnName("UID_ExtraBonus")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidGradeTypeBrokerageScale)
                    .HasColumnName("UID_GradeType_BrokerageScale")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidGradeTypeCode)
                    .HasColumnName("UID_GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.UidGrandParent)
                    .HasColumnName("UID_GrandParent")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidGrandParentBonus)
                    .HasColumnName("UID_GrandParent_Bonus")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidGrandParentGradeTypeBrokerageScale)
                    .HasColumnName("UID_GrandParent_GradeType_BrokerageScale")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidGrandParentGradeTypeCode)
                    .HasColumnName("UID_GrandParent_GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.UidGrandParentName)
                    .HasColumnName("UID_GrandParent_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidName)
                    .HasColumnName("UID_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidParent)
                    .HasColumnName("UID_Parent")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidParentBonus)
                    .HasColumnName("UID_Parent_Bonus")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidParentGradeTypeBrokerageScale)
                    .HasColumnName("UID_Parent_GradeType_BrokerageScale")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidParentGradeTypeCode)
                    .HasColumnName("UID_Parent_GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.UidParentName)
                    .HasColumnName("UID_Parent_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidTop)
                    .HasColumnName("UID_Top")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidTopBonus)
                    .HasColumnName("UID_Top_Bonus")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidTopGradeTypeBrokerageScale)
                    .HasColumnName("UID_Top_GradeType_BrokerageScale")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UidTopGradeTypeCode)
                    .HasColumnName("UID_Top_GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.UidTopName)
                    .HasColumnName("UID_Top_Name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<OrderResourceSubmit>(entity =>
            {
                entity.ToTable("order_resource_submit");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PicArray)
                    .HasColumnName("Pic_Array")
                    .HasColumnType("text");

                entity.Property(e => e.RegistAccount)
                    .HasColumnName("Regist_Account")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RegistMobile)
                    .HasColumnName("Regist_Mobile")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RegistName)
                    .HasColumnName("Regist_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Remark).HasColumnType("varchar(200)");

                entity.Property(e => e.SubmitContent).HasColumnType("varchar(200)");

                entity.Property(e => e.SubmitTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderStatusDetail>(entity =>
            {
                entity.ToTable("order_status_detail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Remark).HasColumnType("varchar(200)");

                entity.Property(e => e.StatusTypeCode)
                    .HasColumnName("StatusType_Code")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<OrderTaskDetail>(entity =>
            {
                entity.ToTable("order_task_detail");

                entity.HasIndex(e => e.Tid)
                    .HasName("TID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskAveragePass)
                    .HasColumnName("Task_AveragePass")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskAverageTime)
                    .HasColumnName("Task_AverageTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.TaskBonusPlatform)
                    .HasColumnName("Task_Bonus_Platform")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskBonusUser)
                    .HasColumnName("Task_Bonus_User")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskBonusUserExtra)
                    .HasColumnName("Task_Bonus_User_Extra")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskCompany)
                    .HasColumnName("Task_Company")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskCompanyDesc)
                    .HasColumnName("Task_Company_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskCondition)
                    .HasColumnName("Task_Condition")
                    .HasColumnType("text");

                entity.Property(e => e.TaskContent)
                    .HasColumnName("Task_Content")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TaskDesc)
                    .HasColumnName("Task_Desc")
                    .HasColumnType("text");

                entity.Property(e => e.TaskDifficultyType)
                    .HasColumnName("Task_DifficultyType")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'简单'");

                entity.Property(e => e.TaskEffectiveTimeAfterAccept)
                    .HasColumnName("Task_EffectiveTime_AfterAccept")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.TaskEndDate)
                    .HasColumnName("Task_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskIconLink)
                    .HasColumnName("Task_Icon_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskIsShow)
                    .HasColumnName("Task_IsShow")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskName)
                    .HasColumnName("Task_Name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TaskQrcodeLink)
                    .HasColumnName("Task_QRCode_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskRecommendLink)
                    .HasColumnName("Task_Recommend_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskRefferalCode)
                    .HasColumnName("Task_RefferalCode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskRemark)
                    .HasColumnName("Task_Remark")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskRule)
                    .HasColumnName("Task_Rule")
                    .HasColumnType("text");

                entity.Property(e => e.TaskStartDate)
                    .HasColumnName("Task_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PlatformErrorcollect>(entity =>
            {
                entity.ToTable("platform_errorcollect");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CollectTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorContent)
                    .HasColumnName("Error_Content")
                    .HasColumnType("text");

                entity.Property(e => e.ErrorDevice)
                    .HasColumnName("Error_Device")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ErrorTitle)
                    .HasColumnName("Error_Title")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ErrorTypeCode)
                    .HasColumnName("ErrorType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PlatformFaq>(entity =>
            {
                entity.ToTable("platform_faq");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.QuestionAnswer)
                    .HasColumnName("Question_Answer")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.QuestionContent)
                    .HasColumnName("Question_Content")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.QuestionTitle)
                    .HasColumnName("Question_Title")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.QuestionViewTimes)
                    .HasColumnName("Question_ViewTimes")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlatformIncomeStatistics>(entity =>
            {
                entity.ToTable("platform_income_statistics");

                entity.HasIndex(e => e.StatisticDate)
                    .HasName("StatisticDate")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IncomeDailyPlatformNetMargin)
                    .HasColumnName("Income_Daily_Platform_NetMargin")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyPlatformTotal)
                    .HasColumnName("Income_Daily_Platform_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserDirectTotal)
                    .HasColumnName("Income_Daily_User_Direct_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserFailTotal)
                    .HasColumnName("Income_Daily_User_Fail_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserFirstLevelTotal)
                    .HasColumnName("Income_Daily_User_FirstLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserSecondLevelTotal)
                    .HasColumnName("Income_Daily_User_SecondLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserTopLevelTotal)
                    .HasColumnName("Income_Daily_User_TopLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeDailyUserTotal)
                    .HasColumnName("Income_Daily_User_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomePlatFormApplyForCashTotal)
                    .HasColumnName("Income_PlatForm_ApplyForCash_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomePlatFormWaitForCashTotal)
                    .HasColumnName("Income_PlatForm_WaitForCash_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomePlatformNetMargin)
                    .HasColumnName("Income_Platform_NetMargin")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomePlatformTotal)
                    .HasColumnName("Income_Platform_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserDirectTotal)
                    .HasColumnName("Income_User_Direct_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserFirstLevelTotal)
                    .HasColumnName("Income_User_FirstLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserSecondLevelTotal)
                    .HasColumnName("Income_User_SecondLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserTopLevelTotal)
                    .HasColumnName("Income_User_TopLevel_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserTotal)
                    .HasColumnName("Income_User_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatisticDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlatformNotice>(entity =>
            {
                entity.ToTable("platform_notice");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.NoticeContent)
                    .HasColumnName("Notice_Content")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.NoticeImgUrl)
                    .HasColumnName("Notice_Img_Url")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NoticeNavigateToUrl)
                    .HasColumnName("Notice_NavigateToUrl")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NoticeTitle)
                    .HasColumnName("Notice_Title")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PlatformOrderStatistics>(entity =>
            {
                entity.ToTable("platform_order_statistics");

                entity.HasIndex(e => e.StatisticDate)
                    .HasName("StatisticDate")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NumberCompleteTotal)
                    .HasColumnName("Number_Complete_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyAdd)
                    .HasColumnName("Number_DailyAdd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyComplete)
                    .HasColumnName("Number_DailyComplete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyFail)
                    .HasColumnName("Number_DailyFail")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyInvalid)
                    .HasColumnName("Number_DailyInvalid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberEffectiveTotal)
                    .HasColumnName("Number_Effective_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberFailTotal)
                    .HasColumnName("Number_Fail_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberInvalidTotal)
                    .HasColumnName("Number_Invalid_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberTotal)
                    .HasColumnName("Number_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberUnReview)
                    .HasColumnName("Number_UnReview")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatisticDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlatformTaskDetailStatistics>(entity =>
            {
                entity.ToTable("platform_task_detail_statistics");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AveragePass)
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AverageTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.IncomePlatformNetMargin)
                    .HasColumnName("Income_Platform_NetMargin")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomePlatformTotal)
                    .HasColumnName("Income_Platform_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUserTotal)
                    .HasColumnName("Income_User_Total")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberAcceptTotal)
                    .HasColumnName("Number_Accept_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberCompleteTotal)
                    .HasColumnName("Number_Complete_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyAcceptTotal)
                    .HasColumnName("Number_DailyAccept_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyCompleteTotal)
                    .HasColumnName("Number_DailyComplete_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyFailTotal)
                    .HasColumnName("Number_DailyFail_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyInvalidTotal)
                    .HasColumnName("Number_DailyInvalid_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyViewTotal)
                    .HasColumnName("Number_DailyView_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberFailTotal)
                    .HasColumnName("Number_Fail_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberInvalidTotal)
                    .HasColumnName("Number_Invalid_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberViewTotal)
                    .HasColumnName("Number_View_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatisticDate).HasColumnType("date");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PlatformTaskStatistics>(entity =>
            {
                entity.ToTable("platform_task_statistics");

                entity.HasIndex(e => e.StatisticDate)
                    .HasName("StatisticDate")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NumberActive)
                    .HasColumnName("Number_Active")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberDailyAdd)
                    .HasColumnName("Number_DailyAdd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberInvalid)
                    .HasColumnName("Number_Invalid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberTotal)
                    .HasColumnName("Number_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberViewTotal)
                    .HasColumnName("Number_View_Total")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatisticDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlatformUserFeedback>(entity =>
            {
                entity.ToTable("platform_user_feedback");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeedBackContent)
                    .HasColumnName("FeedBack_Content")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FeedBackReplyContent)
                    .HasColumnName("FeedBack_Reply_Content")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FeedBackReplyIsRead)
                    .HasColumnName("FeedBack_Reply_IsRead")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FeedBackReplyReadTime)
                    .HasColumnName("FeedBack_Reply_ReadTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeedBackReplyTime)
                    .HasColumnName("FeedBack_Reply_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PlatformUserStatistics>(entity =>
            {
                entity.ToTable("platform_user_statistics");

                entity.HasIndex(e => e.StatisticDate)
                    .HasName("StatisticDate")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NumberA1)
                    .HasColumnName("Number_A1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberA2)
                    .HasColumnName("Number_A2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberA3)
                    .HasColumnName("Number_A3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberA4)
                    .HasColumnName("Number_A4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberA5)
                    .HasColumnName("Number_A5")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberB1)
                    .HasColumnName("Number_B1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberB2)
                    .HasColumnName("Number_B2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberB3)
                    .HasColumnName("Number_B3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberB4)
                    .HasColumnName("Number_B4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberB5)
                    .HasColumnName("Number_B5")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberC1)
                    .HasColumnName("Number_C1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberC2)
                    .HasColumnName("Number_C2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberC3)
                    .HasColumnName("Number_C3")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberC4)
                    .HasColumnName("Number_C4")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberC5)
                    .HasColumnName("Number_C5")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberD)
                    .HasColumnName("Number_D")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberDailyRegister)
                    .HasColumnName("Number_DailyRegister")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumberTotal)
                    .HasColumnName("Number_Total")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatisticDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlatformVersion>(entity =>
            {
                entity.ToTable("platform_version");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VersionCodeLocal)
                    .HasColumnName("Version_Code_Local")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.VersionCodeServer)
                    .HasColumnName("Version_Code_Server")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.VersionContent)
                    .HasColumnName("Version_Content")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.VersionContentRemark)
                    .HasColumnName("Version_Content_Remark")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.VersionOrder)
                    .HasColumnName("Version_Order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VersionProgramTypeCode)
                    .HasColumnName("Version_ProgramType_Code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'wx_xcx'");

                entity.Property(e => e.VersionUpdateTime)
                    .HasColumnName("Version_UpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("task");

                entity.HasIndex(e => e.Tid)
                    .HasName("TID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.TaskAveragePass)
                    .HasColumnName("Task_AveragePass")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskAverageTime)
                    .HasColumnName("Task_AverageTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.TaskBonusFrom)
                    .HasColumnName("Task_Bonus_From")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskBonusPlatform)
                    .HasColumnName("Task_Bonus_Platform")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskBonusTo)
                    .HasColumnName("Task_Bonus_To")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.TaskBonusUserExtra)
                    .HasColumnName("Task_Bonus_User_Extra")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskCompany)
                    .HasColumnName("Task_Company")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskCompanyDesc)
                    .HasColumnName("Task_Company_Desc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskContent)
                    .HasColumnName("Task_Content")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TaskDesc)
                    .HasColumnName("Task_Desc")
                    .HasColumnType("text");

                entity.Property(e => e.TaskDifficultyType)
                    .HasColumnName("Task_DifficultyType")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'简单'");

                entity.Property(e => e.TaskEffectiveTimeAfterAccept)
                    .HasColumnName("Task_EffectiveTime_AfterAccept")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.TaskEndDate)
                    .HasColumnName("Task_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskIconLink)
                    .HasColumnName("Task_Icon_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskIsShow)
                    .HasColumnName("Task_IsShow")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskName)
                    .HasColumnName("Task_Name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TaskQrcodeLink)
                    .HasColumnName("Task_QRCode_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskRecommendLink)
                    .HasColumnName("Task_Recommend_Link")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TaskRefferalCode)
                    .HasColumnName("Task_RefferalCode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskRemark)
                    .HasColumnName("Task_Remark")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskStartDate)
                    .HasColumnName("Task_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<TaskProcessTitle>(entity =>
            {
                entity.ToTable("task_process_title");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.PorcessOrder)
                    .HasColumnName("Porcess_Order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessCopyData)
                    .HasColumnName("Process_CopyData")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ProcessTitle)
                    .HasColumnName("Process_Title")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ProcessTypeCode)
                    .HasColumnName("ProcessType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<TaskProcessTitleIllustration>(entity =>
            {
                entity.ToTable("task_process_title_illustration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IllustrationDesc)
                    .HasColumnName("Illustration_Desc")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.IllustrationOrder)
                    .HasColumnName("Illustration_Order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IllustrationTitle)
                    .HasColumnName("Illustration_Title")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IllustrationUrl)
                    .HasColumnName("Illustration_URL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ProcessTitleId)
                    .HasColumnName("Process_Title_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<TaskResourceSubmitrequest>(entity =>
            {
                entity.ToTable("task_resource_submitrequest");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.RequestNumber)
                    .HasColumnName("Request_Number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RequestOrder)
                    .HasColumnName("Request_Order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ResourceTypeCode)
                    .HasColumnName("ResourceType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ResourceTypeName)
                    .HasColumnName("ResourceType_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ResourceTypeRemark)
                    .HasColumnName("ResourceType_Remark")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<TaskStock>(entity =>
            {
                entity.ToTable("task_stock");

                entity.HasIndex(e => e.Tid)
                    .HasName("TID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskAvailableNumber)
                    .HasColumnName("Task_AvailableNumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskCompleteNumber)
                    .HasColumnName("Task_CompleteNumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskDoneNumber)
                    .HasColumnName("Task_DoneNumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskIsOver)
                    .HasColumnName("Task_IsOver")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaskOnePersonLimitNumber)
                    .HasColumnName("Task_OnePerson_LimitNumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaskOverReason)
                    .HasColumnName("Task_OverReason")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskOverTime)
                    .HasColumnName("Task_OverTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskTotalNumber)
                    .HasColumnName("Task_TotalNumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskTag>(entity =>
            {
                entity.ToTable("task_tag");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.TagContent)
                    .HasColumnName("Tag_Content")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TagOrder)
                    .HasColumnName("Tag_Order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TagTypeCode)
                    .HasColumnName("TagType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Mob)
                    .HasName("Mob")
                    .IsUnique();

                entity.HasIndex(e => e.Uid)
                    .HasName("UID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Address).HasColumnType("varchar(50)");

                entity.Property(e => e.Age)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AreaId)
                    .HasColumnName("Area_ID")
                    .HasColumnType("int(30)");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_ID")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.Gender).HasColumnType("tinyint(4)");

                entity.Property(e => e.GradeTypeCode)
                    .HasColumnName("GradeType_Code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.HeadPicUrl)
                    .HasColumnName("HeadPic_URL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Mob).HasColumnType("varchar(15)");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("Province_ID")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.QqNumber)
                    .HasColumnName("QQ_Number")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ReferralCode).HasColumnType("varchar(20)");

                entity.Property(e => e.StateIsLock)
                    .HasColumnName("State_IsLock")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StateLockReason)
                    .HasColumnName("State_LockReason")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidParent)
                    .HasColumnName("UID_Parent")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UidTop)
                    .HasColumnName("UID_Top")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UserAccount).HasColumnType("varchar(64)");

                entity.Property(e => e.UserOriginTypeCode)
                    .HasColumnName("User_OriginType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UserPassword).HasColumnType("varchar(128)");

                entity.Property(e => e.WechatNumber)
                    .HasColumnName("Wechat_Number")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<User2>(entity =>
            {
                entity.ToTable("user2");

                entity.HasIndex(e => e.Account)
                    .HasName("IX_User2_Account")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<UserBank>(entity =>
            {
                entity.ToTable("user_bank");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AccountTypeBankBranch)
                    .HasColumnName("AccountType_Bank_Branch")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AccountTypeBankName)
                    .HasColumnName("AccountType_Bank_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AccountTypeCode)
                    .HasColumnName("AccountType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AccountTypeNumber)
                    .HasColumnName("AccountType_Number")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UserTrueName)
                    .HasColumnName("User_TrueName")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UserFansStatistics>(entity =>
            {
                entity.ToTable("user_fans_statistics");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.FansFirstLevelNumber)
                    .HasColumnName("Fans_FirstLevel_Number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FansSecondLevelNumber)
                    .HasColumnName("Fans_SecondLevel_Number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FansTopLevelNumber)
                    .HasColumnName("Fans_TopLevel_Number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserIncome>(entity =>
            {
                entity.ToTable("user_income");

                entity.HasIndex(e => e.Uid)
                    .HasName("UID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AccountBalance)
                    .HasColumnName("Account_Balance")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AccountTotalIncome)
                    .HasColumnName("Account_TotalIncome")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AccountTotalWithdrawCash)
                    .HasColumnName("Account_TotalWithdrawCash")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeOnTheWay)
                    .HasColumnName("Income_OnTheWay")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncomeUnderReview)
                    .HasColumnName("Income_UnderReview")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalIncomeFirstLevel)
                    .HasColumnName("TotalIncome_FirstLevel")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalIncomeSecondLevel)
                    .HasColumnName("TotalIncome_SecondLevel")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalIncomeTopLevel)
                    .HasColumnName("TotalIncome_TopLevel")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserIncomeApplyforcash>(entity =>
            {
                entity.ToTable("user_income_applyforcash");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ApplyForCashAccountNumber)
                    .HasColumnName("ApplyForCash_AccountNumber")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ApplyForCashAccountType)
                    .HasColumnName("ApplyForCash_AccountType")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ApplyForCashAfter)
                    .HasColumnName("ApplyForCash_After")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApplyForCashApplyTime)
                    .HasColumnName("ApplyForCash_ApplyTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApplyForCashBankBranch)
                    .HasColumnName("ApplyForCash_Bank_Branch")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ApplyForCashBankName)
                    .HasColumnName("ApplyForCash_Bank_Name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ApplyForCashBefore)
                    .HasColumnName("ApplyForCash_Before")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApplyForCashCode)
                    .HasColumnName("ApplyForCash_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ApplyForCashDoneTime)
                    .HasColumnName("ApplyForCash_DoneTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApplyForCashFailReason)
                    .HasColumnName("ApplyForCash_Fail_Reason")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ApplyForCashMoney)
                    .HasColumnName("ApplyForCash_Money")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApplyForCashStatus)
                    .HasColumnName("ApplyForCash_Status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApplyForCashTrueName)
                    .HasColumnName("ApplyForCash_TrueName")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UserMsgbox>(entity =>
            {
                entity.ToTable("user_msgbox");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MsgContent)
                    .HasColumnName("Msg_Content")
                    .HasColumnType("text");

                entity.Property(e => e.MsgIsRead)
                    .HasColumnName("Msg_Is_Read")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MsgReadTime)
                    .HasColumnName("Msg_ReadTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsgRelationId)
                    .HasColumnName("Msg_RelationID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MsgRemark)
                    .HasColumnName("Msg_Remark")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MsgTitle)
                    .HasColumnName("Msg_Title")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MsgTypeCode)
                    .HasColumnName("Msg_TypeCode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UserShortmessage>(entity =>
            {
                entity.ToTable("user_shortmessage");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content).HasColumnType("varchar(255)");

                entity.Property(e => e.Desc).HasColumnType("varchar(50)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(20)");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.ShortMessageTypeCode)
                    .HasColumnName("ShortMessageType_Code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UserThirdaccountid>(entity =>
            {
                entity.ToTable("user_thirdaccountid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AccessToken).HasColumnType("varchar(100)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.ThirdAccountTypeCode)
                    .HasColumnName("ThirdAccountType_Code")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ThirdAccountTypeId)
                    .HasColumnName("ThirdAccountType_ID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.ToTable("version");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.VersionContent)
                    .HasColumnName("Version_Content")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.VersionId)
                    .HasColumnName("Version_ID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.VersionType)
                    .HasColumnName("Version_Type")
                    .HasColumnType("varchar(20)");
            });
        }
    }
}
