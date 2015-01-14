using System.Collections.Generic;
using System.Linq;
using ICSharpCode.NRefactory.CSharp;
using MoqaLate.CodeModel;

namespace MoqaLate.Common
{
    internal class ClassNodeVisitor : DepthFirstAstVisitor
    {
        public List<Method> Methods = new List<Method>();
        public MethodParameterList Parameters = new MethodParameterList();
        public string NamespaceName { get; set; }
        public string InterfaceName { get; set; }
        public bool IsPublic { get; set; }
        public List<string> Usings = new List<string>();
        public List<Property> Properties = new List<Property>();
        public List<Event> Events = new List<Event>();

        public override void VisitMethodDeclaration(MethodDeclaration methodDeclaration)
        {
            base.VisitMethodDeclaration(methodDeclaration);

            var method = new Method()
            {
                Name = methodDeclaration.Name,                
                ReturnType = methodDeclaration.ReturnType.ToString()
            };

            var parameters = methodDeclaration.Parameters.Select(p => new MethodParameter
            {
                Name = p.Name,
                Type = p.Type.ToString()
            }).ToList();

            foreach (var methodParameter in parameters)
            {
                method.Parameters.Add(methodParameter);
            }

            Methods.Add(method);
        }

        public override void VisitNamespaceDeclaration(NamespaceDeclaration namespaceDeclaration)
        {
            base.VisitNamespaceDeclaration(namespaceDeclaration);
            NamespaceName = namespaceDeclaration.Name;
        }       

        public override void VisitUsingDeclaration(UsingDeclaration usingDeclaration)
        {
            base.VisitUsingDeclaration(usingDeclaration);
            Usings.Add(usingDeclaration.Namespace);
            
        }

        public override void VisitPropertyDeclaration(PropertyDeclaration propertyDeclaration)
        {
            base.VisitPropertyDeclaration(propertyDeclaration);
            Properties.Add(new Property { 
                Accessor = GetAccessor(propertyDeclaration), 
                Name = propertyDeclaration.Name,
                Type = propertyDeclaration.ReturnType.ToString()
            });
        }

        private PropertyAccessor GetAccessor(PropertyDeclaration propertyDeclaration)
        {
            if (propertyDeclaration.Getter != null && propertyDeclaration.Setter != null)
            {
                return PropertyAccessor.GetAndSet;
            }

            if (propertyDeclaration.Setter != null)
            {
                return PropertyAccessor.SetOny;               
            }
            return PropertyAccessor.GetOny;
        }
      
        public override void VisitTypeDeclaration(TypeDeclaration typeDeclaration)
        {
            base.VisitTypeDeclaration(typeDeclaration);
            InterfaceName = typeDeclaration.ClassType != ClassType.Interface ? (string) null : typeDeclaration.Name;
            IsPublic = typeDeclaration.HasModifier(Modifiers.Public);
        }        
    }
}
