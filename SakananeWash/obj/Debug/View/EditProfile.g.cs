﻿#pragma checksum "..\..\..\View\EditProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31476DED52395BF51553E9F65499090151C15D1CCBA6A03D28A4F316EA80B7B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SakananeWash.View;
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


namespace SakananeWash.View {
    
    
    /// <summary>
    /// EditProfile
    /// </summary>
    public partial class EditProfile : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHp;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHistory;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProgress;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChat;
        
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
            System.Uri resourceLocater = new System.Uri("/SakananeWash;component/view/editprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\EditProfile.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtHp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\EditProfile.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\View\EditProfile.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\EditProfile.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnHistory = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\View\EditProfile.xaml"
            this.btnHistory.Click += new System.Windows.RoutedEventHandler(this.btnHistory_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnProgress = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\View\EditProfile.xaml"
            this.btnProgress.Click += new System.Windows.RoutedEventHandler(this.btnProgress_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnChat = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\EditProfile.xaml"
            this.btnChat.Click += new System.Windows.RoutedEventHandler(this.btnChat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
