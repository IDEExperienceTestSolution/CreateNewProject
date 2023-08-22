using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

using FluentAssertions;

using Microsoft.Test.Apex;
using Microsoft.Test.Apex.Services.StringGeneration;
using Microsoft.Test.Apex.VisualStudio;
using Microsoft.Test.Apex.VisualStudio.Shell;
using Microsoft.Test.Apex.VisualStudio.Solution;
using Microsoft.VisualStudio.PlatformUI.Apex.NewProjectDialog;
using Microsoft.VisualStudio.TemplateProviders.Templates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omni.Common.Extensions;


namespace TestNameSpace
{
    [TestClass]
    public class TestCreateNewProject: VisualStudioHostTest
    {
        //private NewProjectDialogTestService newProjectDialogTestService;

        //private List<string> foldersToCleanUp = new List<string>();
        //private readonly VsSafeFileNameStringGenerator stringGenerator = new VsSafeFileNameStringGenerator() { MinLength = 3, MaxLength = 10 };
        ////private const string ConsoleAppTemplateId = "Microsoft.CSharp.ConsoleApplication";
        //private const string WPFTemplateId = "Microsoft.VisualBasic.Windows.WpfApplication";
        ////private const string AzureFunctionTemplateId = "Microsoft.AzureFunctions.ProjectTemplate.CSharp";
        //private static TimeSpan defaultOpenSolutionTimeout = TimeSpan.FromSeconds(2);

        //[TestInitialize]
        //public override void TestInitialize()
        //{
        //    base.TestInitialize();
        //    this.newProjectDialogTestService = this.GetAndCheckService<NewProjectDialogTestService>();
        //}

        [TestMethod]
        [Timeout(5 * 60 * 1000)]
        [Owner("IDE Experience")]
        public void CreateNewProjectFromNewProjectDialog()
        {
            var a = this.VisualStudio.ObjectModel.Solution;
            a.CreateEmptySolution();
            var b = a.CreateDefaultProject();

            //string projectLocation = Environment.ExpandEnvironmentVariables($@"%USERPROFILE%\Source\Repos\{stringGenerator.Generate()}");
            //string solutionName = stringGenerator.Generate();
            //string projectName = stringGenerator.Generate();

            //NewProjectDialogTestExtension newProjectDialogTestExtension = this.newProjectDialogTestService.GetExtension();
            //CreateProjectDialogTestExtension createProjectDialogTestExtension = newProjectDialogTestExtension.InvokeNewProjectDialog();
            //createProjectDialogTestExtension.Verify.ProjectCreationDialogVisibilityIs(true).Should().BeTrue();

            //string templateId = WPFTemplateId;

            //if (!createProjectDialogTestExtension.TrySelectTemplateWithId(templateId))
            //    return;

            //ConfigProjectDialogTestExtension configTestExtension = createProjectDialogTestExtension.NavigateToConfigProjectPage();
            //configTestExtension.Verify.ProjectConfigurationDialogVisibilityIs(true).Should().BeTrue();

            //// Assign valid SolutionName
            //configTestExtension.SolutionName = "AzureTest";     

            //// Assign valid Location
            //configTestExtension.Location = projectLocation;

            //configTestExtension.Verify.CanFinishConfigurationEquals(true).Should().BeTrue();

            //this.foldersToCleanUp.Add(projectLocation);

            //configTestExtension.FinishConfiguration();

            //this.VerifySolutionIsLoaded(Path.Combine(projectLocation, solutionName, solutionName + ".sln"));
        }

        private T GetAndCheckService<T>() where T : class
        {
            var testService = this.VisualStudio.Get<T>();
            this.ThrowIfNull(testService, $"{typeof(T).Name} not found.");
            return testService;
        }

        private void ThrowIfNull(object obj, string message)
        {
            obj.Should().NotBeNull(because: message);
        }

        //private void VerifySolutionOpened(TimeSpan verifyAfterInSec)
        //{
        //    Thread.Sleep(verifyAfterInSec);
        //    this.VisualStudio.ObjectModel.Solution.IsOpen.Should().BeTrue(because: $"solution should be opened in {verifyAfterInSec} seconds");
        //}

        //private void VerifySolutionIsLoaded(string solutionFilePath)
        //{
        //    // Ensure the solution is opened before verify fully loaded
        //    this.VerifySolutionOpened(defaultOpenSolutionTimeout);

        //    this.VisualStudio.ObjectModel.Solution.WaitForFullyLoaded(singleProjectLoadTimeout: TimeSpan.FromSeconds(10));
        //    this.VisualStudio.ObjectModel.Solution.FilePath.Should().Be(solutionFilePath);
        //}
    }
}
