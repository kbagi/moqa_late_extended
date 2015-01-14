using ICSharpCode.NRefactory.CSharp;
using MoqaLate.CodeModel;
using MoqaLate.Common;

namespace MoqaLate.InterfaceTextParsing
{
    public class InterfaceLineTextLineTextParser : IInterfaceLineTextParser
    {
        private const string UsingSymbol = "using ";
        private const string InterfaceSymbol = "interface ";
        private readonly ILogger _logger;

        private ClassSpecification _classSpec;
        private string _interfaceCode;
        private ClassNodeVisitor _visitor;

        public InterfaceLineTextLineTextParser(ILogger logger)
        {
            _logger = logger;
        }

        #region IInterfaceLineTextParser Members

        public ClassSpecification GenerateClass(string interfaceCode)
        {
            _classSpec = new ClassSpecification();

            _interfaceCode = interfaceCode;

            _classSpec = new ClassSpecification();

            var parser = new CSharpParser();
            var syntaxTree = parser.Parse(_interfaceCode);
            _visitor = new ClassNodeVisitor();

            syntaxTree.AcceptVisitor(_visitor);
            if (_visitor.InterfaceName == null)
            {
                return _classSpec;
            }

            ParseClassName();
           
            _logger.Write("Parsing containing namespace");
            _classSpec.OriginalInterfaceNamespace = _visitor.NamespaceName;

            _logger.Write("Parsing using statements");
            _classSpec.Usings = _visitor.Usings;

            _logger.Write("Parsing properties");
            _classSpec.Properties.AddRange(_visitor.Properties);

            _logger.Write("Parsing methods");
            _classSpec.Methods.AddRange(_visitor.Methods);

            _logger.Write("Parsing events");
            _classSpec.Events.AddRange(_visitor.Events);

            return _classSpec;
        }

        #endregion       

        private void ParseClassName()
        {
            _logger.Write("Parsing class name (looking for 'interface' text)");
            _classSpec.ClassName = _visitor.InterfaceName.Substring(1) + "MoqaLate";
            _classSpec.OriginalInterfaceName = _visitor.InterfaceName;
            _classSpec.IsPublic = _visitor.IsPublic;
        }       
    }
}