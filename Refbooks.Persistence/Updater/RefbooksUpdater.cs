using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations;
using Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;
using Refbooks.Persistence.Updater.XmlMapperConfigurations.KRefbooksXmlMapperConfigurations;
using Refbooks.Domain.Nsi.QRefbooks;
using Refbooks.Domain.Nsi.VRefbooks;
using Refbooks.Domain.Nsi.RRefbooks;
using Refbooks.Domain.Nsi.ORefbooks;
using Refbooks.Domain.Nsi.FRefbooks;
using Refbooks.Domain.Nsi.NRefbooks;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Persistence.Updater
{
    public class RefbooksUpdater : IRefbookUpdater
    {
        private readonly IRefbooksDbContextFactory _contextFactory;
        private readonly List<string> _resultMessages = new List<string>();
        private readonly string _baseXmlFilesPath; 

        public RefbooksUpdater(IRefbooksDbContextFactory contextFactory, string baseXmlFilesPath)
        {
            _contextFactory = contextFactory;
            _baseXmlFilesPath = baseXmlFilesPath;
        }

        public async Task<IEnumerable<string>> UpdateRefbooksAsync(IEnumerable<string> refbooks)
        {
            using var context = await _contextFactory.CreateDbContextAsync(CancellationToken.None);
            if (!CheckDataBaseConnection(context))
            {
                Log("База данных недоступна, обновление невозможно");
                return _resultMessages;
            }
            

            foreach (var refbook in refbooks)
            {
                List<object> data = null;
                switch (refbook.ToLower())
                {
                    #region case_F
                    case "f001":
                        data = new XmlMapper<F001>("F001.xml", "packet", "TFOMS", Log)
                            .AddF001RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f002":
                        data = new XmlMapper<F002>("F002.xml", "packet", "insCompany", Log)
                            .AddF002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f003":
                        data = new XmlMapper<F003>("F003.xml", "packet", "medCompany", Log)
                            .AddF003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f006":
                        data = new XmlMapper<F006>("F006.xml", "packet", "zap", Log)
                            .AddF006RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f005":
                        data = new XmlMapper<F005>("F005.xml", "packet", "zap", Log)
                            .AddF005RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f007":
                        data = new XmlMapper<F007>("F007.xml", "packet", "zap", Log)
                            .AddF007RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f008":
                        data = new XmlMapper<F008>("F008.xml", "packet", "zap", Log)
                            .AddF008RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f009":
                        data = new XmlMapper<F009>("F009.xml", "packet", "zap", Log)
                            .AddF009RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f010":
                        data = new XmlMapper<F010>("F010.xml", "packet", "zap", Log)
                            .AddF010RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f011":
                        data = new XmlMapper<F011>("F011.xml", "packet", "zap", Log)
                            .AddF011RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f014":
                        data = new XmlMapper<F014>("F014.xml", "packet", "zap", Log)
                            .AddF014RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f015":
                        data = new XmlMapper<F015>("F015.xml", "packet", "zap", Log)
                            .AddF015RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f032":
                        data = new XmlMapper<F032>("F032.xml", "packet", "zap", Log)
                            .AddF032RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "f042":
                        data = new XmlMapper<F042>("F042.xml", "packet", "zap", Log)
                            .AddF042RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion

                    #region case_Q
                    case "q015":
                        data = new XmlMapper<Q015>("Q015.xml", "packet", "zap", Log)
                            .AddQ015RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q016":
                        data = new XmlMapper<Q016>("Q016.xml", "packet", "zap", Log)
                            .AddQ016RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q017":
                        data = new XmlMapper<Q017>("Q017.xml", "packet", "zap", Log)
                            .AddQ017RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q018":
                        data = new XmlMapper<Q018>("Q018.xml", "packet", "zap", Log)
                            .AddQ018RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q019":
                        data = new XmlMapper<Q019>("Q019.xml", "packet", "zap", Log)
                            .AddQ019RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q020":
                        data = new XmlMapper<Q020>("Q020.xml", "packet", "zap", Log)
                            .AddQ020RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q021":
                        data = new XmlMapper<Q021>("Q021.xml", "packet", "zap", Log)
                            .AddQ021RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q022":
                        data = new XmlMapper<Q022>("Q022.xml", "packet", "zap", Log)
                            .AddQ022RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "q023":
                        data = new XmlMapper<Q023>("Q023.xml", "packet", "zap", Log)
                            .AddQ023RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion

                    #region case_V
                    case "v002":
                        data = new XmlMapper<V002>("V002.xml", "packet", "zap", Log)
                            .AddV002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v003":
                        data = new XmlMapper<V003>("V003.xml", "packet", "zap", Log)
                            .AddV003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v005":
                        data = new XmlMapper<V005>("V005.xml", "packet", "zap", Log)
                            .AddV005RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v006":
                        data = new XmlMapper<V006>("V006.xml", "packet", "zap", Log)
                            .AddV006RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v008":
                        data = new XmlMapper<V008>("V008.xml", "packet", "zap", Log)
                            .AddV008RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v009":
                        data = new XmlMapper<V009>("V009.xml", "packet", "zap", Log)
                            .AddV009RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v010":
                        data = new XmlMapper<V010>("V010.xml", "packet", "zap", Log)
                            .AddV010RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v012":
                        data = new XmlMapper<V012>("V012.xml", "packet", "zap", Log)
                            .AddV012RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v013":
                        data = new XmlMapper<V013>("V013.xml", "packet", "zap", Log)
                            .AddV013RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v014":
                        data = new XmlMapper<V014>("V014.xml", "packet", "zap", Log)
                            .AddV014RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v015":
                        data = new XmlMapper<V015>("V015.xml", "packet", "zap", Log)
                            .AddV015RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v016":
                        data = new XmlMapper<V016>("V016.xml", "packet", "zap", Log)
                            .AddV016RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v017":
                        data = new XmlMapper<V017>("V017.xml", "packet", "zap", Log)
                            .AddV017RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v018":
                        data = new XmlMapper<V018>("V018.xml", "packet", "zap", Log)
                            .AddV018RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v019":
                        data = new XmlMapper<V019>("V019.xml", "packet", "zap", Log)
                            .AddV019RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v020":
                        data = new XmlMapper<V020>("V020.xml", "packet", "zap", Log)
                            .AddV020RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v021":
                        data = new XmlMapper<V021>("V021.xml", "packet", "zap", Log)
                            .AddV021RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v022":
                        data = new XmlMapper<V022>("V022.xml", "packet", "zap", Log)
                            .AddV022RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v023":
                        data = new XmlMapper<V023>("V023.xml", "packet", "zap", Log)
                            .AddV023RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v024":
                        data = new XmlMapper<V024>("V024.xml", "packet", "zap", Log)
                            .AddV024RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v025":
                        data = new XmlMapper<V025>("V025.xml", "packet", "zap", Log)
                            .AddV025RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v026":
                        data = new XmlMapper<V026>("V026.xml", "packet", "zap", Log)
                            .AddV026RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v027":
                        data = new XmlMapper<V027>("V027.xml", "packet", "zap", Log)
                            .AddV027RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v028":
                        data = new XmlMapper<V028>("V028.xml", "packet", "zap", Log)
                            .AddV028RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v029":
                        data = new XmlMapper<V029>("V029.xml", "packet", "zap", Log)
                            .AddV029RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v030":
                        data = new XmlMapper<V030>("V030.xml", "packet", "zap", Log)
                            .AddV030RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v031":
                        data = new XmlMapper<V031>("V031.xml", "packet", "zap", Log)
                            .AddV031RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v032":
                        data = new XmlMapper<V032>("V032.xml", "packet", "zap", Log)
                            .AddV032RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v033":
                        data = new XmlMapper<V033>("V033.xml", "packet", "zap", Log)
                            .AddV033RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v036":
                        data = new XmlMapper<V036>("V036.xml", "packet", "zap", Log)
                            .AddV036RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "v037":
                        data = new XmlMapper<V037>("V037.xml", "packet", "zap", Log)
                            .AddV037RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion

                    #region case_N
                    case "n001":
                        data = new XmlMapper<N001>("N001.xml", "packet", "zap", Log)
                            .AddN001RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n002":
                        data = new XmlMapper<N002>("N002.xml", "packet", "zap", Log)
                            .AddN002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n003":
                        data = new XmlMapper<N003>("N003.xml", "packet", "zap", Log)
                            .AddN003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n004":
                        data = new XmlMapper<N004>("N004.xml", "packet", "zap", Log)
                            .AddN004RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n005":
                        data = new XmlMapper<N005>("N005.xml", "packet", "zap", Log)
                            .AddN005RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n006":
                        data = new XmlMapper<N006>("N006.xml", "packet", "zap", Log)
                            .AddN006RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n007":
                        data = new XmlMapper<N007>("N007.xml", "packet", "zap", Log)
                            .AddN007RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n008":
                        data = new XmlMapper<N008>("N008.xml", "packet", "zap", Log)
                            .AddN008RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n009":
                        data = new XmlMapper<N009>("N009.xml", "packet", "zap", Log)
                            .AddN009RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n010":
                        data = new XmlMapper<N010>("N010.xml", "packet", "zap", Log)
                            .AddN010RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n011":
                        data = new XmlMapper<N011>("N011.xml", "packet", "zap", Log)
                            .AddN011RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n012":
                        data = new XmlMapper<N012>("N012.xml", "packet", "zap", Log)
                            .AddN012RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n013":
                        data = new XmlMapper<N013>("N013.xml", "packet", "zap", Log)
                            .AddN013RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n014":
                        data = new XmlMapper<N014>("N014.xml", "packet", "zap", Log)
                            .AddN014RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n015":
                        data = new XmlMapper<N015>("N015.xml", "packet", "zap", Log)
                            .AddN015RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n016":
                        data = new XmlMapper<N016>("N016.xml", "packet", "zap", Log)
                            .AddN016RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n017":
                        data = new XmlMapper<N017>("N017.xml", "packet", "zap", Log)
                            .AddN017RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n018":
                        data = new XmlMapper<N018>("N018.xml", "packet", "zap", Log)
                            .AddN018RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n019":
                        data = new XmlMapper<N019>("N019.xml", "packet", "zap", Log)
                            .AddN019RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n020":
                        data = new XmlMapper<N020>("N020.xml", "packet", "zap", Log)
                            .AddN020RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "n021":
                        data = new XmlMapper<N021>("N021.xml", "packet", "zap", Log)
                            .AddN021RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion

                    #region case_O
                    case "o001":
                        data = new XmlMapper<O001>("O001.xml", "packet", "zap", Log)
                            .AddO001RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "o002":
                        data = new XmlMapper<O002>("O002.xml", "packet", "zap", Log)
                            .AddO002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "o003":
                        data = new XmlMapper<O003>("O003.xml", "packet", "zap", Log)
                            .AddO003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "o004":
                        data = new XmlMapper<O004>("O004.xml", "packet", "zap", Log)
                            .AddO004RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "o005":
                        data = new XmlMapper<O005>("O005.xml", "packet", "zap", Log)
                            .AddO005RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion
                    
                    #region case_R
                    case "r001":
                        data = new XmlMapper<R001>("R001.xml", "packet", "zap", Log)
                            .AddR001RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r002":
                        data = new XmlMapper<R002>("R002.xml", "packet", "zap", Log)
                            .AddR002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r003":
                        data = new XmlMapper<R003>("R003.xml", "packet", "zap", Log)
                            .AddR003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r004":
                        data = new XmlMapper<R004>("R004.xml", "packet", "zap", Log)
                            .AddR004RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r005":
                        data = new XmlMapper<R005>("R005.xml", "packet", "zap", Log)
                            .AddR005RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r006":
                        data = new XmlMapper<R006>("R006.xml", "packet", "zap", Log)
                            .AddR006RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r007":
                        data = new XmlMapper<R007>("R007.xml", "packet", "zap", Log)
                            .AddR007RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r008":
                        data = new XmlMapper<R008>("R008.xml", "packet", "zap", Log)
                            .AddR008RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r009":
                        data = new XmlMapper<R009>("R009.xml", "packet", "zap", Log)
                            .AddR009RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r010":
                        data = new XmlMapper<R010>("R010.xml", "packet", "zap", Log)
                            .AddR010RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r011":
                        data = new XmlMapper<R011>("R011.xml", "packet", "zap", Log)
                            .AddR011RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r012":
                        data = new XmlMapper<R012>("R012.xml", "packet", "zap", Log)
                            .AddR012RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r013":
                        data = new XmlMapper<R013>("R013.xml", "packet", "zap", Log)
                            .AddR013RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "r014":
                        data = new XmlMapper<R014>("R014.xml", "packet", "entry", Log)
                            .AddR014RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion
                    

                    #region case_K
                    case "k002":
                        data = new XmlMapper<K002>("K002.xml", "packet", "zap", Log)
                            .AddK002RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "k003":
                        data = new XmlMapper<K003>("K003.xml", "packet", "zap", Log)
                            .AddK003RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    case "k004":
                        data = new XmlMapper<K004>("K004.xml", "packet", "zap", Log)
                            .AddK004RefbookConfiguration()
                            .ToEnumerable(_baseXmlFilesPath)
                            .ToList()
                            .ConvertAll(x => (object)x);
                        break;
                    #endregion

                    default:
                        Log($"Справочник {refbook} недоступен для обновления");
                        continue;
                }

                if (data.Count == 0 || data is null)
                {
                    Log($"Справочник {refbook} не имеет данных, обновление невозможно");
                    continue;
                }

                if (await UpdateRefBookAsync(data))
                    Log($"Справочник {refbook} обновлен");
                else
                    Log($"При обновлении справочника {refbook} произошла ошибка");

            }

            return _resultMessages;
        }

        private async Task<bool> UpdateRefBookAsync(List<object> data)
        {
            using var context = await _contextFactory.CreateDbContextAsync(CancellationToken.None);

            var name = data[0].ToString();
            if (name is null)
                return false;

            var tableName = context.Model.FindEntityType(name).GetTableName();
            if (string.IsNullOrWhiteSpace(tableName))
                return false;

            using (var transaction = context.Database.BeginTransaction())
            {
                if (!ClearTable(context, tableName))
                {
                    transaction.Rollback();
                    return false;
                }

                try
                {
                    await context.AddRangeAsync(data);
                    await context.SaveChangesAsync(CancellationToken.None);
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Log(ex.InnerException?.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        private bool ClearTable(IRefbooksDbContext context, string tableName)
        {
            try
            {
                context.Database.ExecuteSqlRaw($"TRUNCATE TABLE \"{tableName}\" RESTART IDENTITY CASCADE;");
                return true;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return false;
            }
        }

        private bool CheckDataBaseConnection(IRefbooksDbContext context) => context.Database.CanConnect();

        public void Log(string? text)
        {
            _resultMessages.Add(text);
        }
    }
}
