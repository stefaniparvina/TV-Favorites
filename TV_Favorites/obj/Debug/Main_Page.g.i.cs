﻿#pragma checksum "..\..\Main_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27E301CA634D0174C30FDA117ADFBB7BE0EFE1CD7A1EA806E21609F5EC5962E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TV_Favorites;


namespace TV_Favorites {
    
    
    /// <summary>
    /// Main_Page
    /// </summary>
    public partial class Main_Page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profile_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gg_button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button friends_button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button got_button;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox myComboBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Main_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logo;
        
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
            System.Uri resourceLocater = new System.Uri("/TV_Favorites;component/main_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Main_Page.xaml"
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
            this.profile_button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Main_Page.xaml"
            this.profile_button.Click += new System.Windows.RoutedEventHandler(this.profile_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gg_button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Main_Page.xaml"
            this.gg_button.Click += new System.Windows.RoutedEventHandler(this.gg_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.friends_button = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Main_Page.xaml"
            this.friends_button.Click += new System.Windows.RoutedEventHandler(this.friends_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.got_button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Main_Page.xaml"
            this.got_button.Click += new System.Windows.RoutedEventHandler(this.got_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.myComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.logo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

