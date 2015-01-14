using System.Collections.Generic;
using MoqaLate.CodeModel;

namespace MoqaLate.InterfaceTextParsing
{
    public interface IInterfaceLineTextParser
    {
        ClassSpecification GenerateClass(string interfaceCode);        
    }
}