using System.Xml;
using System.Xml.Linq;

namespace Refbooks.Persistence.Updater
{
    public class XmlMapper<T> where T : new()
    {
        public XmlMapper(string fileName, string rootElement, string recordName, Action<string?> addMessage)
        {
            _fileName = fileName;
            _rootElement = rootElement;
            _recordName = recordName;
            _mappers = new List<Action<XElement, T>>();
            _addMessage = addMessage;
        }

        private readonly string _fileName;
        private readonly string _rootElement;
        private readonly string _recordName;
        private readonly List<Action<XElement, T>> _mappers;
        private readonly Action<string?> _addMessage;


        private XmlReader? CreateReader(string basePath)
        {
            string filePath = basePath + _fileName;

            try
            {
                if (File.Exists(filePath))
                    return XmlReader.Create(filePath, 
                        new XmlReaderSettings() 
                        { IgnoreWhitespace = true,
                            IgnoreComments = true,
                            DtdProcessing = DtdProcessing.Ignore
                        });
            }
            catch (Exception e)
            {
                _addMessage.Invoke($"{filePath}: {e.Message}");
                return null;
            }

            _addMessage.Invoke("Файл " + filePath + " не найден");
            return null;
        }

        public XmlMapper<T> MapWith(Action<XElement, T> mapFunc)
        {
            _mappers.Add(mapFunc);
            return this;
        }

        public IEnumerable<T> ToEnumerable(string basePath)
        {
            var reader = CreateReader(basePath);
            if (reader is null) yield break;

            reader.ReadToFollowing(_recordName);

            var record = XElement.ReadFrom(reader) as XElement;

            while (record!= null)
            {
                var model = new T();
                foreach (var mapper in _mappers)
                {
                    mapper(record, model);
                }

                if (reader.Name != _rootElement)
                    record = XElement.ReadFrom(reader) as XElement;
                else
                    record = null;

                yield return model;
                
            }

            reader.Close();
        }
    }
}
