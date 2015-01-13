using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.NRefactory.CSharp;
using MoqaLate.CodeModel;

namespace MoqaLate.Common
{
    internal class ClassNodeVisitor : DepthFirstAstVisitor
    {
        public List<Method> Methods = new List<Method>();
        public MethodParameterList Parameters = new MethodParameterList();

        public override void VisitMethodDeclaration(MethodDeclaration methodDeclaration)
        {
            base.VisitMethodDeclaration(methodDeclaration);

            var method = new Method()
            {
                Name = methodDeclaration.Name,
                Parameters = (MethodParameterList) methodDeclaration.Parameters.Select(p => new MethodParameter
                {
                    Name = p.Name,
                    Type = p.Type.ToString()
                }),
                ReturnType = methodDeclaration.ReturnType.ToString()
            };

            Methods.Add(method);
        }
    }
}
