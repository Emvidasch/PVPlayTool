﻿#pragma checksum "..\..\..\View\DarkSouls.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842A32F4E941A97B8B2610377770E1DB4DD76761"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PVPlayTool.View;
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


namespace PVPlayTool.View {
    
    
    /// <summary>
    /// DarkSouls
    /// </summary>
    public partial class DarkSouls : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\View\DarkSouls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BuildEditor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\DarkSouls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Labyrinth;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\DarkSouls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_RagsToRiches;
        
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
            System.Uri resourceLocater = new System.Uri("/PVPlayTool;component/view/darksouls.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DarkSouls.xaml"
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
            
            #line 12 "..\..\..\View\DarkSouls.xaml"
            ((PVPlayTool.View.DarkSouls)(target)).Closed += new System.EventHandler(this.OnDarkSoulsClose);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_BuildEditor = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\DarkSouls.xaml"
            this.btn_BuildEditor.Click += new System.Windows.RoutedEventHandler(this.btn_BuildEditor_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Labyrinth = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btn_RagsToRiches = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\DarkSouls.xaml"
            this.btn_RagsToRiches.Click += new System.Windows.RoutedEventHandler(this.btn_RagsToRiches_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

