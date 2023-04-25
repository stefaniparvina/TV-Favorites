﻿#pragma checksum "..\..\Profile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9E5CE4318B1238890CF05BE89FB2EB85149F84B48B6EDA2D8F544A9FF861EC6"
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
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logo_button;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mainPage_link;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button watchList_button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid profile;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveChanges;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox myComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TV_Favorites;component/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Profile.xaml"
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
            this.logo_button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Profile.xaml"
            this.logo_button.Click += new System.Windows.RoutedEventHandler(this.logo_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainPage_link = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Profile.xaml"
            this.mainPage_link.Click += new System.Windows.RoutedEventHandler(this.mainPage_link_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.watchList_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Profile.xaml"
            this.watchList_button.Click += new System.Windows.RoutedEventHandler(this.watchList_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.profile = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.saveChanges = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Profile.xaml"
            this.saveChanges.Click += new System.Windows.RoutedEventHandler(this.saveChanges_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.myComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\Profile.xaml"
            this.myComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.myComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

