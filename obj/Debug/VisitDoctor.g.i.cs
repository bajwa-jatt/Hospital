﻿#pragma checksum "..\..\VisitDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA862E6449A1D01A3AADA9972C410DEA8F418FACAF72FC39C78534DF2EBFA982"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FINAL_PROJECT_14_06;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FINAL_PROJECT_14_06 {
    
    
    /// <summary>
    /// VisitDoctor
    /// </summary>
    public partial class VisitDoctor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ShowPatient;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ShowDoctor;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MedicineCombo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RefillCount;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refillInfo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RequestPrescriptionBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\VisitDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompleteAppoinmentBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FINAL_PROJECT_14_06;component/visitdoctor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VisitDoctor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ShowPatient = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ShowDoctor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.MedicineCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.RefillCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.refillInfo = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\VisitDoctor.xaml"
            this.refillInfo.Click += new System.Windows.RoutedEventHandler(this.refillInfo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RequestPrescriptionBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\VisitDoctor.xaml"
            this.RequestPrescriptionBtn.Click += new System.Windows.RoutedEventHandler(this.RequestPrescriptionBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CompleteAppoinmentBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\VisitDoctor.xaml"
            this.CompleteAppoinmentBtn.Click += new System.Windows.RoutedEventHandler(this.CompleteAppoinmentBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
