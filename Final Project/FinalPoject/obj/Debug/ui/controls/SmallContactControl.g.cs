﻿#pragma checksum "..\..\..\..\ui\controls\SmallContactControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB78CF0B757E176312AEA941B4F0B292"
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


namespace FinalPoject.ui.controls {
    
    
    /// <summary>
    /// SmallContactControl
    /// </summary>
    public partial class SmallContactControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\ui\controls\SmallContactControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FinalPoject.ui.controls.SmallContactControl ctrlPerson;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\ui\controls\SmallContactControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblId;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\ui\controls\SmallContactControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblName;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalPoject;component/ui/controls/smallcontactcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ui\controls\SmallContactControl.xaml"
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
            this.ctrlPerson = ((FinalPoject.ui.controls.SmallContactControl)(target));
            
            #line 6 "..\..\..\..\ui\controls\SmallContactControl.xaml"
            this.ctrlPerson.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ctrlPerson_MouseEnter);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\..\ui\controls\SmallContactControl.xaml"
            this.ctrlPerson.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ctrlPerson_MouseLeave);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\..\ui\controls\SmallContactControl.xaml"
            this.ctrlPerson.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ctrlPerson_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblName = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

