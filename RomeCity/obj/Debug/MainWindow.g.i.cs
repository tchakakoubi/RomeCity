﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00166FCEC85FF1B8CEE87CE41AD5FC0E06450F49"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RomeCity;
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


namespace RomeCity {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarratitulo;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOfLogout;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOfCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOfOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid home;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid zimmer;
        
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
            System.Uri resourceLocater = new System.Uri("/RomeCity;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.GridBarratitulo = ((System.Windows.Controls.Grid)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.GridBarratitulo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBarratitulo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMin_Click3);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMax_Click2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonFechar = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.ButtonFechar.Click += new System.Windows.RoutedEventHandler(this.ButtonFechar_Click1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.login_click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.register_click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 62 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aboutUs_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonOfLogout = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.ButtonOfLogout.Click += new System.Windows.RoutedEventHandler(this.logout_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.ButtonOfCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.ButtonOfCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOfCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonOfOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\MainWindow.xaml"
            this.ButtonOfOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOfOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 94 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Home);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 101 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Hotel);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 108 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 15:
            this.home = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.zimmer = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
