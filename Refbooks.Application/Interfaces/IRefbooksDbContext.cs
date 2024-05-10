using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Refbooks.Domain.Nsi.FRefbooks;
using Refbooks.Domain.Nsi.KRefbooks;
using Refbooks.Domain.Nsi.NRefbooks;
using Refbooks.Domain.Nsi.ORefbooks;
using Refbooks.Domain.Nsi.QRefbooks;
using Refbooks.Domain.Nsi.RRefbooks;
using Refbooks.Domain.Nsi.VRefbooks;
using Refbooks.Domain.Yamed.KsgCalculation;
using Refbooks.Domain.Yamed;

namespace Refbooks.Application.Interfaces
{
    public interface IRefbooksDbContext : IDisposable
    {
        public DatabaseFacade Database { get; }
        public IModel Model { get; }

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
        DbSet<Q015> Q015 { get; set; }
        DbSet<Q016> Q016 { get; set; }
        DbSet<Q017> Q017 { get; set; }
        DbSet<Q018> Q018 { get; set; }
        DbSet<Q019> Q019 { get; set; }
        DbSet<Q020> Q020 { get; set; }
        DbSet<Q021> Q021 { get; set; }
        DbSet<Q022> Q022 { get; set; }
        DbSet<Q023> Q023 { get; set; }
        #endregion

        #region DbSet_V
        DbSet<V002> V002 { get; set; }
        DbSet<V003> V003 { get; set; }
        DbSet<V005> V005 { get; set; }
        DbSet<V006> V006 { get; set; }
        DbSet<V008> V008 { get; set; }
        DbSet<V009> V009 { get; set; }
        DbSet<V010> V010 { get; set; }
        DbSet<V012> V012 { get; set; }
        DbSet<V013> V013 { get; set; }
        DbSet<V014> V014 { get; set; }
        DbSet<V015> V015 { get; set; }
        DbSet<V016> V016 { get; set; }
        DbSet<V017> V017 { get; set; }
        DbSet<V018> V018 { get; set; }
        DbSet<V019> V019 { get; set; }
        DbSet<V020> V020 { get; set; }
        DbSet<V021> V021 { get; set; }
        DbSet<V022> V022 { get; set; }
        DbSet<V023> V023 { get; set; }
        DbSet<V024> V024 { get; set; }
        DbSet<V025> V025 { get; set; }
        DbSet<V026> V026 { get; set; }
        DbSet<V027> V027 { get; set; }
        DbSet<V028> V028 { get; set; }
        DbSet<V029> V029 { get; set; }
        DbSet<V030> V030 { get; set; }
        DbSet<V031> V031 { get; set; }
        DbSet<V032> V032 { get; set; }
        DbSet<V033> V033 { get; set; }
        DbSet<V036> V036 { get; set; }
        DbSet<V037> V037 { get; set; }
        #endregion

        #region DbSet_O
        DbSet<O001> O001 { get; set; }
        DbSet<O002> O002 { get; set; }
        DbSet<O003> O003 { get; set; }
        DbSet<O004> O004 { get; set; }
        DbSet<O005> O005 { get; set; }
        #endregion

        #region DbSet_K
        DbSet<K002> K002 { get; set; }
        DbSet<K003> K003 { get; set; }
        DbSet<K004> K004 { get; set; }
        #endregion

        #region DbSet_R
        DbSet<R001> R001 { get; set; }
        DbSet<R002> R002 { get; set; }
        DbSet<R003> R003 { get; set; }
        DbSet<R004> R004 { get; set; }
        DbSet<R005> R005 { get; set; }
        DbSet<R006> R006 { get; set; }
        DbSet<R007> R007 { get; set; }
        DbSet<R008> R008 { get; set; }
        DbSet<R009> R009 { get; set; }
        DbSet<R010> R010 { get; set; }
        DbSet<R011> R011 { get; set; }
        DbSet<R012> R012 { get; set; }
        DbSet<R013> R013 { get; set; }
        DbSet<R014> R014 { get; set; }
        #endregion

        #endregion

        #region Yamed

        #region KsgCalculation
        public DbSet<CalculationMoCoefficient> CalculationMoCoefficients { get; set; }
        public DbSet<FirstStageAdultMedicalExaminationByServiceCountCalculation> FirstStageAdultMedicalExaminationByServiceCountCalculation { get; set; }
        public DbSet<FirstStageAdultMedicalExaminationCalculation> FirstStageAdultMedicalExaminationCalculation { get; set; }
        public DbSet<FirstStageAdultProfessionalExaminationCalculation> FirstStageAdultProfessionalExaminationCalculation { get; set; }
        public DbSet<HematologyTariff> HematologyTariffs { get; set; }
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
        public DbSet<ServiceTemplate> ServiceTemplates { get; set; }
        #endregion

        public DbSet<Mkb10> Mkb10 { get; set; }

        #endregion

        public Task AddRangeAsync(IEnumerable<object> entities,
            CancellationToken cancellationToken = default);

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
