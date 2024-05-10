using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;
using Refbooks.Domain.Nsi.KRefbooks;
using Refbooks.Domain.Nsi.NRefbooks;
using Refbooks.Domain.Nsi.ORefbooks;
using Refbooks.Domain.Nsi.QRefbooks;
using Refbooks.Domain.Nsi.RRefbooks;
using Refbooks.Domain.Nsi.VRefbooks;
using Refbooks.Domain.Yamed;
using Refbooks.Domain.Yamed.KsgCalculation;
using Refbooks.Persistence.EntityTypeConfigurationExtensions;


namespace Refbooks.Persistence
{
    public class RefbooksDbContext : DbContext, IRefbooksDbContext
    {
        #region NSI

        #region DbSet_F
        public DbSet<F001> F001 { get; set; }
        public DbSet<F002> F002 { get; set; }
        public DbSet<F003> F003 { get; set; }
        public DbSet<F005> F005 { get; set; }
        public DbSet<F006> F006 { get; set; }
        public DbSet<F007> F007 { get; set; }
        public DbSet<F008> F008 { get; set; }
        public DbSet<F009> F009 { get; set; }
        public DbSet<F010> F010 { get; set; }
        public DbSet<F011> F011 { get; set; }
        public DbSet<F014> F014 { get; set; }
        public DbSet<F015> F015 { get; set; }
        public DbSet<F032> F032 { get; set; }
        public DbSet<F042> F042 { get; set; }
        #endregion

        #region DbSet_N
        public DbSet<N001> N001 { get; set; }
        public DbSet<N002> N002 { get; set; }
        public DbSet<N003> N003 { get; set; }
        public DbSet<N004> N004 { get; set; }
        public DbSet<N005> N005 { get; set; }
        public DbSet<N006> N006 { get; set; }
        public DbSet<N007> N007 { get; set; }
        public DbSet<N008> N008 { get; set; }
        public DbSet<N009> N009 { get; set; }
        public DbSet<N010> N010 { get; set; }
        public DbSet<N011> N011 { get; set; }
        public DbSet<N012> N012 { get; set; }
        public DbSet<N013> N013 { get; set; }
        public DbSet<N014> N014 { get; set; }
        public DbSet<N015> N015 { get; set; }
        public DbSet<N016> N016 { get; set; }
        public DbSet<N017> N017 { get; set; }
        public DbSet<N018> N018 { get; set; }
        public DbSet<N019> N019 { get; set; }
        public DbSet<N020> N020 { get; set; }
        public DbSet<N021> N021 { get; set; }
        #endregion

        #region DbSet_Q
        public DbSet<Q015> Q015 { get; set; }
        public DbSet<Q016> Q016 { get; set; }
        public DbSet<Q017> Q017 { get; set; }
        public DbSet<Q018> Q018 { get; set; }
        public DbSet<Q019> Q019 { get; set; }
        public DbSet<Q020> Q020 { get; set; }
        public DbSet<Q021> Q021 { get; set; }
        public DbSet<Q022> Q022 { get; set; }
        public DbSet<Q023> Q023 { get; set; }
        #endregion

        #region DbSet_V
        public DbSet<V002> V002 { get; set; }
        public DbSet<V003> V003 { get; set; }
        public DbSet<V005> V005 { get; set; }
        public DbSet<V006> V006 { get; set; }
        public DbSet<V008> V008 { get; set; }
        public DbSet<V009> V009 { get; set; }
        public DbSet<V010> V010 { get; set; }
        public DbSet<V012> V012 { get; set; }
        public DbSet<V013> V013 { get; set; }
        public DbSet<V014> V014 { get; set; }
        public DbSet<V015> V015 { get; set; }
        public DbSet<V016> V016 { get; set; }
        public DbSet<V017> V017 { get; set; }
        public DbSet<V018> V018 { get; set; }
        public DbSet<V019> V019 { get; set; }
        public DbSet<V020> V020 { get; set; }
        public DbSet<V021> V021 { get; set; }
        public DbSet<V022> V022 { get; set; }
        public DbSet<V023> V023 { get; set; }
        public DbSet<V024> V024 { get; set; }
        public DbSet<V025> V025 { get; set; }
        public DbSet<V026> V026 { get; set; }
        public DbSet<V027> V027 { get; set; }
        public DbSet<V028> V028 { get; set; }
        public DbSet<V029> V029 { get; set; }
        public DbSet<V030> V030 { get; set; }
        public DbSet<V031> V031 { get; set; }
        public DbSet<V032> V032 { get; set; }
        public DbSet<V033> V033 { get; set; }
        public DbSet<V036> V036 { get; set; }
        public DbSet<V037> V037 { get; set; }
        #endregion

        #region DbSet_O
        public DbSet<O001> O001 { get; set; }
        public DbSet<O002> O002 { get; set; }
        public DbSet<O003> O003 { get; set; }
        public DbSet<O004> O004 { get; set; }
        public DbSet<O005> O005 { get; set; }
        #endregion

        #region DbSet_K
        public DbSet<K002> K002 { get; set; }
        public DbSet<K003> K003 { get; set; }
        public DbSet<K004> K004 { get; set; }
        #endregion

        #region DbSet_R
        public DbSet<R001> R001 { get; set; }
        public DbSet<R002> R002 { get; set; }
        public DbSet<R003> R003 { get; set; }
        public DbSet<R004> R004 { get; set; }
        public DbSet<R005> R005 { get; set; }
        public DbSet<R006> R006 { get; set; }
        public DbSet<R007> R007 { get; set; }
        public DbSet<R008> R008 { get; set; }
        public DbSet<R009> R009 { get; set; }
        public DbSet<R010> R010 { get; set; }
        public DbSet<R011> R011 { get; set; }
        public DbSet<R012> R012 { get; set; }
        public DbSet<R013> R013 { get; set; }
        public DbSet<R014> R014 { get; set; }
        #endregion

        #endregion

        #region Yamed

        #region KsgCalculation
        public DbSet<CalculationMoCoefficient> CalculationMoCoefficients { get; set; }
        public DbSet<FirstStageAdultMedicalExaminationByServiceCountCalculation> FirstStageAdultMedicalExaminationByServiceCountCalculation { get; set; }
        public DbSet<FirstStageAdultMedicalExaminationCalculation> FirstStageAdultMedicalExaminationCalculation { get; set; }
        public DbSet<FirstStageAdultProfessionalExaminationCalculation> FirstStageAdultProfessionalExaminationCalculation { get; set; }
        public DbSet<HematologyTariff> HematologyTariffs { get; set; }
        public DbSet<ServiceTemplate> ServiceTemplates { get; set; }
        public DbSet<HighTechMedicalCareTariff> HighTechMedicalCareTariffs { get; set; }
        public DbSet<KsgBaseRate> KsgBaseRates { get; set; }
        public DbSet<KsgCalculation> KsgCalculation { get; set; }
        public DbSet<KsgGrouper> KsgGrouper { get; set; }
        public DbSet<ManagementKsgCoefficient> ManagementKsgCoefficients { get; set; }
        public DbSet<MobileTeamsMedicalExaminationCoefficient> MobileTeamsMedicalExaminationCoefficients { get; set; }
        public DbSet<OutpatientTariffCalculation> OutpatientTariffCalculation { get; set; }
        public DbSet<RegionalLaboratoryStudiesCalculation> RegionalLaboratoryStudiesCalculation { get; set; }
        public DbSet<RegionalServiceTariff> RegionalServiceTariffs { get; set; }
        public DbSet<UetDentistryCalculation> UetDentistryCalculation { get; set; }
        #endregion

        public DbSet<Mkb10> Mkb10 { get; set; }

        #endregion

        DatabaseFacade Database { get; }
        public IModel Model
        {
            get
            {
                return base.Model;
            }
        }

        public RefbooksDbContext(DbContextOptions<RefbooksDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region NSI
            #region configure_F
            modelBuilder.RefbookConfigure<F001>();
            modelBuilder.RefbookConfigure<F002>();
            modelBuilder.RefbookConfigure<F003>();
            modelBuilder.RefbookConfigure<F005>();
            modelBuilder.RefbookConfigure<F006>();
            modelBuilder.RefbookConfigure<F007>();
            modelBuilder.RefbookConfigure<F008>();
            modelBuilder.RefbookConfigure<F009>();
            modelBuilder.RefbookConfigure<F010>();
            modelBuilder.RefbookConfigure<F011>();
            modelBuilder.RefbookConfigure<F014>();
            modelBuilder.RefbookConfigure<F015>();
            modelBuilder.RefbookConfigure<F032>();
            modelBuilder.RefbookConfigure<F042>();
            #endregion

            #region configure_N
            modelBuilder.RefbookConfigure<N001>();
            modelBuilder.RefbookConfigure<N002>();
            modelBuilder.RefbookConfigure<N003>();
            modelBuilder.RefbookConfigure<N004>();
            modelBuilder.RefbookConfigure<N005>();
            modelBuilder.RefbookConfigure<N006>();
            modelBuilder.RefbookConfigure<N007>();
            modelBuilder.RefbookConfigure<N008>();
            modelBuilder.RefbookConfigure<N009>();
            modelBuilder.RefbookConfigure<N010>();
            modelBuilder.RefbookConfigure<N011>();
            modelBuilder.RefbookConfigure<N012>();
            modelBuilder.RefbookConfigure<N013>();
            modelBuilder.RefbookConfigure<N014>();
            modelBuilder.RefbookConfigure<N015>();
            modelBuilder.RefbookConfigure<N016>();
            modelBuilder.RefbookConfigure<N017>();
            modelBuilder.RefbookConfigure<N018>();
            modelBuilder.RefbookConfigure<N019>();
            modelBuilder.RefbookConfigure<N020>();
            modelBuilder.RefbookConfigure<N021>();
            #endregion

            #region configure_Q
            modelBuilder.RefbookConfigure<Q015>();
            modelBuilder.RefbookConfigure<Q016>();
            modelBuilder.RefbookConfigure<Q017>();
            modelBuilder.RefbookConfigure<Q018>();
            modelBuilder.RefbookConfigure<Q019>();
            modelBuilder.RefbookConfigure<Q020>();
            modelBuilder.RefbookConfigure<Q021>();
            modelBuilder.RefbookConfigure<Q022>();
            modelBuilder.RefbookConfigure<Q023>();
            #endregion

            #region configure_V
            modelBuilder.RefbookConfigure<V002>();
            modelBuilder.RefbookConfigure<V003>();
            modelBuilder.RefbookConfigure<V005>();
            modelBuilder.RefbookConfigure<V006>();
            modelBuilder.RefbookConfigure<V008>();
            modelBuilder.RefbookConfigure<V009>();
            modelBuilder.RefbookConfigure<V010>();
            modelBuilder.RefbookConfigure<V012>();
            modelBuilder.RefbookConfigure<V013>();
            modelBuilder.RefbookConfigure<V014>();
            modelBuilder.RefbookConfigure<V015>();
            modelBuilder.RefbookConfigure<V016>();
            modelBuilder.RefbookConfigure<V017>();
            modelBuilder.RefbookConfigure<V018>();
            modelBuilder.RefbookConfigure<V019>();
            modelBuilder.RefbookConfigure<V020>();
            modelBuilder.RefbookConfigure<V021>();
            modelBuilder.RefbookConfigure<V022>();
            modelBuilder.RefbookConfigure<V023>();
            modelBuilder.RefbookConfigure<V024>();
            modelBuilder.RefbookConfigure<V025>();
            modelBuilder.RefbookConfigure<V026>();
            modelBuilder.RefbookConfigure<V027>();
            modelBuilder.RefbookConfigure<V028>();
            modelBuilder.RefbookConfigure<V029>();
            modelBuilder.RefbookConfigure<V030>();
            modelBuilder.RefbookConfigure<V031>();
            modelBuilder.RefbookConfigure<V032>();
            modelBuilder.RefbookConfigure<V033>();
            modelBuilder.RefbookConfigure<V036>();
            modelBuilder.RefbookConfigure<V037>();
            #endregion

            #region configure_O
            modelBuilder.RefbookConfigure<O001>();
            modelBuilder.RefbookConfigure<O002>();
            modelBuilder.RefbookConfigure<O003>();
            modelBuilder.RefbookConfigure<O004>();
            modelBuilder.RefbookConfigure<O005>();
            #endregion

            #region configure_K
            modelBuilder.RefbookConfigure<K002>();
            modelBuilder.RefbookConfigure<K003>();
            modelBuilder.RefbookConfigure<K004>();
            #endregion

            #region configure_R
            modelBuilder.RefbookConfigure<R001>();
            modelBuilder.RefbookConfigure<R002>();
            modelBuilder.RefbookConfigure<R003>();
            modelBuilder.RefbookConfigure<R004>();
            modelBuilder.RefbookConfigure<R005>();
            modelBuilder.RefbookConfigure<R006>();
            modelBuilder.RefbookConfigure<R007>();
            modelBuilder.RefbookConfigure<R008>();
            modelBuilder.RefbookConfigure<R009>();
            modelBuilder.RefbookConfigure<R010>();
            modelBuilder.RefbookConfigure<R011>();
            modelBuilder.RefbookConfigure<R012>();
            modelBuilder.RefbookConfigure<R013>();
            modelBuilder.RefbookConfigure<R014>();

            #endregion
            #endregion

            #region Yamed

            #region KsgCalculation
            modelBuilder.RefbookConfigure<CalculationMoCoefficient>();
            modelBuilder.RefbookConfigure<FirstStageAdultMedicalExaminationByServiceCountCalculation>();
            modelBuilder.RefbookConfigure<FirstStageAdultMedicalExaminationCalculation>();
            modelBuilder.RefbookConfigure<FirstStageAdultProfessionalExaminationCalculation>();
            modelBuilder.RefbookConfigure<HematologyTariff>();
            modelBuilder.RefbookConfigure<HighTechMedicalCareTariff>();
            modelBuilder.RefbookConfigure<KsgBaseRate>();
            modelBuilder.RefbookConfigure<KsgCalculation>();
            modelBuilder.RefbookConfigure<KsgGrouper>();
            modelBuilder.RefbookConfigure<ManagementKsgCoefficient>();
            modelBuilder.RefbookConfigure<MobileTeamsMedicalExaminationCoefficient>();
            modelBuilder.RefbookConfigure<OutpatientTariffCalculation>();
            modelBuilder.RefbookConfigure<RegionalLaboratoryStudiesCalculation>();
            modelBuilder.RefbookConfigure<RegionalServiceTariff>();
            modelBuilder.RefbookConfigure<UetDentistryCalculation>();
            modelBuilder.RefbookConfigure<ServiceTemplate>();
            #endregion

            modelBuilder.RefbookConfigure<Mkb10>();

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
