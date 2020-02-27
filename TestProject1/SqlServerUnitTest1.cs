using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnGetPunoletneOsobeTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnPrvoSlovoVelikoTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSamoGodinaRodjenjaTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_delOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_selOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnMaxVisinaTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSrednjaStarostTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_delOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_selOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnMaxVisinaTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSrednjaStarostTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            this.dbo_fnGetPunoletneOsobeTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnPrvoSlovoVelikoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnSamoGodinaRodjenjaTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_delOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_insOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_selOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnMaxVisinaTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnSrednjaStarostTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_fnGetPunoletneOsobeTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnPrvoSlovoVelikoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnSamoGodinaRodjenjaTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_delOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_insOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_selOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_updOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnMaxVisinaTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnSrednjaStarostTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_insOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_updOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_delOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_selOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnMaxVisinaTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnSrednjaStarostTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_fnGetPunoletneOsobeTest_TestAction
            // 
            dbo_fnGetPunoletneOsobeTest_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(dbo_fnGetPunoletneOsobeTest_TestAction, "dbo_fnGetPunoletneOsobeTest_TestAction");
            // 
            // dbo_fnPrvoSlovoVelikoTest_TestAction
            // 
            dbo_fnPrvoSlovoVelikoTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_fnPrvoSlovoVelikoTest_TestAction, "dbo_fnPrvoSlovoVelikoTest_TestAction");
            // 
            // dbo_fnSamoGodinaRodjenjaTest_TestAction
            // 
            dbo_fnSamoGodinaRodjenjaTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_fnSamoGodinaRodjenjaTest_TestAction, "dbo_fnSamoGodinaRodjenjaTest_TestAction");
            // 
            // dbo_delOSOBATest_TestAction
            // 
            dbo_delOSOBATest_TestAction.Conditions.Add(rowCountCondition4);
            resources.ApplyResources(dbo_delOSOBATest_TestAction, "dbo_delOSOBATest_TestAction");
            // 
            // dbo_insOSOBATest_TestAction
            // 
            dbo_insOSOBATest_TestAction.Conditions.Add(rowCountCondition3);
            resources.ApplyResources(dbo_insOSOBATest_TestAction, "dbo_insOSOBATest_TestAction");
            // 
            // dbo_selOSOBATest_TestAction
            // 
            dbo_selOSOBATest_TestAction.Conditions.Add(rowCountCondition5);
            resources.ApplyResources(dbo_selOSOBATest_TestAction, "dbo_selOSOBATest_TestAction");
            // 
            // dbo_updOSOBATest_TestAction
            // 
            dbo_updOSOBATest_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(dbo_updOSOBATest_TestAction, "dbo_updOSOBATest_TestAction");
            // 
            // dbo_fnMaxVisinaTest_TestAction
            // 
            dbo_fnMaxVisinaTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_fnMaxVisinaTest_TestAction.Conditions.Add(scalarValueCondition5);
            resources.ApplyResources(dbo_fnMaxVisinaTest_TestAction, "dbo_fnMaxVisinaTest_TestAction");
            // 
            // dbo_fnSrednjaStarostTest_TestAction
            // 
            dbo_fnSrednjaStarostTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_fnSrednjaStarostTest_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(dbo_fnSrednjaStarostTest_TestAction, "dbo_fnSrednjaStarostTest_TestAction");
            // 
            // dbo_fnGetPunoletneOsobeTestData
            // 
            this.dbo_fnGetPunoletneOsobeTestData.PosttestAction = null;
            this.dbo_fnGetPunoletneOsobeTestData.PretestAction = null;
            this.dbo_fnGetPunoletneOsobeTestData.TestAction = dbo_fnGetPunoletneOsobeTest_TestAction;
            // 
            // dbo_fnPrvoSlovoVelikoTestData
            // 
            this.dbo_fnPrvoSlovoVelikoTestData.PosttestAction = null;
            this.dbo_fnPrvoSlovoVelikoTestData.PretestAction = null;
            this.dbo_fnPrvoSlovoVelikoTestData.TestAction = dbo_fnPrvoSlovoVelikoTest_TestAction;
            // 
            // dbo_fnSamoGodinaRodjenjaTestData
            // 
            this.dbo_fnSamoGodinaRodjenjaTestData.PosttestAction = null;
            this.dbo_fnSamoGodinaRodjenjaTestData.PretestAction = null;
            this.dbo_fnSamoGodinaRodjenjaTestData.TestAction = dbo_fnSamoGodinaRodjenjaTest_TestAction;
            // 
            // dbo_delOSOBATestData
            // 
            this.dbo_delOSOBATestData.PosttestAction = null;
            this.dbo_delOSOBATestData.PretestAction = dbo_delOSOBATest_PretestAction;
            this.dbo_delOSOBATestData.TestAction = dbo_delOSOBATest_TestAction;
            // 
            // dbo_insOSOBATestData
            // 
            this.dbo_insOSOBATestData.PosttestAction = null;
            this.dbo_insOSOBATestData.PretestAction = dbo_insOSOBATest_PretestAction;
            this.dbo_insOSOBATestData.TestAction = dbo_insOSOBATest_TestAction;
            // 
            // dbo_selOSOBATestData
            // 
            this.dbo_selOSOBATestData.PosttestAction = null;
            this.dbo_selOSOBATestData.PretestAction = dbo_selOSOBATest_PretestAction;
            this.dbo_selOSOBATestData.TestAction = dbo_selOSOBATest_TestAction;
            // 
            // dbo_updOSOBATestData
            // 
            this.dbo_updOSOBATestData.PosttestAction = null;
            this.dbo_updOSOBATestData.PretestAction = dbo_updOSOBATest_PretestAction;
            this.dbo_updOSOBATestData.TestAction = dbo_updOSOBATest_TestAction;
            // 
            // dbo_fnMaxVisinaTestData
            // 
            this.dbo_fnMaxVisinaTestData.PosttestAction = null;
            this.dbo_fnMaxVisinaTestData.PretestAction = dbo_fnMaxVisinaTest_PretestAction;
            this.dbo_fnMaxVisinaTestData.TestAction = dbo_fnMaxVisinaTest_TestAction;
            // 
            // dbo_fnSrednjaStarostTestData
            // 
            this.dbo_fnSrednjaStarostTestData.PosttestAction = null;
            this.dbo_fnSrednjaStarostTestData.PretestAction = dbo_fnSrednjaStarostTest_PretestAction;
            this.dbo_fnSrednjaStarostTestData.TestAction = dbo_fnSrednjaStarostTest_TestAction;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "44";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "Pera";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // dbo_insOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_insOSOBATest_PretestAction, "dbo_insOSOBATest_PretestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 1;
            // 
            // dbo_updOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_updOSOBATest_PretestAction, "dbo_updOSOBATest_PretestAction");
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "Rudarska 130";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // dbo_delOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_delOSOBATest_PretestAction, "dbo_delOSOBATest_PretestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 1;
            // 
            // dbo_selOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_selOSOBATest_PretestAction, "dbo_selOSOBATest_PretestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 1;
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "True";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // dbo_fnMaxVisinaTest_PretestAction
            // 
            resources.ApplyResources(dbo_fnMaxVisinaTest_PretestAction, "dbo_fnMaxVisinaTest_PretestAction");
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "176";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // dbo_fnSrednjaStarostTest_PretestAction
            // 
            resources.ApplyResources(dbo_fnSrednjaStarostTest_PretestAction, "dbo_fnSrednjaStarostTest_PretestAction");
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "44";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_fnGetPunoletneOsobeTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnGetPunoletneOsobeTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_fnPrvoSlovoVelikoTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnPrvoSlovoVelikoTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_fnSamoGodinaRodjenjaTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnSamoGodinaRodjenjaTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_delOSOBATest()
        {
            SqlDatabaseTestActions testActions = this.dbo_delOSOBATestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_insOSOBATest()
        {
            SqlDatabaseTestActions testActions = this.dbo_insOSOBATestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_selOSOBATest()
        {
            SqlDatabaseTestActions testActions = this.dbo_selOSOBATestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updOSOBATest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updOSOBATestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_fnMaxVisinaTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnMaxVisinaTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_fnSrednjaStarostTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnSrednjaStarostTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_fnGetPunoletneOsobeTestData;
        private SqlDatabaseTestActions dbo_fnPrvoSlovoVelikoTestData;
        private SqlDatabaseTestActions dbo_fnSamoGodinaRodjenjaTestData;
        private SqlDatabaseTestActions dbo_delOSOBATestData;
        private SqlDatabaseTestActions dbo_insOSOBATestData;
        private SqlDatabaseTestActions dbo_selOSOBATestData;
        private SqlDatabaseTestActions dbo_updOSOBATestData;
        private SqlDatabaseTestActions dbo_fnMaxVisinaTestData;
        private SqlDatabaseTestActions dbo_fnSrednjaStarostTestData;
    }
}
