using System;
using NUnit.Framework;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class MethodsFocusTeam : ProtoTestBase
    {
        [Test]
        public void SimpleCtorResolution01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2);
        }

        [Test]
        public void T_upgrade()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1 };
            thisTest.Verify("a", v1);

        }

        [Test]
        public void SimpleCtorResolution02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2);
        }

        [Test]
        public void T002_DotOp_DefautConstructor_IntProperty()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            //Assert.Fail("0.0 should not be evaluated to be the same as 'null' in verification");
            thisTest.Verify("x", 1);
        }

        [Test]
        public void T002_DotOp_DefautConstructor_DoubleProperty()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1.0);
        }

        [Test]
        public void T002_DotOp_DefautConstructor_ArrayProperty()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", new object[] { 1, 2, 3, 4, 5 });
        }

        [Test]
        public void T006_DotOp_SelfDefinedConstructor_01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 10);
        }

        [Test]
        [Category("Class")]
        public void T007_DotOp_SelfDefinedConstructor_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 10.0);
            thisTest.Verify("y", 20.0);
        }

        [Test]
        public void TV1467134_intToDouble_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 2.0);
        }

        [Test]
        public void TV1467134_intToDouble_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 4.1415926);
        }


        [Test]
        public void T008_DotOp_MultiConstructor_01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1);
            thisTest.Verify("y", 2);
        }

        [Test]
        public void T009_DotOp_FuncCall()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2.0);
            thisTest.Verify("y", 3.0);
            thisTest.Verify("z", 4.0);
        }

        [Test]
        public void T010_DotOp_Property()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("z", 5.0);
        }

        [Test]
        public void ArrayInFunction()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v2 = new Object[] { 1, 2, 3 };
            thisTest.Verify("n", v2);
        }

        [Test]
        [Category("Class")]
        public void T012_DotOp_UserDefinedClass_01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 3);
            thisTest.Verify("r2", 3);
            thisTest.Verify("r3", 5);
        }

        [Test]
        [Category("Class")]
        public void T013_DotOp_UserDefinedClass_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1, 2, 3 };
            Object[] v2 = new Object[] { 1, 2, 3 };
            Object[] v3 = new Object[] { 1, 2, 3, 4, 5 };
            thisTest.Verify("r1", v1);
            thisTest.Verify("r2", v2);
            thisTest.Verify("r3", v3);
        }

        [Test]
        [Category("Class")]
        public void TV1467372_ThisKeyword_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("ra", 1);
        }

        [Test]
        [Category("Class")]
        public void TV1467372_ThisKeyword_2_Replication()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1, 1 };
            thisTest.Verify("ra", v1);
        }

        [Test]
        [Category("Class")]
        public void TV1467372_ThisKeyword_3()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1, 1 };
            Object[] v2 = new Object[] { 2, 2 };
            thisTest.Verify("ra", v1);
            thisTest.Verify("rb", v2);
        }

        [Test]
        public void T015_DotOp_Collection_01()
        {
            String code =
@"
import(""FFITarget.dll"");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", true);
        }

        [Test]
        public void T015_DotOp_Collection_01a()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", true);
        }

        [Test]
        public void T016_Collection_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 0 };
            Object[] v2 = new Object[] { 1 };
            Object[] v3 = new Object[] { 2 };
            Object[] v4 = new Object[] { v1, v2, v3 };
            thisTest.Verify("r1", v4);
        }

        [Test]
        public void T017_DotOp_Collection_03()
        {
            String code =
@"
            thisTest.RunScriptSource(code);

            thisTest.Verify("r1", 1);
        }

        [Test]
        public void T018_DotOp_Collection_04()
        {
            String code =
                    @"
            thisTest.RunScriptSource(code);
            Object[] v = { 1, 2 };
            thisTest.Verify("x", v);

        }

        [Test]
        public void TV018_DotOp_Collection_04_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v = { 2, 3 };
            thisTest.Verify("x", v);
        }

        [Test]
        public void TV018_DotOp_Collection_04_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object v1 = null;
            thisTest.Verify("r", v1);
        }

        [Test]
        public void TV018_DotOp_Collection_04_3()
        {
            String code =
                    @"
            thisTest.RunScriptSource(code);
            Object[] v = { 1, 2 };
            thisTest.Verify("x", v);
        }

        [Test]
        public void TV018_DotOp_Collection_04_4()
        {
            String code =
                    @"
            thisTest.RunScriptSource(code);
            Object[] v = { 2, 3 };
            thisTest.Verify("x", v);
        }

        [Test]
        public void DotCallOnEmptyList()
        {
            string code = @"x = [[], []]; y = x.foo();";
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", new object [] { new object [] { }, new object [] { } });
        }

        [Test]
        public void T020_Replication_Var()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object v1 = new Object[] { 2, 3 };
            thisTest.Verify("r", v1);
        }

        [Test]
        public void T019_DotOp_Collection_05()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1);

        }

        [Test]
        public void T019_DotOp_Collection_06()
        {
            String code =

@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2);


        }


        [Test]
        public void T019_DotOp_Collection_07()
        {
            String code =

@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 3);


        }

        [Test]
        [Category("Class")]
        public void TV1467137_1_DotOp_Update()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 10, 11 };
            thisTest.Verify("r1", v1);
            thisTest.Verify("r2", v1);
            thisTest.Verify("r3", v1);
        }

        [Test]
        [Category("Class")]
        public void TV1467333()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.SetErrorMessage("1467333 - Sprint 27 - Rev 3959: when initializing class member, array is converted to not indexable type, which gives wrong result");
            Object v1 = null;
            //thisTest.Verify("va", v1); (as the constuction of the object is valid even if the assignment fails)
            thisTest.Verify("m", v1);
            thisTest.Verify("s", v1);
            thisTest.Verify("r", true);
        }

        [Test]
        public void T025_DotOp_FuncCall_04()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1.0, 2.0, 3.0 };
            thisTest.Verify("r", v1);

        }

        [Test]
        [Category("Class")]
        public void TV025_1467140_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 0, 1 };
            Object[] v2 = new Object[] { 0, 1 };
            thisTest.Verify("r", v1);
            thisTest.Verify("r2", v2);
        }

        [Test]
        [Category("Class")]
        public void TV025_1467140_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 0, 1 };
            Object[] v2 = new Object[] { 10, 11 };
            thisTest.Verify("r", v1);
            thisTest.Verify("r2", v2);
        }

        [Test]
        [Category("Class")]
        public void T028_Inheritance_Property()
        {
            String code =
@"
            // Assert.Fail("1467141 - Sprint 24 - Rev 2954: declare a property in subclass with the same name as the property in super class will cause Nunit crash");
            Assert.Throws(typeof(ProtoCore.Exceptions.CompileErrorsOccured), () =>
           {
               thisTest.RunScriptSource(code);
           });
        }

        [Test]
        [Category("Class")]
        public void T029_Inheritance_Property_1()
        {
            String code =
@"

            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 1);
            thisTest.Verify("r2", null);
            thisTest.Verify("r3", 2);
            
        }

        [Test]
        [Category("Class")]
        public void T030_Inheritance_Property_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 10);
        }


        [Test]
        [Category("Class")]
        public void T031_Inheritance_Property_3()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1, 2 };
            Object[] v2 = new Object[] { 12, 13 };
            thisTest.Verify("r1", v1);
            thisTest.Verify("r2", v1);
            thisTest.Verify("r3", v2);
            thisTest.Verify("r4", null);
        }

        [Test]
        public void T032_ReservationCheck_rangeExp()
        {
            String code =
@"
            thisTest.RunScriptSource(code);

            thisTest.Verify("r1", 1);
        }

        [Test]
        public void T033_PushThroughCasting()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object r = 3;
            thisTest.Verify("r", r);
        }

        [Test]
        [Category("Class")]
        public void T033_PushThroughCasting_UserDefinedType()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 3);
        }

        [Test]
        public void T034_PushThroughCastingWithReplication()
        {
            //DNL-1467147 When arguments are up-converted to a var during replication, the type of the value is changed, not the type of the reference
            String code =
@"
            thisTest.RunScriptSource(code);
            Object r = new Object[] 
            ;
            thisTest.Verify("r", r);
        }

        [Test]
        public void TV1467147_PushThroughCastingWithReplication_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object r = new Object[] 
            ;
            thisTest.Verify("r", r);
        }

        [Test]
        public void TV1467147_PushThroughCastingWithReplication()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object r = new Object[] 
            ;
            thisTest.Verify("r", r);
        }

        [Test]
        [Category("Class")]
        public void T034_PushThroughCastingWithReplication_UserDefinedType()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] rs = new Object[] { 3, 3 };
            thisTest.Verify("r", rs);
        }

        [Test]
        public void T035_PushThroughIntWithReplication()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object r = new Object[] 
            ;
            thisTest.Verify("r", r);
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_0D()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", 7);
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_1D()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { 7 });
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_1D2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { 7, 7 });
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_2D()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { new object[] { 7 } });
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_2D2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { new object[] { 7 }, new object[] { 7 } });
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_3D()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { new object[] { new object[] { 7 } } });
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest_4D()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("va", new object[] { new object[] { new object[] { new object[] { 7 } } } });
        }


        [Test]
        public void T036_Replication_ArrayDimensionDispatch_SubTest()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("vc", new object[]
            thisTest.Verify("vd", new object[]
        }

        [Test]
        public void T036_Replication_ArrayDimensionDispatch()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("vz", 7);
            thisTest.Verify("va", new object[0]);
            thisTest.Verify("vb", new object[] { 7 });
            thisTest.Verify("vc", new object[]
            thisTest.Verify("vd", new object[]
        }

        [Test]
        public void T037_Replication_ArrayDimensionDispatch_Var()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("vz", 7);
            thisTest.Verify("va", new object[0]);
            thisTest.Verify("vb", new object[] { 7 });
            thisTest.Verify("vc", new object[]
            thisTest.Verify("vd", new object[]
        }

        [Test]
        public void Z001_ReplicationGuides_Minimal_01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] r = new object[] { 3, 3, 3 };
            thisTest.Verify("r", r);
        }

        [Test]
        public void Z002_ReplicationGuides_Minimal_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] r = new object[]
            thisTest.Verify("r", r);
        }

        [Test]
        public void Z003_ReplicationGuides_MultipleGuides_01_ExecAtAllCheck()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
        }


        [Test]
        [Category("Class")]
        public void T039_Inheritance_Method_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 10);
            thisTest.Verify("r2", 20);
        }

        [Test]
        public void TV1467063_Function_Overriding()
        {
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4054
            string err = "";
            String code =
@"
            thisTest.RunScriptSource(code, err);
            thisTest.SetErrorMessage("MAGN-4054: Function overriding: when using function overriding, wrong function is called");
            thisTest.Verify("r", 100);
        }

        [Test]
        public void T045_Inheritance_Method_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 200);
            thisTest.Verify("r2", 100);
        }

        [Test]
        public void TV1467175_1()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 1.0);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TV1467175_2()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 1.0);
        }

        [Test]
        public void TV1467175_3()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("ra", 100);
            thisTest.Verify("rb", 100);
        }


        [Test]
        public void FunctionOverload()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("r4", 11);
            thisTest.Verify("r7", 22);
        }


        [Test]
        public void T050_Inheritance_Multi_Constructor_01()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object v1 = null;
            thisTest.Verify("r1", 0);
            thisTest.Verify("r2", 1);
            thisTest.Verify("r3", 1);
            thisTest.Verify("r4", v1);
        }

        [Test]
        [Category("ToFixJun")]
        [Category("Failure")]
        [Category("Class")]
        public void T051_TransitiveInheritance_Constructor()
        {
            String code =
@"
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4050
            string err = "MAGN-4050 Transitive inheritance base constructor causes method resolution failure";
            thisTest.RunScriptSource(code, err);
            thisTest.Verify("r1", 0);
            thisTest.Verify("r2", 2);
            thisTest.Verify("r3", 3.0); // Actual result is 2 as C.C(1.0) instead of calling double overload of ctor A calls its int counterpart instead??
        }

        [Test]
        public void T050_Inheritance_Multi_Constructor_02()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            //Assert.Fail("1467179 - Sprint25 : rev 3152 : multiple inheritance base constructor causes method resolution");
            Object v1 = null;
            thisTest.Verify("r1", 0);
            thisTest.Verify("r2", 1);
            thisTest.Verify("r3", 3);
            thisTest.Verify("r4", v1);
        }

        [Test]
        public void T052_Defect_ReplicationMethodOverloading()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 2, 2, 2 };
            thisTest.Verify("r", v1);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        [Category("Method Resolution")]
        [Category("Failure")]
        public void T052_Defect_ReplicationMethodOverloading_2()
        {
            String code =
@"
import(""FFITarget.dll"");
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4052
            thisTest.RunScriptSource(code);
            Object[] v1 = new Object[] { 1, 2, 2, 3 };
            thisTest.Verify("r", v1);
        }

        [Test]
        [Category("Method Resolution")]
        [Category("Failure")]
        [Category("DSDefinedClass_Ported")]
        public void TV052_Defect_ReplicationMethodOverloading_01()
        {
            String code =
@"
import(""FFITarget.dll"");
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4052
            string err = "MAGN-4052 Replication and Method overload issue, resolving to wrong method";
            thisTest.RunScriptSource(code, err);
            Object[] v1 = new Object[] { 1, 2, 2, null };
            thisTest.Verify("r", v1);
        }

        [Test]
        [Category("Method Resolution")]
        [Category("Failure")]
        [Category("DSDefinedClass_Ported")]
        public void TV052_Defect_ReplicationMethodOverloading_03()
        {
            String code =
@"
import(""FFITarget.dll"");
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4052
            string err = "MAGN-4052 Replication and Method overload issue, resolving to wrong method";
            thisTest.RunScriptSource(code, err);
            Object[] v1 = new Object[] { 1, 2, 2, null };
            thisTest.Verify("r", v1);
        }

        [Test]
        [Category("Method Resolution")]
        [Category("Failure")]
        [Category("DSDefinedClass_Ported")]
        public void TV052_Defect_ReplicationMethodOverloading_InUserDefinedClass()
        {
            String code =
@"
            // Tracked by: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4052
            string err = "MAGN-4052 Replication and Method overload issue, resolving to wrong method";
            thisTest.RunScriptSource(code, err);
            Object[] v1 = new Object[] { 1, 2, 2, null };
            thisTest.Verify("r", v1);
        }


        [Test]
        public void ReplicationSubDispatch()
        {
            String code =
@"
            thisTest.RunScriptSource(code);

            thisTest.Verify("ret", new object[] { 1, 2, 1, 2 });
        }

        [Test]
        public void Test()
        {
            String code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void T056_nonmatchingclass_1467162()
        {
            String code =
            @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            TestFrameWork.VerifyRuntimeWarning(ProtoCore.Runtime.WarningID.ConversionNotPossible);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void T057_nonmatchingclass_1467162_2()
        {
            String code =
            @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            TestFrameWork.VerifyRuntimeWarning(ProtoCore.Runtime.WarningID.ConversionNotPossible);
        }

        [Test]
        public void RepoTests_MAGN3177()
        {
            String code =
                @"
            thisTest.RunScriptSource(code);
            //thisTest.Verify("d", 1);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestMethodResolution01()
        {
            string code = @"

import(""FFITarget.dll"");

    def foo()
    {
        return = 41;
    }

    def foo(x : DummyPoint)
    {
        return = 42;
    }

    def foo(x : DummyPoint, y: DummyPoint)
    {
        return = 43;
    }

    def foo(x : DummyPoint, y: DummyPoint, z:DummyPoint)
    {
        return = 44;
    }


r1 = foo();
r2 = foo(a);
r3 = foo(a,a);
r4 = foo(a,a,a);
";

            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 41);
            thisTest.Verify("r2", 42);
            thisTest.Verify("r3", 43);
            thisTest.Verify("r4", 44);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestMethodResolution02()
        {
            string code = @"

import(""FFITarget.dll"");

def foo(x: int)
{
    return = 41;
}

def foo(x : DummyPoint, y: int)
{
    return = 42;
}

r1 = foo(1);
r2 = foo(a, 1);
";

            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", 41);
            thisTest.Verify("r2", 42);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestMethodResolution03()
        {
            string code = @"
import(""FFITarget.dll"");

def foo(x: int)
{
    return = 41;
}

def foo(x : DummyPoint, y: int)
{
    return = 42;
}

r1 = foo([1]);
r2 = foo(a, [1]);
";

            thisTest.RunScriptSource(code);
            thisTest.Verify("r1", new object[] {41});
            thisTest.Verify("r2", new object[] {42});
        }

        [Test]
        public void TestMethodResolutionOnHeterogeneousArray01()
        {
            string code = @"
def foo(x : int)
{
    return = x;
}

r = foo([""foo"", ""bar"", 33.9]);
";
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", new object[] { null, null, 34 });
        }

        [Test]
        public void TestMethodResolutionOnHeterogeneousArray02()
        {
            string code = @"
def foo(x: int, y : string)
{
    return = x;
}

xs = [""foo"", 10, ""bar""];
ys = [ 12, ""ding"", ""dang""];
r = foo(xs, ys);
";
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", new object[] { null, 10, null});
        }

        [Test]
        public void TestMethodResolutionOnHeterogeneousArray03()
        {
            string code = @"
def foo(x: int, y : string)
{
    return = x;
}

xs = [""foo"", 10, ""bar""];
ys = [ 12, ""ding"", ""dang""];
r = foo(xs<1>, ys<1>);
";
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", new object[] { null, 10, null });
        }

        [Test]
        public void NonStaticPropertyLookupOnClassName_DoesNotCrash()
        {
            var code = @"
import(""FFITarget.dll"");

a = DummyPoint.X;
d = DummyPoint.ByCoordinates(89,0,0);
b = a(d);
";
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", 89);
        }
        
        [Test]
        public void StaticMethodPropertyLookupsOnClassName()
        {
            var code = @"
import(""FFITarget.dll"");

a = ClassFunctionality.get_StaticProperty;

c = ClassFunctionality.ClassFunctionality(78);
b = ClassFunctionality.get_Property;
d = b(c);

e = ClassFunctionality.get_StaticMethod();

f = ClassFunctionality.get_StaticMethod;
g = f();

h = ClassFunctionality.get_Method;
i = h(c);

j = ClassFunctionality.get_Method(c);

m = ClassFunctionality.IntVal;
k = m(c);

l = ValueContainer.SomeStaticProperty;
";
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 99);
            thisTest.Verify("d", 78);
            thisTest.Verify("e", 99);
            thisTest.Verify("g", 99);
            thisTest.Verify("i", 78);
            thisTest.Verify("j", 78);
            thisTest.Verify("k", 78);
            thisTest.Verify("l", 123);
        }
    }
}
