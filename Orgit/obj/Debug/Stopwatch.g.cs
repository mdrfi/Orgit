﻿#pragma checksum "..\..\Stopwatch.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89A02F3ECAD92E07C471476AD53EB56291E7D299"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Orgit;
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


namespace Orgit {
    
    
    /// <summary>
    /// Stopwatch
    /// </summary>
    public partial class Stopwatch : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mslbl;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startbtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image startimg;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetbtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label hhlbl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mmlbl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sslbl;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dot;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dot_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Orgit;component/stopwatch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Stopwatch.xaml"
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
            this.mslbl = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.startbtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Stopwatch.xaml"
            this.startbtn.Click += new System.Windows.RoutedEventHandler(this.startbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.startimg = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.resetbtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Stopwatch.xaml"
            this.resetbtn.Click += new System.Windows.RoutedEventHandler(this.resetbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hhlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.mmlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.sslbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.dot = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.dot_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

