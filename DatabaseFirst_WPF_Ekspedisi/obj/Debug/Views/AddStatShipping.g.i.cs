﻿#pragma checksum "..\..\..\Views\AddStatShipping.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2010E52CBE220BF5C87211753297384037DBFB23"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseFirst_WPF_Ekspedisi.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace DatabaseFirst_WPF_Ekspedisi.Views {
    
    
    /// <summary>
    /// AddStatShipping
    /// </summary>
    public partial class AddStatShipping : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\AddStatShipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addnameboxSS;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AddStatShipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy11;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\AddStatShipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\AddStatShipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveSS;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\AddStatShipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelSS;
        
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
            System.Uri resourceLocater = new System.Uri("/DatabaseFirst_WPF_Ekspedisi;component/views/addstatshipping.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddStatShipping.xaml"
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
            this.addnameboxSS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.label1_Copy11 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.label1_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.saveSS = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\AddStatShipping.xaml"
            this.saveSS.Click += new System.Windows.RoutedEventHandler(this.saveSS_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelSS = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\AddStatShipping.xaml"
            this.cancelSS.Click += new System.Windows.RoutedEventHandler(this.cancelSS_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

