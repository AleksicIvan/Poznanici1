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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnPrvoSlovoVelikoTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnStarostTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_delOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_selOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updOSOBATest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnMaxVisinaTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSrednjaStarostTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_delOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_selOSOBATest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnMaxVisinaTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSrednjaStarostTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_delOSOBATest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnGetPunoletneOsobeTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnMaxVisinaTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnPrvoSlovoVelikoTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnSrednjaStarostTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fnStarostTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insOSOBATest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_selOSOBATest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updOSOBATest_PosttestAction;
            this.dbo_fnGetPunoletneOsobeTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnPrvoSlovoVelikoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnStarostTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_delOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_insOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_selOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updOSOBATestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnMaxVisinaTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fnSrednjaStarostTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_fnGetPunoletneOsobeTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnPrvoSlovoVelikoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnStarostTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_delOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_insOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_selOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_updOSOBATest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnMaxVisinaTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_fnSrednjaStarostTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_insOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_updOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_delOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_selOSOBATest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnMaxVisinaTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnSrednjaStarostTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_delOSOBATest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnGetPunoletneOsobeTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnMaxVisinaTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnPrvoSlovoVelikoTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnSrednjaStarostTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_fnStarostTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_insOSOBATest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_selOSOBATest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_updOSOBATest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_fnGetPunoletneOsobeTest_TestAction
            // 
            dbo_fnGetPunoletneOsobeTest_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(dbo_fnGetPunoletneOsobeTest_TestAction, "dbo_fnGetPunoletneOsobeTest_TestAction");
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
            // dbo_fnPrvoSlovoVelikoTest_TestAction
            // 
            dbo_fnPrvoSlovoVelikoTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_fnPrvoSlovoVelikoTest_TestAction, "dbo_fnPrvoSlovoVelikoTest_TestAction");
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
            // dbo_fnStarostTest_TestAction
            // 
            dbo_fnStarostTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_fnStarostTest_TestAction, "dbo_fnStarostTest_TestAction");
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
            // dbo_delOSOBATest_TestAction
            // 
            dbo_delOSOBATest_TestAction.Conditions.Add(rowCountCondition4);
            resources.ApplyResources(dbo_delOSOBATest_TestAction, "dbo_delOSOBATest_TestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 1;
            // 
            // dbo_insOSOBATest_TestAction
            // 
            dbo_insOSOBATest_TestAction.Conditions.Add(rowCountCondition3);
            resources.ApplyResources(dbo_insOSOBATest_TestAction, "dbo_insOSOBATest_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 1;
            // 
            // dbo_selOSOBATest_TestAction
            // 
            dbo_selOSOBATest_TestAction.Conditions.Add(rowCountCondition5);
            resources.ApplyResources(dbo_selOSOBATest_TestAction, "dbo_selOSOBATest_TestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 1;
            // 
            // dbo_updOSOBATest_TestAction
            // 
            dbo_updOSOBATest_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(dbo_updOSOBATest_TestAction, "dbo_updOSOBATest_TestAction");
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
            // dbo_fnMaxVisinaTest_TestAction
            // 
            dbo_fnMaxVisinaTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_fnMaxVisinaTest_TestAction.Conditions.Add(scalarValueCondition5);
            resources.ApplyResources(dbo_fnMaxVisinaTest_TestAction, "dbo_fnMaxVisinaTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "200";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // dbo_fnSrednjaStarostTest_TestAction
            // 
            dbo_fnSrednjaStarostTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_fnSrednjaStarostTest_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(dbo_fnSrednjaStarostTest_TestAction, "dbo_fnSrednjaStarostTest_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "39";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // dbo_insOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_insOSOBATest_PretestAction, "dbo_insOSOBATest_PretestAction");
            // 
            // dbo_updOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_updOSOBATest_PretestAction, "dbo_updOSOBATest_PretestAction");
            // 
            // dbo_delOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_delOSOBATest_PretestAction, "dbo_delOSOBATest_PretestAction");
            // 
            // dbo_selOSOBATest_PretestAction
            // 
            resources.ApplyResources(dbo_selOSOBATest_PretestAction, "dbo_selOSOBATest_PretestAction");
            // 
            // dbo_fnMaxVisinaTest_PretestAction
            // 
            resources.ApplyResources(dbo_fnMaxVisinaTest_PretestAction, "dbo_fnMaxVisinaTest_PretestAction");
            // 
            // dbo_fnSrednjaStarostTest_PretestAction
            // 
            resources.ApplyResources(dbo_fnSrednjaStarostTest_PretestAction, "dbo_fnSrednjaStarostTest_PretestAction");
            // 
            // dbo_delOSOBATest_PosttestAction
            // 
            resources.ApplyResources(dbo_delOSOBATest_PosttestAction, "dbo_delOSOBATest_PosttestAction");
            // 
            // dbo_fnGetPunoletneOsobeTest_PosttestAction
            // 
            resources.ApplyResources(dbo_fnGetPunoletneOsobeTest_PosttestAction, "dbo_fnGetPunoletneOsobeTest_PosttestAction");
            // 
            // dbo_fnMaxVisinaTest_PosttestAction
            // 
            resources.ApplyResources(dbo_fnMaxVisinaTest_PosttestAction, "dbo_fnMaxVisinaTest_PosttestAction");
            // 
            // dbo_fnPrvoSlovoVelikoTest_PosttestAction
            // 
            resources.ApplyResources(dbo_fnPrvoSlovoVelikoTest_PosttestAction, "dbo_fnPrvoSlovoVelikoTest_PosttestAction");
            // 
            // dbo_fnSrednjaStarostTest_PosttestAction
            // 
            resources.ApplyResources(dbo_fnSrednjaStarostTest_PosttestAction, "dbo_fnSrednjaStarostTest_PosttestAction");
            // 
            // dbo_fnStarostTest_PosttestAction
            // 
            resources.ApplyResources(dbo_fnStarostTest_PosttestAction, "dbo_fnStarostTest_PosttestAction");
            // 
            // dbo_insOSOBATest_PosttestAction
            // 
            resources.ApplyResources(dbo_insOSOBATest_PosttestAction, "dbo_insOSOBATest_PosttestAction");
            // 
            // dbo_selOSOBATest_PosttestAction
            // 
            resources.ApplyResources(dbo_selOSOBATest_PosttestAction, "dbo_selOSOBATest_PosttestAction");
            // 
            // dbo_updOSOBATest_PosttestAction
            // 
            resources.ApplyResources(dbo_updOSOBATest_PosttestAction, "dbo_updOSOBATest_PosttestAction");
            // 
            // dbo_fnGetPunoletneOsobeTestData
            // 
            this.dbo_fnGetPunoletneOsobeTestData.PosttestAction = dbo_fnGetPunoletneOsobeTest_PosttestAction;
            this.dbo_fnGetPunoletneOsobeTestData.PretestAction = null;
            this.dbo_fnGetPunoletneOsobeTestData.TestAction = dbo_fnGetPunoletneOsobeTest_TestAction;
            // 
            // dbo_fnPrvoSlovoVelikoTestData
            // 
            this.dbo_fnPrvoSlovoVelikoTestData.PosttestAction = dbo_fnPrvoSlovoVelikoTest_PosttestAction;
            this.dbo_fnPrvoSlovoVelikoTestData.PretestAction = null;
            this.dbo_fnPrvoSlovoVelikoTestData.TestAction = dbo_fnPrvoSlovoVelikoTest_TestAction;
            // 
            // dbo_fnStarostTestData
            // 
            this.dbo_fnStarostTestData.PosttestAction = dbo_fnStarostTest_PosttestAction;
            this.dbo_fnStarostTestData.PretestAction = null;
            this.dbo_fnStarostTestData.TestAction = dbo_fnStarostTest_TestAction;
            // 
            // dbo_delOSOBATestData
            // 
            this.dbo_delOSOBATestData.PosttestAction = dbo_delOSOBATest_PosttestAction;
            this.dbo_delOSOBATestData.PretestAction = dbo_delOSOBATest_PretestAction;
            this.dbo_delOSOBATestData.TestAction = dbo_delOSOBATest_TestAction;
            // 
            // dbo_insOSOBATestData
            // 
            this.dbo_insOSOBATestData.PosttestAction = dbo_insOSOBATest_PosttestAction;
            this.dbo_insOSOBATestData.PretestAction = dbo_insOSOBATest_PretestAction;
            this.dbo_insOSOBATestData.TestAction = dbo_insOSOBATest_TestAction;
            // 
            // dbo_selOSOBATestData
            // 
            this.dbo_selOSOBATestData.PosttestAction = dbo_selOSOBATest_PosttestAction;
            this.dbo_selOSOBATestData.PretestAction = dbo_selOSOBATest_PretestAction;
            this.dbo_selOSOBATestData.TestAction = dbo_selOSOBATest_TestAction;
            // 
            // dbo_updOSOBATestData
            // 
            this.dbo_updOSOBATestData.PosttestAction = dbo_updOSOBATest_PosttestAction;
            this.dbo_updOSOBATestData.PretestAction = dbo_updOSOBATest_PretestAction;
            this.dbo_updOSOBATestData.TestAction = dbo_updOSOBATest_TestAction;
            // 
            // dbo_fnMaxVisinaTestData
            // 
            this.dbo_fnMaxVisinaTestData.PosttestAction = dbo_fnMaxVisinaTest_PosttestAction;
            this.dbo_fnMaxVisinaTestData.PretestAction = dbo_fnMaxVisinaTest_PretestAction;
            this.dbo_fnMaxVisinaTestData.TestAction = dbo_fnMaxVisinaTest_TestAction;
            // 
            // dbo_fnSrednjaStarostTestData
            // 
            this.dbo_fnSrednjaStarostTestData.PosttestAction = dbo_fnSrednjaStarostTest_PosttestAction;
            this.dbo_fnSrednjaStarostTestData.PretestAction = dbo_fnSrednjaStarostTest_PretestAction;
            this.dbo_fnSrednjaStarostTestData.TestAction = dbo_fnSrednjaStarostTest_TestAction;
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
        [TestMethod()]
        public void dbo_fnStarostTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fnStarostTestData;
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
        private SqlDatabaseTestActions dbo_fnStarostTestData;
        private SqlDatabaseTestActions dbo_delOSOBATestData;
        private SqlDatabaseTestActions dbo_insOSOBATestData;
        private SqlDatabaseTestActions dbo_selOSOBATestData;
        private SqlDatabaseTestActions dbo_updOSOBATestData;
        private SqlDatabaseTestActions dbo_fnMaxVisinaTestData;
        private SqlDatabaseTestActions dbo_fnSrednjaStarostTestData;
    }
}
