﻿#pragma checksum "..\..\..\Windows\EmployerInformationxaml.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6E0C31D2108EFC3FBEE59A9EE12BD2335284EF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Internships;
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


namespace Internships {
    
    
    /// <summary>
    /// EmployerInformationxaml
    /// </summary>
    public partial class EmployerInformationxaml : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows\EmployerInformationxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\EmployerInformationxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserCompany;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\EmployerInformationxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAddress;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\EmployerInformationxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserPhone;
        
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
            System.Uri resourceLocater = new System.Uri("/Internships;component/windows/employerinformationxaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EmployerInformationxaml.xaml"
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
            this.UserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Windows\EmployerInformationxaml.xaml"
            this.UserName.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserCompany = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\Windows\EmployerInformationxaml.xaml"
            this.UserCompany.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserAddress = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Windows\EmployerInformationxaml.xaml"
            this.UserAddress.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UserPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Windows\EmployerInformationxaml.xaml"
            this.UserPhone.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

