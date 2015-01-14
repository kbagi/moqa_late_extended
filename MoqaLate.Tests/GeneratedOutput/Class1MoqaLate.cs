using System;
using System.Collections.Generic;
using System.IO.Compression;
using MoqaLate.Tests.Integration.SampleFiles.a;
namespace MoqaLate.Autogenerated
{
public partial class Class1MoqaLate : IClass1
{
// ------------ Property Prop1
private string _Prop1;
public virtual string Prop1
{
get { return _Prop1; }
set { _Prop1 = value; }
}
public virtual void __SetProp1(string val)
{
   _Prop1 = val;
}
// ------------ Property Prop2
private string _Prop2;
public virtual string Prop2
{
get { return _Prop2; }
}
public virtual void __SetProp2(string val)
{
   _Prop2 = val;
}
// ------------ Property Prop3
private string _Prop3;
public virtual string Prop3
{
set { _Prop3 = value; }
}
public virtual void __SetProp3(string val)
{
   _Prop3 = val;
}


// -------------- DoIt2 ------------ 

private string _doIt2ReturnValue;

        private int _doIt2NumberOfTimesCalled;

        public int DoIt2Parameter_p1_LastCalledWith;public List<int> DoIt2Parameter_p2_LastCalledWith;
        
        public virtual void DoIt2SetReturnValue(string value)
        {
            _doIt2ReturnValue = value;
        }    


        public virtual bool DoIt2WasCalled()
{
   return _doIt2NumberOfTimesCalled > 0;
}


public virtual bool DoIt2WasCalled(int times)
{
   return _doIt2NumberOfTimesCalled == times;
}


public virtual int DoIt2TimesCalled()
{
   return _doIt2NumberOfTimesCalled;
}


public virtual bool DoIt2WasCalledWith(int p1, List<int> p2){
return (
p1.Equals(DoIt2Parameter_p1_LastCalledWith)  && 
p2.Equals(DoIt2Parameter_p2_LastCalledWith) );
}
 

             public string DoIt2(int p1, List<int> p2)
        {
            _doIt2NumberOfTimesCalled++;            

            DoIt2Parameter_p1_LastCalledWith = p1;DoIt2Parameter_p2_LastCalledWith = p2;

            return _doIt2ReturnValue;
        }

// -------------- DoIt ------------ 

private string _doItReturnValue;

        private int _doItNumberOfTimesCalled;

        public int DoItParameter_p1_LastCalledWith;public List<int> DoItParameter_p2_LastCalledWith;
        
        public virtual void DoItSetReturnValue(string value)
        {
            _doItReturnValue = value;
        }    


        public virtual bool DoItWasCalled()
{
   return _doItNumberOfTimesCalled > 0;
}


public virtual bool DoItWasCalled(int times)
{
   return _doItNumberOfTimesCalled == times;
}


public virtual int DoItTimesCalled()
{
   return _doItNumberOfTimesCalled;
}


public virtual bool DoItWasCalledWith(int p1, List<int> p2){
return (
p1.Equals(DoItParameter_p1_LastCalledWith)  && 
p2.Equals(DoItParameter_p2_LastCalledWith) );
}
 

             public string DoIt(int p1, List<int> p2)
        {
            _doItNumberOfTimesCalled++;            

            DoItParameter_p1_LastCalledWith = p1;DoItParameter_p2_LastCalledWith = p2;

            return _doItReturnValue;
        }

// -------------- LetsDoIt ------------


        private int _letsDoItNumberOfTimesCalled;        

        public Func<bool, int> LetsDoItParameter_p1_LastCalledWith;public string LetsDoItParameter_p2_LastCalledWith;

        public virtual bool LetsDoItWasCalled()
{
   return _letsDoItNumberOfTimesCalled > 0;
}


public virtual bool LetsDoItWasCalled(int times)
{
   return _letsDoItNumberOfTimesCalled == times;
}


public virtual int LetsDoItTimesCalled()
{
   return _letsDoItNumberOfTimesCalled;
}


public virtual bool LetsDoItWasCalledWith(Func<bool, int> p1, string p2){
return (
p1.Equals(LetsDoItParameter_p1_LastCalledWith)  && 
p2.Equals(LetsDoItParameter_p2_LastCalledWith) );
}


        public void LetsDoIt(Func<bool, int> p1, string p2)
        {
            _letsDoItNumberOfTimesCalled++;            

            LetsDoItParameter_p1_LastCalledWith = p1;LetsDoItParameter_p2_LastCalledWith = p2;
        }


// -------------- DStuff4 ------------ 

private Func<bool, int> _dStuff4ReturnValue;

        private int _dStuff4NumberOfTimesCalled;

        
        
        public virtual void DStuff4SetReturnValue(Func<bool, int> value)
        {
            _dStuff4ReturnValue = value;
        }    


        public virtual bool DStuff4WasCalled()
{
   return _dStuff4NumberOfTimesCalled > 0;
}


public virtual bool DStuff4WasCalled(int times)
{
   return _dStuff4NumberOfTimesCalled == times;
}


public virtual int DStuff4TimesCalled()
{
   return _dStuff4NumberOfTimesCalled;
}


 

             public Func<bool, int> DStuff4()
        {
            _dStuff4NumberOfTimesCalled++;            

            

            return _dStuff4ReturnValue;
        }public virtual event EventHandler E1;
public virtual event Action E2;
public virtual event Action<int> E3;
public virtual event Action<int,string> E4;
public virtual event EventHandler<AssemblyLoadEventArgs> E5;
}
}