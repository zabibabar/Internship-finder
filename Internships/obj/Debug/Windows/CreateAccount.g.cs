﻿#pragma checksum "..\..\..\Windows\CreateAccount.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D3586AC48710AAE7E8DA437E624BE4EDBE44841"
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
    /// CreateAccount
    /// </summary>
    public partial class CreateAccount : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserCreatedEmail;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserCreatedLogin;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox UserCreatedPassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Status;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Intern;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Employer;
        
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
            System.Uri resourceLocater = new System.Uri("/Internships;component/windows/createaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\CreateAccount.xaml"
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
            this.UserCreatedEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Windows\CreateAccount.xaml"
            this.UserCreatedEmail.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserCreatedLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\Windows\CreateAccount.xaml"
            this.UserCreatedLogin.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserCreatedPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 32 "..\..\..\Windows\CreateAccount.xaml"
            this.UserCreatedPassword.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Status = ((System.Windows.Controls.StackPanel)(target));
            
            #line 36 "..\..\..\Windows\CreateAccount.xaml"
            this.Status.GotFocus += new System.Windows.RoutedEventHandler(this.TextFieldChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Intern = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.Employer = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

