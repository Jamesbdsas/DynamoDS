using System;using NUnit.Framework;namespace ProtoTest.MultiLangTests{    [TestFixture]    class AssociativeToImperative : ProtoTestBase    {        [Test]        public void EmbeddedTest001()        {            String code =@"x;[Associative]{	x = 0;    [Imperative]    {        x = x + 5;    }}";            thisTest.RunScriptSource(code);            thisTest.Verify("x", 0);        }    }}