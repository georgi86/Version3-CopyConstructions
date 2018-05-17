﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Copy_Functionality
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Action_StepByStep recording.
    /// </summary>
    [TestModule("09b84e11-7baf-4a6d-9627-ecea84549b56", ModuleType.Recording, 1)]
    public partial class Action_StepByStep : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Copy_FunctionalityRepository repository.
        /// </summary>
        public static Copy_FunctionalityRepository repo = Copy_FunctionalityRepository.Instance;

        static Action_StepByStep instance = new Action_StepByStep();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Action_StepByStep()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Action_StepByStep Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            string strBigModeCaptionText = "Measure";

            bool bBigMode = true;

            try
            {
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TextMeasure' at Center.", repo.SnapXUntitled.TextMeasureInfo, new RecordItemIndex(0));
                repo.SnapXUntitled.TextMeasure.MoveTo();
                Delay.Milliseconds(200);

                bBigMode = repo.SnapXUntitled.TextMeasure.TextValue.CompareTo(strBigModeCaptionText) == 0 && repo.SnapXUntitled.TextMeasure.Visible;
            }

            catch (Exception ex)
            {
            }

            if (!bBigMode)

                repo.SnapXUntitled.SwitchToSensor.Click();
                Delay.Milliseconds(500);
            
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(2));
            repo.SnapXUntitled.TitleBar.Click();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(3));
            Keyboard.Press("o");

            Thread.Sleep(3000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationCopy\\Routine\\Copy.mxy'.", new RecordItemIndex(5));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationCopy\\Routine\\Copy.mxy");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("{Return}");
            Thread.Sleep(2000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(8));
            repo.SnapXUntitled.TitleBar.Click();
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(9));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(10));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(11));
            Keyboard.Press("r");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(12));
            Keyboard.Press("{Return}");
            Thread.Sleep(1000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXCopyMxy.Finish' at Center.", repo.SnapXCopyMxy.FinishInfo, new RecordItemIndex(13));
            repo.SnapXCopyMxy.Finish.Click();
            Thread.Sleep(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(14));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(15));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(16));
            Keyboard.Press("n");
            Thread.Sleep(500);

            ////// Inspect the Result /////////


            string strCopyValues = "D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationCopy\\Reports\\ActualValues.STA";
            string strHardcodedValue = "D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationCopy\\Reports\\HardcodedValues.STA";

            UtilityRun.RunCopy(strCopyValues, strHardcodedValue);
            Thread.Sleep(1000);

        }

        #region Image Feature Data
        #endregion
    }
#pragma warning restore 0436
}
